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
        public void CreateBook(string title, string barcode, string publisher,
            int pages, bool isRef, string langauge, string RFID, DateTime date,
            string summary, int libraryID, int catalogID, IList<Author> authors)
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
                IList<BookAuthor> bookAuthors = new List<BookAuthor>();
                foreach (Author author in authors)
                {
                    BookAuthor bookAuthor = new BookAuthor();
                    bookAuthor.AuthorID = author.AuthorID;
                    bookAuthor.BookID = bookItem.ISBN;
                    bookAuthors.Add(bookAuthor);
                }
                MessageBox.Show(bookAuthors.First().BookID.ToString());
                bookItem.Authors = bookAuthors;
                _context.BookItems.Add(bookItem);
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
                if (bookItem != null)
                {
                    MessageBox.Show("Book Found");
                }
                else
                {
                    MessageBox.Show("Book Not Found");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return bookItem;
        }
        public void UpdateBook(int id, string title, string summary, int pages)
        {
            try
            {
                BookItem bookItem = SearchBookByID(id);
                if (bookItem != null)
                {
                    bookItem.Title =title;
                    bookItem.Summary = summary;
                    //bookItem.Publisher = book.Publisher;
                    //bookItem.PublicationDate = book.PublicationDate;
                    bookItem.NumberOfPages = pages;
                    //bookItem.Language = book.Language;
                    //bookItem.Barcode = book.Barcode;
                    //bookItem.RFID = book.RFID;
                    //bookItem.IsReferenceOnly = book.IsReferenceOnly;
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
                    var authors = _context.BookAuthors.Where(ba => ba.BookID == ISBN)
                        .Select(a => a.AuthorID).ToList();
                    foreach (int author in authors)
                    {
                        var name = _context.Authors.Where(a => a.AuthorID == author)
                            .Select(n=>n.Name).Single().ToString();
                        authorsNames.Add(name);
                    }
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
            return authorsNames;
        }
        public BookItem SearchBookByTitle(string title)
        {
            BookItem bookItem = null;
            try
            {
                 bookItem = _context.BookItems.Where(b => b.Title == title)
                    .FirstOrDefault<BookItem>();

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

        public void MakeBorrow(int accountID, string bookTitle)
        {
            try
            {
                BookItem bookItem = SearchBookByTitle(bookTitle);
                bookItem.AccountID = accountID;
                //Account account = _context.Accounts.Where(a => a.AccountID == accountID)
                //.FirstOrDefault<Account>();
                _context.SaveChanges();
                //string name = account.Patron.Name;
                //MessageBox.Show("Book Successfully Borrowed To Patron " + name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void MakeUnBorrow(int ISBN)
        {
            try
            {
                BookItem bookItem = SearchBookByID(ISBN);
                bookItem.AccountID = null;
                _context.SaveChanges();
                MessageBox.Show("Book Rtrieved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public IList<int> GetAllBooksISBN()
        {
            IList<int> ids = new List<int>();
            try
            {
                var books = _context.BookItems.Select(b => b.ISBN);
                foreach (var b in books)
                {
                    ids.Add(b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ids;
        }
        public record _BookItem(int id, string title, string summary, int pages);

    }
}
