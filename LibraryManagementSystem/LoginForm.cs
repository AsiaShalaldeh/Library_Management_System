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
    public partial class LoginForm : Form
    {
        LibrarianService _librarianService;
        public LoginForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            _librarianService = new LibrarianService();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userNameBox.Text.ToString().Trim();
            string password = passwordBox.Text.ToString().Trim();
            if (userName.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Enter All Required Values, Try Again ");
            }
            else if (userName == "admin" && password == "admin")
            {
                LibraryForm libraryForm = new LibraryForm();
                libraryForm.Show();
                this.Hide();
            }
            else
            {
                bool isFound = false ;
                var librarians = _librarianService.GetAllLibrarians();
                foreach (var lib in librarians)
                {
                    if (userName.Equals(lib.userName) && password.Equals(lib.password))
                    {
                        LibrarianForm librarianForm = new LibrarianForm();
                        librarianForm.Show();
                        this.Hide();
                        isFound = true;
                    }
                }
                if(!isFound)
                    MessageBox.Show("Wrong UserName And Password");
            }
            userNameBox.Text= "";
            passwordBox.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
