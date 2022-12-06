using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class PatronService
    {
        private LibraryContext _context;
        public PatronService()
        {
            _context = new LibraryContext();
        }
        public int CreatePatron(string name,string address)
        {
            Patron patron = new Patron();
            patron.Name = name;
            patron.Address = address;
            _context.Add<Patron>(patron);
            _context.SaveChanges();
            return patron.PatronID;
        }
        public void CreateAccount(int patronID, DateTime opened, AccountState state, int libraryID, string history)
        {
            try
            {
                Account account = new Account();
                account.PatronID = patronID;
                account.Opened = opened;
                account.State = state;
                account.History = history;
                account.LibraryID = libraryID;
                _context.Add<Account>(account);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public IList<int> GetAllAccountIDs()
        {
            IList<int> ids = new List<int>();
            try
            {
                var accounts = _context.Accounts.Select(a => a.AccountID);
                foreach(var a in accounts)
                {
                    ids.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ids;
        }
        public Patron SearchPatronByID(int patronID)
        {
            Patron patron = null;
            try
            {
                patron = _context.Find<Patron>(patronID);
            }
            catch (Exception)
            {
                throw;
            }
            return patron;
        }
        public IList<string> GetPatronsNames()
        {
            IList<string> patronsNames = new List<string>();
            try
            {
                patronsNames = _context.Patrons.Select(p => p.Name).ToList();
            }
            catch (Exception ex)
            {

            }
            return patronsNames;
        }
        public IList<string> GetFrozenPatronsNames()
        {
            IList<string> frozenPatronsNames = new List<string>();
            try
            {
                var accounts = _context.Accounts.Where(a=>a.State==AccountState.Frozen).ToList();
                var patrons = accounts.Select(p => p.Patron.Name);
                foreach(var patron in patrons)
                {
                    frozenPatronsNames.Add(patron);
                }
            }
            catch (Exception ex)
            {

            }
            return frozenPatronsNames;
        }
        public string UpdatePatron(Patron patron)
        {
            try
            {
                Patron _patron = SearchPatronByID(patron.PatronID);
                if (_patron != null)
                {
                    _patron.Name=patron.Name;
                    _patron.Address = patron.Address;
                    _context.Update<Patron>(_patron);
                    _context.SaveChanges();
                    return "Patron Updated Successfully";
                }
                else
                {
                    return "Patron Not Found";
                }
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
    }
}
