namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            roundedPanel1 = new Customs.RoundedPanel();
            buttonLogin = new Customs.RoundedButtonVer2();
            textBoxPassword = new Customs.TextBox();
            textBoxEmail = new Customs.TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(roundedPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1496, 826);
            panel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.None;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(buttonLogin);
            roundedPanel1.Controls.Add(textBoxPassword);
            roundedPanel1.Controls.Add(textBoxEmail);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.Location = new Point(562, 190);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 55;
            roundedPanel1.Size = new Size(362, 417);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Thickness = 5F;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(0, 7, 45);
            buttonLogin.BackgroundColor = Color.FromArgb(0, 7, 45);
            buttonLogin.BorderColor = Color.FromArgb(0, 7, 45);
            buttonLogin.BorderRadius = 8;
            buttonLogin.BorderSize = 0;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(78, 314);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(206, 42);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Log In";
            buttonLogin.TextColor = Color.White;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(235, 235, 235);
            textBoxPassword.BorderColor = Color.FromArgb(235, 235, 235);
            textBoxPassword.BorderFocusColor = Color.FromArgb(235, 235, 235);
            textBoxPassword.BorderRadius = 7;
            textBoxPassword.BorderSize = 2;
            textBoxPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(52, 250);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Multiline = false;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Padding = new Padding(10, 7, 10, 7);
            textBoxPassword.PasswordChar = true;
            textBoxPassword.PlaceholderColor = Color.DarkGray;
            textBoxPassword.PlaceholderText = "";
            textBoxPassword.Size = new Size(269, 38);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Texts = "";
            textBoxPassword.UnderlinedStyle = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(235, 235, 235);
            textBoxEmail.BorderColor = Color.FromArgb(235, 235, 235);
            textBoxEmail.BorderFocusColor = Color.FromArgb(235, 235, 235);
            textBoxEmail.BorderRadius = 7;
            textBoxEmail.BorderSize = 2;
            textBoxEmail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(51, 176);
            textBoxEmail.Margin = new Padding(4);
            textBoxEmail.Multiline = false;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Padding = new Padding(10, 7, 10, 7);
            textBoxEmail.PasswordChar = false;
            textBoxEmail.PlaceholderColor = Color.FromArgb(0, 7, 45);
            textBoxEmail.PlaceholderText = "";
            textBoxEmail.Size = new Size(269, 38);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.Texts = "";
            textBoxEmail.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 227);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 153);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "EMAIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 108);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 1;
            label1.Text = "M A N A G E M E N T";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 826);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Customs.RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Customs.TextBox textBoxEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Customs.RoundedButtonVer2 buttonLogin;
        private Customs.TextBox textBoxPassword;
    }
}