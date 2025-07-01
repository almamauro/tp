namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class ForgotPasswordStep2Form
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
            lblCodigoSeguridad = new Label();
            txtSecurityCode = new TextBox();
            lbCodeError = new Label();
            btnVerifyCode = new Button();
            SuspendLayout();
            // 
            // lblCodigoSeguridad
            // 
            lblCodigoSeguridad.AutoSize = true;
            lblCodigoSeguridad.Location = new Point(54, 30);
            lblCodigoSeguridad.Name = "lblCodigoSeguridad";
            lblCodigoSeguridad.Size = new Size(406, 15);
            lblCodigoSeguridad.TabIndex = 0;
            lblCodigoSeguridad.Text = "Ingresa el Codigo de Seguridad que enmos enviado a tu correo electronico: ";
            lblCodigoSeguridad.Click += lblCodigoSeguridad_Click;
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.Location = new Point(105, 77);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.Size = new Size(287, 23);
            txtSecurityCode.TabIndex = 1;
            txtSecurityCode.TextAlign = HorizontalAlignment.Center;
            txtSecurityCode.TextChanged += txtSecurityCode_TextChanged;
            // 
            // lbCodeError
            // 
            lbCodeError.AutoSize = true;
            lbCodeError.Location = new Point(219, 131);
            lbCodeError.Name = "lbCodeError";
            lbCodeError.Size = new Size(43, 15);
            lbCodeError.TabIndex = 2;
            lbCodeError.Text = "ERROR";
            lbCodeError.Click += lbCodeError_Click;
            // 
            // btnVerifyCode
            // 
            btnVerifyCode.Location = new Point(136, 182);
            btnVerifyCode.Name = "btnVerifyCode";
            btnVerifyCode.Size = new Size(229, 23);
            btnVerifyCode.TabIndex = 3;
            btnVerifyCode.Text = "Verificar Codigo";
            btnVerifyCode.UseVisualStyleBackColor = true;
            btnVerifyCode.Click += btnVerifyCode_Click;
            // 
            // ForgotPasswordStep2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 264);
            Controls.Add(btnVerifyCode);
            Controls.Add(lbCodeError);
            Controls.Add(txtSecurityCode);
            Controls.Add(lblCodigoSeguridad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ForgotPasswordStep2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olvide mi Contraseña";
            Load += ForgotPasswordStep2Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoSeguridad;
        private TextBox txtSecurityCode;
        private Label lbCodeError;
        private Button btnVerifyCode;
    }
}