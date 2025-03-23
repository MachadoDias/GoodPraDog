using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPraDog
{
    public partial class CreateAccount: Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTxb.UseSystemPasswordChar = !passwordTxb.UseSystemPasswordChar;
            confirmPasswordTxb.UseSystemPasswordChar= passwordTxb.UseSystemPasswordChar; 
            showPasswordButton.BackgroundImage = passwordTxb.UseSystemPasswordChar ? Properties.Resources.eye : Properties.Resources.invisible;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
