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
        IList<Author> authors;
        public LibrarianForm()
        {
            InitializeComponent();
            ChangeStyle();
            //bookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //patronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //createPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //updateBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //serachBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //deleteBookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //authorPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //retrievePanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //retrievePatronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //updatePatronPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //makeBorrowPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            //unborrowPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            _catalogService = new CatalogService();
            _libraryService=new LibraryService();
            _bookService = new BookService();
            _authorService = new AuthorService();
            _patronService = new PatronService();
            authors = new List<Author>();
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

            //IList<int> authorIDs = _authorService.GetAuthorIDs();
            //authorsIDsBox.DataSource = null;
            //authorsIDsBox.DisplayMember = "AuthorID";
            //authorsIDsBox.DataSource = authorIDs;


            IList<int> bookIDs = _bookService.GetAllBooksISBN();
            bookISBNBox.DataSource = null;
            bookISBNBox.DisplayMember = "LibraryID";
            bookISBNBox.DataSource = bookIDs;

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
                //int librarianID=Convert.ToInt32()
                _bookService.CreateBook(title, barcode, publisher, pages,
                    isRef, langauge, RFID, date, summary, libraryID, catalogID, authors);
                authors.Clear();

                bookTitleBox.Text = "";
                bookBarcodeBox.Text = "";
                bookPublisherBox.Text = "";
                bookPagesBox.Text = "";
                bookLanguageBox.Text = "";
                bookRFIDBox.SelectedText = "";
                bookSummaryBox.Text = "";
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
                int id = Convert.ToInt32(bookIDToUpdateBox.Text);
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
            int id = Convert.ToInt32(bookIDToUpdateBox.Text);
            _bookService.DeleteBook(id);
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
                    bookISBNSearch.Text = "";
                    bookTitleSearch.Text = "";
                }
                else if (bookISBNSearch.Text.Trim()!="")
                {
                    int ISBN = Convert.ToInt32(bookISBNSearch.Text);
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
                int bookISBN = Convert.ToInt32(bookIDBox.Text);
                IList<string> names = _bookService.GetAllBookAuthors(bookISBN);
                showAuthorsNamesList.Text = "";
                foreach (string name in names)
                {
                    showAuthorsNamesList.Text += name + "\n";
                }
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
                    patronsNamesList.Text += "\n" + name;
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
                    PatronsNamesFrozenAccount.Text += "\n" + name;
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
                int id = Convert.ToInt32(patronIDToUpdate.Text);
                string name = patronNameToUpdate.Text;
                string address = patronAddressToUpdate.Text;
                int libraryID = Convert.ToInt32(libraryIDCombo.SelectedItem);
                AccountState state = (AccountState)accountStateCombo.SelectedValue;
                _patronService.UpdatePatron(id, name, address, state, libraryID);
                patronIDToUpdate.Text = "";
                patronAddressToUpdate.Text = "";
                patronAddressToUpdate.Text = "";
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
                int accountID = Convert.ToInt32(acountIDBorrow.Text);
                string bookTitle = bookTitleBorrow.Text;
                _bookService.MakeBorrow(accountID, bookTitle);
                acountIDBorrow.Text = "";
                bookTitleBorrow.Text = "";
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
    }
}
