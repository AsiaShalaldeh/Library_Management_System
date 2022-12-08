using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        private readonly LibraryContext _context;
        public LibraryService()
        {
            _context = new LibraryContext();
        }
        public void CreateLibrary(string name, string address,int catalogID)
        {
            try
            {
                Library library = new Library();
                library.Name = name;
                library.Address = address;
                library.CatalogID = catalogID;
                _context.Libraries.Add(library);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public IList<int> GetLibrariesIDs()
        {
            IList<int> ids = new List<int>();
            try
            {
                var list = _context.Libraries.Select(l => l.LibraryID);
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
    }
}
