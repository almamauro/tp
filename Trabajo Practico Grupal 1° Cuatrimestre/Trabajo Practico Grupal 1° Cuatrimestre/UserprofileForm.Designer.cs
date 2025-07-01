namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class UserprofileForm
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
            lblFullNameError = new Label();
            lblCorreo = new Label();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            lblNombreUsuario = new Label();
            lblEmailError = new Label();
            txtRole = new TextBox();
            lblTuRol = new Label();
            lblUsernameError = new Label();
            btnSavePersonalData = new Button();
            lblSuccessMessage = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(101, 13);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(108, 46);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblFullNameError
            // 
            lblFullNameError.AutoSize = true;
            lblFullNameError.Location = new Point(136, 73);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(32, 15);
            lblFullNameError.TabIndex = 2;
            lblFullNameError.Text = "error";
            lblFullNameError.Click += lblFullNameError_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(110, 102);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo Electronico";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(110, 198);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 7;
            txtUserName.TextChanged += textBox2_TextChanged;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(108, 180);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 6;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Location = new Point(136, 151);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(43, 15);
            lblEmailError.TabIndex = 5;
            lblEmailError.Text = "ERROR";
            lblEmailError.Click += label4_Click;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(108, 280);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(100, 23);
            txtRole.TabIndex = 10;
            txtRole.TextChanged += textBox1_TextChanged_1;
            // 
            // lblTuRol
            // 
            lblTuRol.AutoSize = true;
            lblTuRol.Location = new Point(141, 262);
            lblTuRol.Name = "lblTuRol";
            lblTuRol.Size = new Size(40, 15);
            lblTuRol.TabIndex = 9;
            lblTuRol.Text = "Tu Rol";
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Location = new Point(141, 233);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(32, 15);
            lblUsernameError.TabIndex = 8;
            lblUsernameError.Text = "error";
            lblUsernameError.Click += lblUsernameError_Click;
            // 
            // btnSavePersonalData
            // 
            btnSavePersonalData.Location = new Point(97, 321);
            btnSavePersonalData.Name = "btnSavePersonalData";
            btnSavePersonalData.Size = new Size(118, 23);
            btnSavePersonalData.TabIndex = 11;
            btnSavePersonalData.Text = "Gaurdar Cambios";
            btnSavePersonalData.UseVisualStyleBackColor = true;
            btnSavePersonalData.Click += btnSavePersonalData_Click;
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.Location = new Point(134, 357);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(51, 15);
            lblSuccessMessage.TabIndex = 12;
            lblSuccessMessage.Text = "mensaje";
            lblSuccessMessage.Click += lblSuccessMessage_Click;
            // 
            // UserprofileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(lblSuccessMessage);
            Controls.Add(btnSavePersonalData);
            Controls.Add(txtRole);
            Controls.Add(lblTuRol);
            Controls.Add(lblUsernameError);
            Controls.Add(txtUserName);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblEmailError);
            Controls.Add(txtEmail);
            Controls.Add(lblCorreo);
            Controls.Add(lblFullNameError);
            Controls.Add(txtFullName);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserprofileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil de usuario";
            Load += UserprofileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtFullName;
        private Label lblFullNameError;
        private Label lblCorreo;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Label lblNombreUsuario;
        private Label lblEmailError;
        private TextBox txtRole;
        private Label lblTuRol;
        private Label lblUsernameError;
        private Button btnSavePersonalData;
        private Label lblSuccessMessage;
    }
}