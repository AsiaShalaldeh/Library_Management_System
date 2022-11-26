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
        public LoginForm()
        {
            InitializeComponent();
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
            else if (userName != "admin")
            {
                MessageBox.Show("User Name Is Worng, Try Again ");
            }
            else if (password != "admin")
            {
                MessageBox.Show("Password Is Worng, Try Again ");
            }
        }
    }
}
