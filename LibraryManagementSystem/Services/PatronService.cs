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

        public IList<int> GetAllPatronsID()
        {
            IList<int> ids = new List<int>();
            try
            {
                var patrons = _context.Patrons.Select(p => p.PatronID);
                foreach (var a in patrons)
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
                var names = _context.Patrons.Select(p => p.Name).ToList();
                foreach(var name in names)
                {
                    patronsNames.Add(name);
                }
                MessageBox.Show(patronsNames.Count().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return patronsNames;
        }
        public IList<string> GetFrozenPatronsNames()
        {
            IList<string> frozenPatronsNames = new List<string>();
            try
            {
                var accounts = _context.Accounts.Where(a => a.State == AccountState.Frozen).ToList();
                int? id = accounts.Select(p => p.PatronID).Single();
                IList<string> patrons = _context.Patrons.Where(a => a.PatronID == id).Select(p => p.Name).ToList();
                foreach (var patron in patrons)
                {
                    frozenPatronsNames.Add(patron);
                }
            }
            catch (Exception ex)
            {

            }
            return frozenPatronsNames;
        }
        public void UpdatePatron(int id,string name,string address,AccountState state,int libraryID)
        {
            try
            {
                Patron _patron = SearchPatronByID(id);
                if (_patron != null)
                {
                    _patron.Name=name;
                    _patron.Address = address;
                    Account account = _context.Accounts.Where(a => a.PatronID == id).FirstOrDefault<Account>();
                    if (account != null)
                    {
                        account.LibraryID=libraryID;
                        account.State = state;
                        account.History = account.History + "Account Updated : "
                            + DateTime.Now;
                    }
                    _context.Update<Patron>(_patron);
                    _context.SaveChanges();
                    MessageBox.Show("Patron Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Patron Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        
    }
}
