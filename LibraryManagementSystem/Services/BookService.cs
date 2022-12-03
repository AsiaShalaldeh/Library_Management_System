using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class BookService
    {
        private LibraryContext _context;
        public BookService(LibraryContext context)
        {
            _context = context;
        }
        public void CreateBook(BookItem bookItem)
        {
            _context.Add<BookItem>(bookItem);
            _context.SaveChanges();
        }
        public BookItem SearchBookByID(int bookId)
        {
            BookItem bookItem = null;
            try
            {
                bookItem = _context.Find<BookItem>(bookId);
            }
            catch (Exception)
            {
                throw;
            }
            return bookItem;
        }
        public string UpdateBook(BookItem book)
        {
            try
            {
                BookItem bookItem = SearchBookByID(book.ISBN);
                if (bookItem != null)
                {
                    bookItem.Title = book.Title;
                    bookItem.Summary = book.Summary;
                    bookItem.Publisher = book.Publisher;
                    bookItem.PublicationDate = book.PublicationDate;
                    bookItem.NumberOfPages = book.NumberOfPages;
                    bookItem.Language = book.Language;
                    bookItem.Barcode = book.Barcode;
                    bookItem.RFID = book.RFID;
                    bookItem.IsReferenceOnly = book.IsReferenceOnly;
                    _context.Update<BookItem>(bookItem);
                    _context.SaveChanges();
                    return "Book Updated Successfully";
                }
                else
                {
                    return "Book Not Found";
                }
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
        public string DeleteUser(int ISBN)
        {
            try
            {
                BookItem bookItem = SearchBookByID(ISBN);
                if (bookItem != null)
                {
                    _context.Remove<BookItem>(bookItem);
                    _context.SaveChanges();
                    return "Book Deleted Successfully";
                }
                else
                {
                    return "Book Not Found";
                }
            }
            catch (Exception ex)
            {
                return "Error : " + ex.Message;
            }
        }
        public IList<string> GetAllBookAuthors(int ISBN)
        {
            IList<string> authorsNames = new List<string>();
            try
            {
                BookItem bookItem = SearchBookByID(ISBN);
                if (bookItem != null)
                {
                    var book = _context.BookAuthors.Where(ba => ba.BookID == ISBN).Select(x => x.Author);                     

                }
                else
                {
                    //"Book Not Found";
                }
            }
            catch (Exception ex)
            {

            }
            return authorsNames;
        }
        public BookItem SearchBookByTitle(string title)
        {
            BookItem bookItem = null;
            try
            {
                bookItem = _context.Find<BookItem>(title);
            }
            catch (Exception)
            {
                throw;
            }
            return bookItem;
        }
        public string getBookWithMaxNumberOfPages()
        {
            BookItem bookItem = null;
            try
            {
                bookItem = _context.BookItems.OrderByDescending(x => x.NumberOfPages).First();
            }
            catch (Exception)
            {
                throw;
            }
            return bookItem.Title;
        }
        public IList<string> getFrenchBooks()
        {
            IList<string> names = new List<string>();
            try
            {
                var books = _context.Books.Where(b => b.Language == "French".Trim().ToLower());
                foreach (var book in books)
                {
                    names.Add(book.Title);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return names;
        }
    }
}
