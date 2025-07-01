namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    partial class MainMenuAdminForm
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
            btnRegistrarUsuario = new Button();
            btnIrPerfil = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(55, 52);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(291, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido Administrador";
            lblBienvenida.Click += label1_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(55, 109);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(291, 45);
            btnRegistrarUsuario.TabIndex = 1;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnIrPerfil
            // 
            btnIrPerfil.Location = new Point(55, 160);
            btnIrPerfil.Name = "btnIrPerfil";
            btnIrPerfil.Size = new Size(296, 45);
            btnIrPerfil.TabIndex = 2;
            btnIrPerfil.Text = "Ir al Perfil";
            btnIrPerfil.UseVisualStyleBackColor = true;
            btnIrPerfil.Click += btnIrPerfil_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(55, 211);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(296, 45);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += this.btnCerrarSesion_Click;
            // 
            // MainMenuAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnIrPerfil);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(lblBienvenida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenuAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu del admin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Button btnRegistrarUsuario;
        private Button btnIrPerfil;
        private Button btnCerrarSesion;
    }
}