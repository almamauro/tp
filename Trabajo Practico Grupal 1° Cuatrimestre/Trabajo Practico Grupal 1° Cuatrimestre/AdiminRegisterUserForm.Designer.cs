namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class AdiminRegisterUserForm
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
            lblNombre = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            lblFullNameError = new Label();
            lblCorreoElectronico = new Label();
            lblEmailError = new Label();
            lblNombreUsuario = new Label();
            txtUserName = new TextBox();
            lblContraseña = new Label();
            txtPassword = new TextBox();
            lblUsernameError = new Label();
            lblConfirmacioContraseña = new Label();
            txtConfirmPassword = new TextBox();
            lblPasswordError = new Label();
            lblRol = new Label();
            lblConfirmPasswordError = new Label();
            cmbRole = new ComboBox();
            lblRoleError = new Label();
            lblSuccessMessage = new Label();
            btnRegisterUser = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(127, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo:";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(113, 43);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(138, 23);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(138, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblFullNameError
            // 
            lblFullNameError.AutoSize = true;
            lblFullNameError.Location = new Point(117, 81);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(0, 15);
            lblFullNameError.TabIndex = 2;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(117, 107);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(105, 15);
            lblCorreoElectronico.TabIndex = 3;
            lblCorreoElectronico.Text = "Correo electronico";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Location = new Point(117, 180);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(0, 15);
            lblEmailError.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(117, 216);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 6;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(111, 247);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(138, 23);
            txtUserName.TabIndex = 7;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(143, 314);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 9;
            lblContraseña.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 360);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(138, 23);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Location = new Point(117, 287);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(0, 15);
            lblUsernameError.TabIndex = 8;
            // 
            // lblConfirmacioContraseña
            // 
            lblConfirmacioContraseña.AutoSize = true;
            lblConfirmacioContraseña.Location = new Point(106, 401);
            lblConfirmacioContraseña.Name = "lblConfirmacioContraseña";
            lblConfirmacioContraseña.Size = new Size(159, 15);
            lblConfirmacioContraseña.TabIndex = 12;
            lblConfirmacioContraseña.Text = "Confirmacion de Contraseña";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(117, 434);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(138, 23);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Location = new Point(195, 386);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 15);
            lblPasswordError.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(157, 498);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol:";
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Location = new Point(112, 470);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(0, 15);
            lblConfirmPasswordError.TabIndex = 14;
            lblConfirmPasswordError.Click += lblConfirmPasswordError_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(113, 526);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(138, 23);
            cmbRole.TabIndex = 16;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.Location = new Point(157, 552);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(0, 15);
            lblRoleError.TabIndex = 17;
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.Location = new Point(265, 631);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(0, 15);
            lblSuccessMessage.TabIndex = 19;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.Location = new Point(112, 588);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(138, 23);
            btnRegisterUser.TabIndex = 18;
            btnRegisterUser.Text = "Registrar usuario";
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // AdiminRegisterUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 689);
            Controls.Add(btnRegisterUser);
            Controls.Add(lblSuccessMessage);
            Controls.Add(lblRoleError);
            Controls.Add(cmbRole);
            Controls.Add(lblRol);
            Controls.Add(lblConfirmPasswordError);
            Controls.Add(lblConfirmacioContraseña);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblPasswordError);
            Controls.Add(lblContraseña);
            Controls.Add(txtPassword);
            Controls.Add(lblUsernameError);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtUserName);
            Controls.Add(lblEmailError);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(txtEmail);
            Controls.Add(lblFullNameError);
            Controls.Add(txtFullName);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AdiminRegisterUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AdiminRegisterUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label lblFullNameError;
        private Label lblCorreoElectronico;
        private Label lblEmailError;
        private Label lblNombreUsuario;
        private TextBox txtUserName;
        private Label lblContraseña;
        private TextBox txtPassword;
        private Label lblUsernameError;
        private Label lblConfirmacioContraseña;
        private TextBox txtConfirmPassword;
        private Label lblPasswordError;
        private Label lblRol;
        private Label lblConfirmPasswordError;
        private ComboBox cmbRole;
        private Label lblRoleError;
        private Label lblSuccessMessage;
        private Button btnRegisterUser;
    }
}