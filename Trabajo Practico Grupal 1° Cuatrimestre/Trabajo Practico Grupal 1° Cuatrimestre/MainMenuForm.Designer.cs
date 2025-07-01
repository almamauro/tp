namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class MainMenuForm
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
            lblBienvenida = new Label();
            btnIrPerfil = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(122, 50);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(65, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "bienvenida";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // btnIrPerfil
            // 
            btnIrPerfil.Location = new Point(89, 109);
            btnIrPerfil.Name = "btnIrPerfil";
            btnIrPerfil.Size = new Size(138, 23);
            btnIrPerfil.TabIndex = 1;
            btnIrPerfil.Text = "Ir a mi perfil";
            btnIrPerfil.UseVisualStyleBackColor = true;
            btnIrPerfil.Click += btnIrPerfil_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(89, 181);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(138, 23);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click_1;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 263);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnIrPerfil);
            Controls.Add(lblBienvenida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inicio";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnIrPerfil;
        private Button btnCerrarSesion;
    }
}