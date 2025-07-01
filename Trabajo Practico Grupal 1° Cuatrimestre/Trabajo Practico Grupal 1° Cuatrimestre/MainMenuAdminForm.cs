using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    public partial class MainMenuAdminForm : Form
    {
        private string nombreAdmin;
        private Form loginForm;

        public MainMenuAdminForm(string usuario, Form login)
        {
            InitializeComponent();
            nombreAdmin = usuario;
            loginForm = login;
            this.Load += new EventHandler(Form1_Load);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido Administrador, {nombreAdmin}";
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro de usuarios
            AdiminRegisterUserForm registroForm = new AdiminRegisterUserForm();
            registroForm.ShowDialog(); // Modo modal
        }

        private void btnIrPerfil_Click(object sender, EventArgs e)
        {
            // Abrir el perfil del administrador
            UserprofileForm perfilForm = new UserprofileForm(
                userId: "0",
                fullName: "Administrador",
                email: "admin@gmail.com",
                userName: "admin",
                role: "Administrador",
                usuario: nombreAdmin,
                menu: this
            );
            perfilForm.Show();
            this.Hide(); // Oculta el menú mientras el perfil está abierto
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            loginForm.Show(); // Muestra el login
            this.Close();     // Cierra el menú

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
