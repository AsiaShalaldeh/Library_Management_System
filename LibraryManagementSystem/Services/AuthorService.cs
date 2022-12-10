using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class AuthorService
    {

        private LibraryContext _context;
        public AuthorService()
        {
            _context = new LibraryContext();
        }
        public Author CreateAuthor(string name,string bioraphy,DateTime birthDate)
        {
            Author author = new Author();
            try
            {
                author.Name = name;
                author.BirthDate = birthDate;
                author.Biography = bioraphy;
                _context.Add<Author>(author);
                _context.SaveChanges();
                MessageBox.Show("Author Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return author;
        }
        public IList<int> GetAuthorIDs()
        {
            IList<int> ids = new List<int>();
            try
            {
                var authors = _context.Authors.Select(a => a.AuthorID);
                foreach (var a in authors)
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
        public Author GetAuthorByID(int authorID)
        {
            Author author=null;
            try
            {
                author = _context.Authors.Where(au => au.AuthorID == authorID).SingleOrDefault<Author>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return author;
        }
    }
}
