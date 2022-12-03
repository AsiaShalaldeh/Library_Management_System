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
        private LibraryContext _context;
        public LibraryService()
        {
            _context = new LibraryContext();
        }
        public void CreateLibrary(string name,string address)
        {
            Library library = new Library();
            library.Name = name;
            library.Address = address;
            _context.Add<Library>(library);
            _context.SaveChanges();
        }
    }
}
