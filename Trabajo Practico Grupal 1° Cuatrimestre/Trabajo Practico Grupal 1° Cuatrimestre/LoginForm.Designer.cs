
namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class LoginForm
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
            LblUserEmail = new Label();
            txtUsernameEmail = new TextBox();
            lblUsernameEmailError = new Label();
            lblContraseña = new Label();
            txtPassword = new TextBox();
            lblPaswordError = new Label();
            btnLogin = new Button();
            lnkForgotPasword = new LinkLabel();
            SuspendLayout();
            // 
            // LblUserEmail
            // 
            LblUserEmail.AutoSize = true;
            LblUserEmail.Location = new Point(95, 25);
            LblUserEmail.Name = "LblUserEmail";
            LblUserEmail.Size = new Size(221, 15);
            LblUserEmail.TabIndex = 0;
            LblUserEmail.Text = "Correo electronico o Nombre de Usuario";
            LblUserEmail.Click += LblUserEmail_Click;
            // 
            // txtUsernameEmail
            // 
            txtUsernameEmail.Location = new Point(154, 64);
            txtUsernameEmail.Name = "txtUsernameEmail";
            txtUsernameEmail.Size = new Size(100, 23);
            txtUsernameEmail.TabIndex = 1;
            txtUsernameEmail.TextChanged += txtUsernameEmail_TextChanged;
            // 
            // lblUsernameEmailError
            // 
            lblUsernameEmailError.AutoSize = true;
            lblUsernameEmailError.ForeColor = Color.Red;
            lblUsernameEmailError.Location = new Point(183, 110);
            lblUsernameEmailError.Name = "lblUsernameEmailError";
            lblUsernameEmailError.Size = new Size(38, 15);
            lblUsernameEmailError.TabIndex = 2;
            lblUsernameEmailError.Text = "label1";
            lblUsernameEmailError.Visible = false;
            lblUsernameEmailError.Click += lblUsernameEmailError_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(169, 154);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.Click += lblContraseña_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPaswordError
            // 
            lblPaswordError.AutoSize = true;
            lblPaswordError.ForeColor = Color.Red;
            lblPaswordError.Location = new Point(183, 253);
            lblPaswordError.Name = "lblPaswordError";
            lblPaswordError.Size = new Size(38, 15);
            lblPaswordError.TabIndex = 5;
            lblPaswordError.Text = "label1";
            lblPaswordError.Visible = false;
            lblPaswordError.Click += lblPaswordError_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(160, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkForgotPasword
            // 
            lnkForgotPasword.AutoSize = true;
            lnkForgotPasword.Location = new Point(136, 345);
            lnkForgotPasword.Name = "lnkForgotPasword";
            lnkForgotPasword.Size = new Size(139, 15);
            lnkForgotPasword.TabIndex = 7;
            lnkForgotPasword.TabStop = true;
            lnkForgotPasword.Text = "¿olvidaste tu contraseña?";
            lnkForgotPasword.LinkClicked += lnkForgotPasword_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 399);
            Controls.Add(lnkForgotPasword);
            Controls.Add(btnLogin);
            Controls.Add(lblPaswordError);
            Controls.Add(txtPassword);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsernameEmailError);
            Controls.Add(txtUsernameEmail);
            Controls.Add(LblUserEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private Label LblUserEmail;
        private TextBox txtUsernameEmail;
        private Label lblUsernameEmailError;
        private Label lblContraseña;
        private TextBox txtPassword;
        private Label lblPaswordError;
        private Button btnLogin;
        private LinkLabel lnkForgotPasword;
    }
}
