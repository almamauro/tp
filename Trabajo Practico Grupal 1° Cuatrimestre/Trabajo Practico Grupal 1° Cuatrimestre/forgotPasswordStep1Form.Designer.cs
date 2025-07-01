namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class ForgotPasswordStep1Form
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
            lblIngresodeCorreo = new Label();
            txtEmail = new TextBox();
            lblEmailError = new Label();
            btnSendCode = new Button();
            lblSuccessMessage = new Label();
            SuspendLayout();
            // 
            // lblIngresodeCorreo
            // 
            lblIngresodeCorreo.AutoSize = true;
            lblIngresodeCorreo.Location = new Point(40, 25);
            lblIngresodeCorreo.Name = "lblIngresodeCorreo";
            lblIngresodeCorreo.Size = new Size(268, 15);
            lblIngresodeCorreo.TabIndex = 0;
            lblIngresodeCorreo.Text = "Ingresa tu correo electronico asociado a la cuenta";
            lblIngresodeCorreo.Click += lblIngresodeCorreo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Location = new Point(146, 121);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(43, 15);
            lblEmailError.TabIndex = 2;
            lblEmailError.Text = "ERROR";
            lblEmailError.Click += lblEmailError_Click;
            // 
            // btnSendCode
            // 
            btnSendCode.Location = new Point(62, 150);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(215, 23);
            btnSendCode.TabIndex = 3;
            btnSendCode.Text = "Enviar Codigo de Seguridad";
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.ForeColor = Color.Lime;
            lblSuccessMessage.Location = new Point(151, 225);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(38, 15);
            lblSuccessMessage.TabIndex = 4;
            lblSuccessMessage.Text = "label1";
            lblSuccessMessage.Visible = false;
            lblSuccessMessage.Click += lblSuccessMessage_Click;
            // 
            // ForgotPasswordStep1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 293);
            Controls.Add(lblSuccessMessage);
            Controls.Add(btnSendCode);
            Controls.Add(lblEmailError);
            Controls.Add(txtEmail);
            Controls.Add(lblIngresodeCorreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ForgotPasswordStep1Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += forgotPasswordStep1Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresodeCorreo;
        private TextBox txtEmail;
        private Label lblEmailError;
        private Button btnSendCode;
        private Label lblSuccessMessage;
    }
}