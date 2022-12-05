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

namespace LibraryManagementSystem
{
    public partial class LibrarianForm : Form
    {
        CatalogService _catalogService;
        LibraryService _libraryService;
        BookService _bookService;
        public LibrarianForm()
        {
            InitializeComponent();
            bookPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            createPanel.BackColor = Color.FromArgb(100, 0, 0, 70);
            _catalogService=new CatalogService();
            _libraryService=new LibraryService();
            _bookService = new BookService();
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
            string title = bookTitleBox.Text;
            string barcode = bookBarcodeBox.Text;
            string publisher = bookPublisherBox.Text;
            int pages = Convert.ToInt32(bookPagesBox.Text);
            bool isRef = bookRefBox.SelectedText == "True" ? true : false ;
            string langauge = bookLanguageBox.Text;
            string RFID = bookRFIDBox.SelectedText;
            DateTime date = bookPubDate.Value;
            string summary = bookSummaryBox.Text;
            int libraryID = Convert.ToInt32(bookLibraryIDBox.SelectedValue.ToString());
            int catalogID = Convert.ToInt32(bookCatalogIDBox.SelectedValue.ToString());

            _bookService.CreateBook(title, barcode, publisher, pages, isRef, langauge, RFID, date, summary, libraryID, catalogID);

            bookTitleBox.Text = "";
            bookBarcodeBox.Text = "";
            bookPublisherBox.Text = "";
            bookPagesBox.Text = "";
            bookLanguageBox.Text = "";
            bookRFIDBox.SelectedText = "";
            bookSummaryBox.Text = "";

        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(bookIDToUpdateBox.Text);
            //_bookService.UpdateBook(id);
        }

        private void cancelBookUpdatePanel_Click(object sender, EventArgs e)
        {
            updateBookPanel.Visible = false;
        }

        private void updateBookBtn_Click(object sender, EventArgs e)
        {
            updateBook.Visible = true;
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
                    BookItem book = _bookService.SearchBookByID(ISBN);
                }
                else if (bookTitleSearch.Text.Trim() != "")
                {
                    string title = bookTitleSearch.Text;
                    BookItem book = _bookService.SearchBookByTitle(title);
                }
                // show book data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
