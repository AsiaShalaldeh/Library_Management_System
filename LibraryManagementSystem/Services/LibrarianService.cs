using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LibrarianService: ISearchService, IManageService
    {
        private LibraryContext _context;
        public LibrarianService()
        {
            _context = new LibraryContext();
        }
        public void CreateLibrarian(string name, string password, string position, string address)
        {
            try
            {
                Librarian librarian = new Librarian();
                librarian.Name = name;
                librarian.Password = password;
                librarian.Position = position;
                librarian.Address = address;
                _context.Librarian.Add(librarian);
                _context.SaveChanges();
                MessageBox.Show("Librarian Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
        public IList<int> GetLibrariansIDs()
        {
            IList<int> ids = new List<int>();
            try
            {
                var list = _context.Librarian.Select(l => l.LibrarianID);
                foreach (var id in list)
                {
                    ids.Add(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ids;
        }
        public IList<_Librarian> GetAllLibrarians()
        {
            IList<_Librarian> librarians = new List<_Librarian>();
            try
            {
                var list = _context.Librarian.Select(x => new { x.Name, x.Password });
                foreach (var librarian in list)
                {
                    librarians.Add(new _Librarian(librarian.Name, librarian.Password));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return librarians;
        }
        public record _Librarian(string userName, string password);
    }
}

