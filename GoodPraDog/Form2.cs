using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPraDog
{
    public partial class CreateAccount: Form
    {
        private void UpdateButtonState()
        {
            createAccountButton.Enabled = !string.IsNullOrEmpty(emailTxb.Text) && !string.IsNullOrWhiteSpace(userTxb.Text) && !string.IsNullOrWhiteSpace(passwordTxb.Text) && !string.IsNullOrWhiteSpace(confirmPasswordTxb.Text);
        }
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
            string email = emailTxb.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Digite um e-mail válido");
                return;
            }
            if (passwordTxb.Text != confirmPasswordTxb.Text)
            {
                MessageBox.Show("As senhas não são iguais");
                return;
            }
            string path = "data.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{emailTxb.Text};{userTxb.Text};{passwordTxb.Text}");
            }
            MessageBox.Show("Conta criada com sucesso");
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTxb.UseSystemPasswordChar = !passwordTxb.UseSystemPasswordChar;
            confirmPasswordTxb.UseSystemPasswordChar= passwordTxb.UseSystemPasswordChar; 
            showPasswordButton.BackgroundImage = passwordTxb.UseSystemPasswordChar ? Properties.Resources.eye : Properties.Resources.invisible;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void emailTxb_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }
        private void userTxb_TextChanged_1(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void passwordTxb_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void confirmPasswordTxb_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonState();
        }
    }
}
