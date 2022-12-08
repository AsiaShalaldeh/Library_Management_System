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
    public partial class LibraryForm : Form
    {
        CatalogService _catalogService;
        PatronService _patronService;
        LibraryService _libraryService;
        LibrarianService _librarianService;
        
        public LibraryForm()
        {
            InitializeComponent();
            ChangeStyle();
            //AdminPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            //catalogPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            //libraryPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            //librarianPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            //patronPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            _catalogService = new CatalogService();
            _patronService = new PatronService();
            _libraryService = new LibraryService();
            _librarianService = new LibrarianService();
            GetDataFromDB();
        }

        public void GetDataFromDB()
        {
            IList<int> catalogIDList = _catalogService.GetCatalogsIDs();
            catalogIDForLibrary.DataSource = null;
            catalogIDForLibrary.DisplayMember = "ID";
            catalogIDForLibrary.DataSource = catalogIDList;

            IList<int> libraryIDList = _libraryService.GetLibrariesIDs();
            libraryIDForPatron.DataSource = null;
            libraryIDForPatron.DisplayMember = "LibraryID";
            libraryIDForPatron.DataSource = libraryIDList;
   
            accountStateBox.DataSource = Enum.GetValues(typeof(AccountState));
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
                else if(con is Panel)
                {
                    Panel pan=con as Panel;
                    pan.BackColor = Color.FromArgb(100, 0, 0, 30);
                }
            }
        }

        private void createPatronBtn_Click(object sender, EventArgs e)
        {
            patronPanel.Visible = true;
            AdminPanel.Visible = false;
        }

        private void createCatalogBtn_Click(object sender, EventArgs e)
        {
            catalogPanel.Visible = true;
            AdminPanel.Visible = false;
        }

        private void createCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                string name = catalogNameBox.Text;
                if (name.Trim() == "")
                {
                    MessageBox.Show("Please, Enter Catalog Name !");
                }
                _catalogService.CreateCatalog(name);
                GetDataFromDB();
                catalogNameBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cancelCatalog_Click(object sender, EventArgs e)
        {
            catalogPanel.Visible = false;
            AdminPanel.Visible = true;

        }

        private void createLibraryBtn_Click(object sender, EventArgs e)
        {
            libraryPanel.Visible = true;
            AdminPanel.Visible = false;
        }

        private void createLibrary_Click(object sender, EventArgs e)
        {
            try
            {
                string name = libraryNameBox.Text;
                string address = libraryAddressBox.Text;
                int catalogID = Convert.ToInt32(catalogIDForLibrary.SelectedItem.ToString());
                if (name.Trim() == "" || address.Trim() == "")
                {
                    MessageBox.Show("Please, Enter All Library Information !");
                }
                _libraryService.CreateLibrary(name, address, catalogID);
                GetDataFromDB();
                libraryNameBox.Text = "";
                libraryAddressBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void createLibraryBtn_Click_1(object sender, EventArgs e)
        {
            libraryPanel.Visible = true;
            AdminPanel.Visible = false;

        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelLibrary_Click(object sender, EventArgs e)
        {
            libraryPanel.Visible = false;
            AdminPanel.Visible = true;

        }

        private void createLibrarian_Click(object sender, EventArgs e)
        {
            try
            {
                string name = librarianNameBox.Text;
                string address = librarianAddressBox.Text;
                string password = librarianPassBox.Text;
                string position = librarianPositionBox.Text;
                if (name.Trim() == "" || address.Trim() == "" || position.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("Please, Enter All Librarian Information !");
                }
                _librarianService.CreateLibrarian(name, password, position, address);
                librarianNameBox.Text = "";
                librarianAddressBox.Text = "";
                librarianPassBox.Text = "";
                librarianPositionBox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cancelLibrarian_Click(object sender, EventArgs e)
        {
            librarianPanel.Visible = false;
            AdminPanel.Visible = true;
        }

        private void createLibrarianBtn_Click(object sender, EventArgs e)
        {
            librarianPanel.Visible = true;
            AdminPanel.Visible = false;
        }

        private void openedAccountDate_ValueChanged(object sender, EventArgs e)
        {
            openedAccountDate.Value = DateTime.Now;
        }

        private void patronPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createPatron_Click(object sender, EventArgs e)
        {
            try
            {
                string name = patronNameBox.Text;
                string address = patronAddressBox.Text;
                DateTime opened = openedAccountDate.Value;
                string history = "Account Created : " + DateTime.Now;
                AccountState state = (AccountState)accountStateBox.SelectedValue;
                int libraryID = Convert.ToInt32(libraryIDForPatron.SelectedItem.ToString());
                patronNameBox.Text = "";
                patronAddressBox.Text = "";
                if (name.Trim() == "" || address.Trim() == "")
                {
                    MessageBox.Show("Please, Enter All Patron Information !");
                }
                int patronID = _patronService.CreatePatron(name, address);
                _patronService.CreateAccount(patronID, opened, state, libraryID, history);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("You Entered Number Instead Of String !!");   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void cancelPatronPanel_Click(object sender, EventArgs e)
        {
            patronPanel.Visible = false;
            AdminPanel.Visible = true;
        }

        private void goToLoginPage_Click(object sender, EventArgs e)
        {
            LoginForm loginForm=new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void exitAdminPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
