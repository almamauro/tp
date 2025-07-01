namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class ForgotPasswordStep3Form
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
            lblNuevaContraseña = new Label();
            txtNewPasswod = new TextBox();
            lblNewPasswordError = new Label();
            lblConfirmarContraseña = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPasswordError = new Label();
            btnResetPassword = new Button();
            LblSuccessMessage = new Label();
            SuspendLayout();
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Location = new Point(110, 32);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(104, 15);
            lblNuevaContraseña.TabIndex = 0;
            lblNuevaContraseña.Text = "Nueva Contraseña";
            lblNuevaContraseña.Click += lblNuevaContraseña_Click;
            // 
            // txtNewPasswod
            // 
            txtNewPasswod.Location = new Point(67, 76);
            txtNewPasswod.Name = "txtNewPasswod";
            txtNewPasswod.Size = new Size(205, 23);
            txtNewPasswod.TabIndex = 1;
            txtNewPasswod.UseSystemPasswordChar = true;
            txtNewPasswod.TextChanged += txtNewPasswod_TextChanged;
            // 
            // lblNewPasswordError
            // 
            lblNewPasswordError.AutoSize = true;
            lblNewPasswordError.Location = new Point(139, 128);
            lblNewPasswordError.Name = "lblNewPasswordError";
            lblNewPasswordError.Size = new Size(43, 15);
            lblNewPasswordError.TabIndex = 2;
            lblNewPasswordError.Text = "ERROR";
            lblNewPasswordError.Click += lblNewPasswordError_Click;
            // 
            // lblConfirmarContraseña
            // 
            lblConfirmarContraseña.AutoSize = true;
            lblConfirmarContraseña.Location = new Point(78, 174);
            lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            lblConfirmarContraseña.Size = new Size(161, 15);
            lblConfirmarContraseña.TabIndex = 3;
            lblConfirmarContraseña.Text = "Confirmar Nueva Contraseña";
            lblConfirmarContraseña.Click += lblConfirmarContraseña_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(67, 233);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(184, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Location = new Point(139, 286);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(43, 15);
            lblConfirmPasswordError.TabIndex = 5;
            lblConfirmPasswordError.Text = "ERROR";
            lblConfirmPasswordError.Click += lblConfirmPasswordError_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(124, 328);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(75, 23);
            btnResetPassword.TabIndex = 6;
            btnResetPassword.Text = "Restablecer Contraseña";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // LblSuccessMessage
            // 
            LblSuccessMessage.AutoSize = true;
            LblSuccessMessage.Location = new Point(144, 376);
            LblSuccessMessage.Name = "LblSuccessMessage";
            LblSuccessMessage.Size = new Size(33, 15);
            LblSuccessMessage.TabIndex = 7;
            LblSuccessMessage.Text = "Exito";
            // 
            // ForgotPasswordStep3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(LblSuccessMessage);
            Controls.Add(btnResetPassword);
            Controls.Add(lblConfirmPasswordError);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmarContraseña);
            Controls.Add(lblNewPasswordError);
            Controls.Add(txtNewPasswod);
            Controls.Add(lblNuevaContraseña);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ForgotPasswordStep3Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Contraseña";
            Load += ForgotPasswordStep3Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNuevaContraseña;
        private TextBox txtNewPasswod;
        private Label lblNewPasswordError;
        private Label lblConfirmarContraseña;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPasswordError;
        private Button btnResetPassword;
        private Label LblSuccessMessage;
    }
}