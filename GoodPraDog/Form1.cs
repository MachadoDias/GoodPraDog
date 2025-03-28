using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPraDog
{
    public partial class Form1: Form
    {
        private bool Login(string usuario, string senha, string arquivo)
        {
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(';');
                if (partes[1] == usuario && partes[2] == senha)
                {
                    return true;
                }
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string path = "data.txt";
            if (Login(userTxb.Text, passwordTxb.Text, path))
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordTxb.UseSystemPasswordChar = !passwordTxb.UseSystemPasswordChar;
            showPasswordButton.BackgroundImage = passwordTxb.UseSystemPasswordChar ? Properties.Resources.eye : Properties.Resources.invisible;
        }
    }
}
