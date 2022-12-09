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
        public BookItem CreateBook(string title, string barcode, string publisher,
            int pages, bool isRef, string langauge, string RFID, DateTime date,
            string summary, int libraryID, int catalogID, int librarianID, IList<Author> authors)
        {
            BookItem bookItem = new BookItem();
            //try
            //{
                //if (title == "" || barcode == "" || publisher == "" || pages == null
                //    || langauge == "" || langauge == "" || RFID == "" || summary == ""
                //    || librarianID == null || catalogID == null || librarianID == null
                //    || authors.Count == 0)
                //{
                //    MessageBox.Show("You Have To Enter All Information !!");
                //    return null;
                //}
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
                bookItem.LibrarianID = librarianID;
                IList<BookAuthor> bookAuthors = new List<BookAuthor>();
                foreach (Author author in authors)
                {
                    BookAuthor bookAuthor = new BookAuthor();
                    bookAuthor.AuthorID = author.AuthorID;
                    bookAuthor.BookID = bookItem.ISBN;
                    bookAuthors.Add(bookAuthor);
                }
                //_context.Libraries.Where(l => l.LibraryID == libraryID).Single()
                //    .bookItems.Add(bookItem);
                //_context.Catalog.Where(c => c.ID == catalogID).Single()
                //    .bookItems.Add(bookItem);
                bookItem.Authors = bookAuthors;
                _context.BookItems.Add(bookItem);
                _context.SaveChanges();
                MessageBox.Show("Book Created Successfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            return bookItem;
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
                if (id == null || title.Trim() == "" || summary.Trim() == "" || pages == null)
                {
                    MessageBox.Show("You Have To Enter All Information !!");
                    return;
                }
                BookItem bookItem = SearchBookByID(id);
                if (bookItem != null)
                {
                    bookItem.Title =title;
                    bookItem.Summary = summary;
                    bookItem.NumberOfPages = pages;
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
                    var authors = _context.BookAuthors.Where(b => b.BookID == ISBN).Select(a => a.AuthorID).ToList();
                    foreach (int id in authors)
                    {
                        BookAuthor bookAuthor = _context.BookAuthors.Where(b => b.BookID == ISBN)
                            .Where(a => a.AuthorID == id).FirstOrDefault();
                        _context.Remove<BookAuthor>(bookAuthor);
                        var author = _context.Authors.Where(a => a.AuthorID == id).Single();
                        _context.Authors.Remove(author);
                    }
                    _context.SaveChanges();
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

        public void MakeBorrow(int accountID, int bookISBN)
        {
            try
            {
                BookItem bookItem = SearchBookByID(bookISBN);
                if(bookItem.AccountID==null)
                {
                    bookItem.AccountID = accountID;
                    _context.Accounts.Where(a => a.AccountID == accountID)
                        .Single().BookItems.Add(bookItem);
                    //int patron = _context.Accounts.Where(a => a.AccountID == accountID).Select(p => p.PatronID);
                    //string name = _context.Patrons.Where(p => p.PatronID == patron);
                    MessageBox.Show("Book Borrowed Successfully");
                }
                else
                {
                    MessageBox.Show("Sorry, Book Already Borrowed To Someone Else !");
                }
                _context.SaveChanges();
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
                int? accountID = bookItem.AccountID;
                _context.Accounts.Where(c => c.AccountID == accountID)
                    .Select(c => c.BookItems).Single().Remove(bookItem);
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
