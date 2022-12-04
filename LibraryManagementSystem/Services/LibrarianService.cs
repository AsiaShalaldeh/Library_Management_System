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
        public LibrarianService()
        {
            _context =new LibraryContext();
        }
        public void CreateLibrarian(string name,string password,string position,string address)
        {
            Librarian librarian = new Librarian();
            librarian.Name = name;
            librarian.Password = password;
            librarian.Position = position;
            librarian.Address = address;
            _context.Librarian.Add(librarian);
            _context.SaveChanges();
        }
    }
}
