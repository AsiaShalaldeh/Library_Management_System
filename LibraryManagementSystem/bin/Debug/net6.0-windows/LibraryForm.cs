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
        // CatalogService catalogService
        public LibraryForm()
        {
            InitializeComponent();
            ChangeStyle();
            AdminPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            catalogPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            libraryPanel.BackColor = Color.FromArgb(100, 0, 0, 30);
            
            _catalogService = new CatalogService();
            _patronService = new PatronService();
            _libraryService = new LibraryService();
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
            }
        }

        private void createPatronBtn_Click(object sender, EventArgs e)
        {

        }

        private void createCatalogBtn_Click(object sender, EventArgs e)
        {
            catalogPanel.Visible = true;
        }

        private void createCatalog_Click(object sender, EventArgs e)
        {
            string name = catalogNameBox.Text;
            if (name.Trim() == "")
            {
                MessageBox.Show("Please, Enter Catalog Name !");
            }
            _catalogService.CreateCatalog(name);
            catalogNameBox.Text = "";
        }

        private void cancelCatalog_Click(object sender, EventArgs e)
        {
            catalogPanel.Visible = false;
        }

        private void createLibraryBtn_Click(object sender, EventArgs e)
        {
            libraryPanel.Visible = true;
        }

        private void createLibrary_Click(object sender, EventArgs e)
        {
            string name = libraryNameBox.Text;
            string address = libraryAddressBox.Text;
            _libraryService.CreateLibrary(name, address);
            libraryNameBox.Text = "";
            libraryAddressBox.Text = "";
        }

        private void createLibraryBtn_Click_1(object sender, EventArgs e)
        {
            libraryPanel.Visible = true;
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelLibrary_Click(object sender, EventArgs e)
        {
            libraryPanel.Visible = false ;

        }
    }
}
