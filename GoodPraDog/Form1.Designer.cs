namespace GoodPraDog
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.subtitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.newAccountLink = new System.Windows.Forms.LinkLabel();
            this.userTxb = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.passwordTxb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showPasswordButton);
            this.panel1.Controls.Add(this.subtitle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.newAccountLink);
            this.panel1.Controls.Add(this.userTxb);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.passwordTxb);
            this.panel1.Location = new System.Drawing.Point(413, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 567);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.BackColor = System.Drawing.SystemColors.Window;
            this.showPasswordButton.BackgroundImage = global::GoodPraDog.Properties.Resources.eye;
            this.showPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPasswordButton.FlatAppearance.BorderSize = 0;
            this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordButton.ForeColor = System.Drawing.Color.Transparent;
            this.showPasswordButton.Location = new System.Drawing.Point(193, 284);
            this.showPasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(22, 24);
            this.showPasswordButton.TabIndex = 12;
            this.showPasswordButton.UseVisualStyleBackColor = false;
            this.showPasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.BackColor = System.Drawing.Color.Transparent;
            this.subtitle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(64, 140);
            this.subtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(119, 22);
            this.subtitle.TabIndex = 11;
            this.subtitle.Text = "Tela de Login";
            this.subtitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(59, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(59, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(105)))), ((int)(((byte)(90)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(68, 340);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 24);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Entrar";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // newAccountLink
            // 
            this.newAccountLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(105)))), ((int)(((byte)(90)))));
            this.newAccountLink.AutoSize = true;
            this.newAccountLink.BackColor = System.Drawing.Color.Transparent;
            this.newAccountLink.LinkColor = System.Drawing.Color.Maroon;
            this.newAccountLink.Location = new System.Drawing.Point(88, 376);
            this.newAccountLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newAccountLink.Name = "newAccountLink";
            this.newAccountLink.Size = new System.Drawing.Size(75, 13);
            this.newAccountLink.TabIndex = 4;
            this.newAccountLink.TabStop = true;
            this.newAccountLink.Text = "Crie sua conta";
            this.newAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // userTxb
            // 
            this.userTxb.BackColor = System.Drawing.SystemColors.Window;
            this.userTxb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxb.Location = new System.Drawing.Point(27, 204);
            this.userTxb.Margin = new System.Windows.Forms.Padding(2);
            this.userTxb.Name = "userTxb";
            this.userTxb.Size = new System.Drawing.Size(195, 29);
            this.userTxb.TabIndex = 1;
            this.userTxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(60, 98);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(150, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Pet Care";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordTxb
            // 
            this.passwordTxb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxb.Location = new System.Drawing.Point(27, 281);
            this.passwordTxb.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxb.Name = "passwordTxb";
            this.passwordTxb.Size = new System.Drawing.Size(195, 29);
            this.passwordTxb.TabIndex = 10;
            this.passwordTxb.UseSystemPasswordChar = true;
            this.passwordTxb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GoodPraDog.Properties.Resources.b7768e84bd144332a193310b0bbdbb2d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(661, 495);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox userTxb;
        private System.Windows.Forms.TextBox passwordTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel newAccountLink;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Button showPasswordButton;
    }
}

