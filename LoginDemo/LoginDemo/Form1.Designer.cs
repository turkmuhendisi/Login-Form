namespace LoginDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signinBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.rePasswordLbl = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.rePasswordField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connection_status = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.registerLbl = new System.Windows.Forms.Label();
            this.headerLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signinBtn
            // 
            this.signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.signinBtn.FlatAppearance.BorderSize = 0;
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinBtn.Location = new System.Drawing.Point(245, 199);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(132, 36);
            this.signinBtn.TabIndex = 0;
            this.signinBtn.Text = "Sign In";
            this.signinBtn.UseVisualStyleBackColor = false;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.signupBtn.FlatAppearance.BorderSize = 0;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signupBtn.Location = new System.Drawing.Point(245, 199);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(132, 36);
            this.signupBtn.TabIndex = 1;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.usernameLbl.Location = new System.Drawing.Point(207, 100);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(71, 16);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.passwordLbl.Location = new System.Drawing.Point(208, 129);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(70, 16);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "password";
            // 
            // rePasswordLbl
            // 
            this.rePasswordLbl.AutoSize = true;
            this.rePasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.rePasswordLbl.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rePasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.rePasswordLbl.Location = new System.Drawing.Point(167, 158);
            this.rePasswordLbl.Name = "rePasswordLbl";
            this.rePasswordLbl.Size = new System.Drawing.Size(111, 16);
            this.rePasswordLbl.TabIndex = 4;
            this.rePasswordLbl.Text = "password again";
            this.rePasswordLbl.Visible = false;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(298, 98);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(151, 22);
            this.usernameField.TabIndex = 5;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(298, 127);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(151, 22);
            this.passwordField.TabIndex = 6;
            // 
            // rePasswordField
            // 
            this.rePasswordField.Location = new System.Drawing.Point(298, 156);
            this.rePasswordField.Name = "rePasswordField";
            this.rePasswordField.Size = new System.Drawing.Size(151, 22);
            this.rePasswordField.TabIndex = 7;
            this.rePasswordField.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // connection_status
            // 
            this.connection_status.AutoSize = true;
            this.connection_status.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connection_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.connection_status.Location = new System.Drawing.Point(322, 275);
            this.connection_status.Name = "connection_status";
            this.connection_status.Size = new System.Drawing.Size(127, 16);
            this.connection_status.TabIndex = 10;
            this.connection_status.Text = "connection_status";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 300);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(12, 128);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(43, 16);
            this.loginLbl.TabIndex = 12;
            this.loginLbl.Text = "Login";
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.registerLbl.ForeColor = System.Drawing.Color.White;
            this.registerLbl.Location = new System.Drawing.Point(12, 156);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(63, 16);
            this.registerLbl.TabIndex = 13;
            this.registerLbl.Text = "Register";
            this.registerLbl.Click += new System.EventHandler(this.registerLbl_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Montserrat Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(118, 117);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(380, 66);
            this.headerLbl.TabIndex = 14;
            this.headerLbl.Text = "LOGIN PANEL";
            this.headerLbl.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(520, 300);
            this.ControlBox = false;
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.connection_status);
            this.Controls.Add(this.rePasswordField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.rePasswordLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signupBtn);
            this.Font = new System.Drawing.Font("Montserrat Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signinBtn;
        private Button signupBtn;
        private Label usernameLbl;
        private Label passwordLbl;
        private Label rePasswordLbl;
        private TextBox usernameField;
        private TextBox passwordField;
        private TextBox rePasswordField;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label connection_status;
        private PictureBox pictureBox2;
        private Label loginLbl;
        private Label registerLbl;
        private Label headerLbl;
    }
}