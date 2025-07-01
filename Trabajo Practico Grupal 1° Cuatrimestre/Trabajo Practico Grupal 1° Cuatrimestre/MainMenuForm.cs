using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    public partial class MainMenuForm : Form
    {
        private string nombreUsuario;
        private Form loginForm;
        public MainMenuForm(string usuario, Form login)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            loginForm = login;

        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido, {nombreUsuario}";
        }
        private void btnIrPerfil_Click(object sender, EventArgs e)
        {
            
            UserprofileForm perfilForm = new UserprofileForm(
              userId: "1",
               fullName: "Fernando Almaraz",
                email: "fermauroalma@gmail.com",
                userName: "fer123!",
                role: "Usuario",
               usuario: nombreUsuario,
                  menu: this);
              perfilForm.Show();
               this.Hide();

        }
        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                loginForm.Show();  // Mostrar el formulario de login
                this.Hide();      // Cerrar el menú principal actual
            }
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            // Confirmación opcional
            DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                loginForm.Show();  // Mostrar el formulario de login
                this.Close();      // Cerrar el menú principal actual
            }
        }
    }
}
