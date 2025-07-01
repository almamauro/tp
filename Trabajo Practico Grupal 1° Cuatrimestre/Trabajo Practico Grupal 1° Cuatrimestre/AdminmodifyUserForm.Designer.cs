namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class AdminModifyUserForm
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
            lblIdUsuario = new Label();
            txtUserId = new TextBox();
            lblNombre = new Label();
            txtFullName = new TextBox();
            lblFullNameError = new Label();
            lblCorreo = new Label();
            lblRol = new Label();
            lblEmailError = new Label();
            txtEmail = new TextBox();
            cmRole = new ComboBox();
            lblRoleError = new Label();
            lblNombreUsuario = new Label();
            lblUserNameError = new Label();
            txtUserName = new TextBox();
            btnSaveUser = new Button();
            btnResetPassword = new Button();
            lblSuccesMessage = new Label();
            SuspendLayout();
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(155, 15);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(76, 15);
            lblIdUsuario.TabIndex = 0;
            lblIdUsuario.Text = "Id de Usuario";
            lblIdUsuario.Click += lblIdUsuario_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(141, 33);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(100, 23);
            txtUserId.TabIndex = 1;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(141, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre Completo";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(141, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 3;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblFullNameError
            // 
            lblFullNameError.AutoSize = true;
            lblFullNameError.Location = new Point(169, 129);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(32, 15);
            lblFullNameError.TabIndex = 4;
            lblFullNameError.Text = "error";
            lblFullNameError.Click += lblFullNameError_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(141, 144);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo Electronico";
            lblCorreo.Click += lblCorreo_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(169, 274);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Location = new Point(170, 188);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(32, 15);
            lblEmailError.TabIndex = 7;
            lblEmailError.Text = "error";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // cmRole
            // 
            cmRole.FormattingEnabled = true;
            cmRole.Location = new Point(127, 292);
            cmRole.Name = "cmRole";
            cmRole.Size = new Size(121, 23);
            cmRole.TabIndex = 13;
            cmRole.SelectedIndexChanged += cmRole_SelectedIndexChanged;
            // 
            // lblRoleError
            // 
            lblRoleError.AutoSize = true;
            lblRoleError.Location = new Point(169, 328);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(43, 15);
            lblRoleError.TabIndex = 14;
            lblRoleError.Text = "ERROR";
            lblRoleError.Click += lblRoleError_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(136, 203);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 9;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            lblUserNameError.Location = new Point(169, 257);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new Size(32, 15);
            lblUserNameError.TabIndex = 11;
            lblUserNameError.Text = "error";
            lblUserNameError.Click += lblUserNameError_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(141, 231);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 10;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(118, 356);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(143, 23);
            btnSaveUser.TabIndex = 15;
            btnSaveUser.Text = "Guardar Cambios";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(118, 400);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(143, 23);
            btnResetPassword.TabIndex = 16;
            btnResetPassword.Text = "Restablecer Contraseña";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblSuccesMessage
            // 
            lblSuccesMessage.AutoSize = true;
            lblSuccesMessage.Location = new Point(169, 447);
            lblSuccesMessage.Name = "lblSuccesMessage";
            lblSuccesMessage.Size = new Size(51, 15);
            lblSuccesMessage.TabIndex = 17;
            lblSuccesMessage.Text = "mensaje";
            lblSuccesMessage.Click += lblSuccesMessage_Click;
            // 
            // AdminModifyUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 489);
            Controls.Add(lblSuccesMessage);
            Controls.Add(btnResetPassword);
            Controls.Add(btnSaveUser);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblUserNameError);
            Controls.Add(txtUserName);
            Controls.Add(lblRoleError);
            Controls.Add(cmRole);
            Controls.Add(lblRol);
            Controls.Add(lblEmailError);
            Controls.Add(txtEmail);
            Controls.Add(lblCorreo);
            Controls.Add(lblFullNameError);
            Controls.Add(txtFullName);
            Controls.Add(lblNombre);
            Controls.Add(txtUserId);
            Controls.Add(lblIdUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminModifyUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificacion";
            Load += AdminmodifyUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdUsuario;
        private TextBox txtUserId;
        private Label lblNombre;
        private TextBox txtFullName;
        private Label lblFullNameError;
        private Label lblCorreo;
        private Label lblRol;
        private Label lblEmailError;
        private TextBox txtEmail;
        private ComboBox cmRole;
        private Label lblRoleError;
        private Label lblNombreUsuario;
        private Label lblUserNameError;
        private TextBox txtUserName;
        private Button btnSaveUser;
        private Button btnResetPassword;
        private Label lblSuccesMessage;
    }
}