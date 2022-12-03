using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LibrarianService
    {
        private LibraryContext _context;
        public LibrarianService(LibraryContext context)
        {
            _context = context;
        }
        public void CreateLibrarian(Librarian librarian)
        {
            _context.Add<Librarian>(librarian);
            _context.SaveChanges();
        }
    }
}
