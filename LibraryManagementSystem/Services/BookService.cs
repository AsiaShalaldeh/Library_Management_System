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
        public BookService()
        {
            _context = new LibraryContext();
        }
        public void CreateBook(string title, string barcode, string publisher, int pages, bool isRef, string langauge, string RFID, DateTime date, string summary, int libraryID, int catalogID)
        {
            try
            {
                BookItem bookItem = new BookItem();
                bookItem.Title = title;
                bookItem.Barcode = barcode;
                bookItem.Publisher = publisher;
                bookItem.LibraryID = libraryID;
                bookItem.CatalogID = catalogID;
                bookItem.Summary = summary;
                bookItem.NumberOfPages = pages;
                bookItem.Language = langauge;
                bookItem.IsReferenceOnly = isRef;
                bookItem.RFID = RFID;
                bookItem.PublicationDate = date;
                _context.Books.Add(bookItem);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        public void UpdateBook(BookItem book)
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
                    MessageBox.Show("Book Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void DeleteBook(int ISBN)
        {
            try
            {
                BookItem bookItem = SearchBookByID(ISBN);
                if (bookItem != null)
                {
                    _context.Remove<BookItem>(bookItem);
                    _context.SaveChanges();
                    MessageBox.Show("Book Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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
