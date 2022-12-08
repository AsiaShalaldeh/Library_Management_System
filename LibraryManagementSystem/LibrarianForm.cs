using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagementSystem.Services.BookService;

namespace LibraryManagementSystem
{
    public partial class LibrarianForm : Form
    {
        CatalogService _catalogService;
        LibraryService _libraryService;
        BookService _bookService;
        AuthorService _authorService;
        PatronService _patronService;
        LibrarianService _librarianService;
        IList<Author> authors;
        IList<BookItem> books;
        public LibrarianForm()
        {
            InitializeComponent();
            ChangeStyle();
            bookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            patronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            createPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            updateBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            serachBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            deleteBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            authorPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            retrievePanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            retrievePatronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            updatePatronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            makeBorrowPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            unborrowPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            _catalogService = new CatalogService();
            _libraryService=new LibraryService();
            _bookService = new BookService();
            _authorService = new AuthorService();
            _patronService = new PatronService();
            _librarianService=new LibrarianService();
            authors = new List<Author>();
            books = new List<BookItem>();
            GetDataFromDB();
        }
        public void GetDataFromDB()
        {
            IList<int> catalogIDList = _catalogService.GetCatalogsIDs();
            bookCatalogIDBox.DataSource = null;
            bookCatalogIDBox.DisplayMember = "ID";
            bookCatalogIDBox.DataSource = catalogIDList;

            IList<int> libraryIDList = _libraryService.GetLibrariesIDs();
            bookLibraryIDBox.DataSource = null;
            bookLibraryIDBox.DisplayMember = "LibraryID";
            bookLibraryIDBox.DataSource = libraryIDList;

            libraryIDCombo.DataSource = null;
            libraryIDCombo.DisplayMember = "LibraryID";
            libraryIDCombo.DataSource = libraryIDList;


            IList<int> librarianIDList = _librarianService.GetLibrariansIDs();
            librarianIDBox.DataSource = null;
            librarianIDBox.DisplayMember = "LibrarianID";
            librarianIDBox.DataSource = librarianIDList;

            IList<int> authorIDs = _authorService.GetAuthorIDs();
            authorsBox.DataSource = null;
            authorsBox.DisplayMember = "AuthorID";
            authorsBox.DataSource = authorIDs;

            IList<int> patronIDs = _patronService.GetAllPatronsID();
            patronIDToUpdate.DataSource = null;
            patronIDToUpdate.DisplayMember = "PatronID";
            patronIDToUpdate.DataSource = patronIDs;

            //acountIDBorrow
            IList<int> accountIDs = _patronService.GetAllAccountIDs();
            acountIDBorrow.DataSource = null;
            acountIDBorrow.DisplayMember = "AccountID";
            acountIDBorrow.DataSource = accountIDs;

            IList<int> bookIDs = _bookService.GetAllBooksISBN();
            bookISBNBox.DataSource = null;
            bookISBNBox.DisplayMember = "LibraryID";
            bookISBNBox.DataSource = bookIDs;
            bookIDBox.DataSource = null;
            bookIDBox.DisplayMember = "ISBN";
            bookIDBox.DataSource = bookIDs;
            bookIDToDelete.DataSource = null;
            bookIDToDelete.DisplayMember = "ISBN";
            bookIDToDelete.DataSource = bookIDs;
            bookIDToUpdateBox.DataSource = null;
            bookIDToUpdateBox.DisplayMember = "ISBN";
            bookIDToUpdateBox.DataSource = bookIDs;
            bookISBNBorrowBox.DataSource = null;
            bookISBNBorrowBox.DisplayMember = "ISBN";
            bookISBNBorrowBox.DataSource = bookIDs;

            accountStateCombo.DataSource = Enum.GetValues(typeof(AccountState));


        }
        public void ChangeStyle()
        {
            foreach (Control con in this.Controls)
            {
                if (con is Button)
                {
                    Button but = con as Button;
                    but.FlatAppearance.BorderSize = 0;
                    but.FlatStyle = FlatStyle.Flat;
                    but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                }
                else if (con is Panel)
                {
                    Panel pan = con as Panel;
                    pan.BackColor = Color.FromArgb(100, 0, 0, 30);
                }
            }
        }
        private void createBookBtn_Click(object sender, EventArgs e)
        {
            createPanel.Visible = true;
        }

        private void createPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelBookPanel_Click(object sender, EventArgs e)
        {
            createPanel.Visible = false;
        }

        private void createBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = bookTitleBox.Text;
                string barcode = bookBarcodeBox.Text;
                string publisher = bookPublisherBox.Text;
                int pages = Convert.ToInt32(bookPagesBox.Text);
                bool isRef = bookRefBox.SelectedText == "True" ? true : false;
                string langauge = bookLanguageBox.Text;
                string RFID = bookRFIDBox.Text;
                DateTime date = bookPubDate.Value;
                string summary = bookSummaryBox.Text;
                int libraryID = Convert.ToInt32(bookLibraryIDBox.SelectedValue.ToString());
                int catalogID = Convert.ToInt32(bookCatalogIDBox.SelectedValue.ToString());
                int librarianID = Convert.ToInt32(librarianIDBox.SelectedValue.ToString());
                BookItem book=_bookService.CreateBook(title, barcode, publisher, pages,
                    isRef, langauge, RFID, date, summary, libraryID, catalogID,librarianID, authors);
                books.Add(book);
                authors.Clear();

                bookTitleBox.Text = "";
                bookBarcodeBox.Text = "";
                bookPublisherBox.Text = "";
                bookPagesBox.Text = "";
                bookLanguageBox.Text = "";
                bookRFIDBox.SelectedText = "";
                bookSummaryBox.Text = "";
                bookLibraryIDBox.Text = "";
                bookCatalogIDBox.Text = "";
                librarianIDBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(bookIDToUpdateBox.SelectedValue.ToString());
                int pages = Convert.ToInt32(bookPagesToUpdate.Text);
                string title = bookTitleToUpdate.Text;
                string summary = bookSummaryToUdate.Text;
                bookIDToUpdateBox.Text = "";
                bookPagesToUpdate.Text = "";
                bookTitleToUpdate.Text = "";
                bookSummaryToUdate.Text = "";
                _bookService.UpdateBook(id, title, summary, pages);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cancelBookUpdatePanel_Click(object sender, EventArgs e)
        {
            updateBookPanel.Visible = false;
        }

        private void updateBookBtn_Click(object sender, EventArgs e)
        {
            updateBookPanel.Visible = true;
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            deleteBookPanel.Visible = true;
        }

        private void cencelBookDeletePanel_Click(object sender, EventArgs e)
        {
            deleteBookPanel.Visible = false;
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int ISBN = Convert.ToInt32(bookIDToDelete.SelectedValue);
                _bookService.DeleteBook(ISBN);
                bookIDToDelete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            serachBookPanel.Visible = true;
        }

        private void cancelSearchbookPanel_Click(object sender, EventArgs e)
        {
            serachBookPanel.Visible = false;
        }

        private void searchBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookISBNSearch.Text.Trim() != "" && bookTitleSearch.Text.Trim() != "")
                {
                    MessageBox.Show("Search By Only One Of Them Not Both !!");
                    bookTitleSearch.Text = "";
                    bookISBNSearch.Text = "";
                }
                else if (bookISBNSearch.Text.Trim()!="")
                {
                    int ISBN = Convert.ToInt32(bookISBNSearch.Text.ToString());
                    _bookService.SearchBookByID(ISBN);
                    bookISBNSearch.Text = "";
                }
                else if (bookTitleSearch.Text.Trim() != "")
                {
                    string title = bookTitleSearch.Text;
                    _bookService.SearchBookByTitle(title);
                    bookTitleSearch.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ ex.Message);
            }

        }

        private void updateBookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteBookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addAuthor_Click(object sender, EventArgs e)
        {

        }

        private void cancelAuthorPanel_Click(object sender, EventArgs e)
        {

        }

        private void createAuthor_Click(object sender, EventArgs e)
        {
            


        }

        private void createAuthorBtn_Click(object sender, EventArgs e)
        {
            authorPanel.Visible = true;
        }

        private void cancelAuthorPanel_Click_1(object sender, EventArgs e)
        {
            authorPanel.Visible = false;
        }

        private void createAuthor_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = authorNameBox.Text;
                string biography = authorBiographyBox.Text;
                DateTime birthdate = authorBirthDate.Value;
                Author author = _authorService.CreateAuthor(name, biography, birthdate);
                //IList<BookAuthor> bookAuthors = new List<BookAuthor>();
                //foreach (BookItem bookItem in books)
                //{
                //    BookAuthor bookAuthor = new BookAuthor();
                //    bookAuthor.AuthorID = author.AuthorID;
                //    bookAuthor.BookID = bookItem.ISBN;
                //    bookAuthors.Add(bookAuthor);
                //}
                //author.Books = bookAuthors;
                //_context.BookItems.Add(bookItem);
                //books.Clear();
                authors.Add(author);
                authorNameBox.Text = "";
                authorBiographyBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void authorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addAuthor_Click_1(object sender, EventArgs e)
        {
            authorPanel.Visible = true;
        }

        private void retrieveBookBtn_Click(object sender, EventArgs e)
        {
            retrievePanel.Visible = true;
        }

        private void cancelRtrievePanel_Click(object sender, EventArgs e)
        {
            retrievePanel.Visible = false;
        }

        private void frenchBooksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IList<string> names = _bookService.getFrenchBooks();
                showFrenchBooks.Text = "";
                foreach (string name in names)
                {
                    showFrenchBooks.Text += name + "\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void maxPagesBtn_Click(object sender, EventArgs e)
        {
            string name = _bookService.getBookWithMaxNumberOfPages();
            maxPagesList.Text = name;
        }

        private void showAuthorsNames_Click(object sender, EventArgs e)
        {
            try
            {
                int bookISBN = Convert.ToInt32(bookIDBox.SelectedValue.ToString());
                IList<string> names = _bookService.GetAllBookAuthors(bookISBN);
                showAuthorsNamesList.Text = "";
                foreach (string name in names)
                {
                    showAuthorsNamesList.Text += name + "\n";
                }
                bookIDBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void retrievePatronBtn_Click(object sender, EventArgs e)
        {
            retrievePatronPanel.Visible = true;
        }

        private void cancelRetrievePatronPanel_Click(object sender, EventArgs e)
        {
            retrievePatronPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IList<string> names = _patronService.GetPatronsNames();
                patronsNamesList.Text = "";
                MessageBox.Show(names.Count().ToString());
                foreach (string name in names)
                {
                    patronsNamesList.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void getFrozenAccountsNames_Click(object sender, EventArgs e)
        {
            try
            {
                IList<string> names = _patronService.GetFrozenPatronsNames();
                patronsNamesList.Text = "";
                foreach (string name in names)
                {
                    PatronsNamesFrozenAccount.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cancelUpdatePanel_Click(object sender, EventArgs e)
        {
            updatePatronPanel.Visible = false;
        }

        private void updatePatronBtn_Click(object sender, EventArgs e)
        {
            updatePatronPanel.Visible = true;
        }

        private void updatePatron_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(patronIDToUpdate.SelectedValue.ToString());
                string name = patronNameToUpdate.Text;
                string address = patronAddressToUpdate.Text;
                int libraryID = Convert.ToInt32(libraryIDCombo.SelectedItem);
                AccountState state = (AccountState)accountStateCombo.SelectedValue;
                _patronService.UpdatePatron(id, name, address, state, libraryID);
                patronIDToUpdate.Text = "";
                patronAddressToUpdate.Text = "";
                patronAddressToUpdate.Text = "";
                libraryIDCombo.Text = "";
                accountStateCombo.Text = "";
                patronIDToUpdate.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void makeBorrowBtn_Click(object sender, EventArgs e)
        {
            makeBorrowPanel.Visible = true;

        }

        private void canelBorrowPanel_Click(object sender, EventArgs e)
        {
            makeBorrowPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int accountID = Convert.ToInt32(acountIDBorrow.SelectedValue.ToString());
                int bookISBN = Convert.ToInt32(bookISBNBorrowBox.SelectedValue.ToString());
                _bookService.MakeBorrow(accountID, bookISBN);
                acountIDBorrow.Text = "";
                bookISBNBorrowBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void makeUnborrowBtn_Click(object sender, EventArgs e)
        {
            unborrowPanel.Visible = true;
        }

        private void cancelUnBorrow_Click(object sender, EventArgs e)
        {
            unborrowPanel.Visible = false;

        }

        private void makeUnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                int ISBN = Convert.ToInt32(bookISBNBox.SelectedItem);
                _bookService.MakeUnBorrow(ISBN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void addExistAuthor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(authorsBox.SelectedValue.ToString());
            Author author = _authorService.GetAuthorByID(id);
            authors.Add(author);
        }
    }
}
