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
    public partial class UserprofileForm : Form
    {
        private string _loggedInUserId;
        private string nombreUsuario;
        private Form menuForm;
        private Form loginForm;
        public UserprofileForm(string userId, string fullName, string email, string userName, string role, string usuario, Form menu)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            txtFullName.Text = fullName;
            txtEmail.Text = email;
            txtUserName.Text = userName;
            txtRole.Text = role;

            nombreUsuario = usuario;
            menuForm = menu;
            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUsernameError.Visible = false;
            lblSuccessMessage.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFullNameError_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblUsernameError_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePersonalData_Click(object sender, EventArgs e)
        {
            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUsernameError.Visible = false;
            lblSuccessMessage.Visible = false;

            bool isValid = true;

            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                lblFullNameError.Text = "El nombre completo es obligatorio";
                lblFullNameError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) || !IsValidEmail(txtEmail.Text.Trim()))
            {
                lblEmailError.Text = "Ingresar un correo electronico valido";
                lblEmailError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || txtUserName.Text.Trim().Length < 3)
            {
                lblUsernameError.Text = "El nombre de usuario es obligatorio y debe tener al menos 3 caracteres";
                lblFullNameError.Visible = true;
                isValid = false;
            }
            if (isValid)
            {
                MessageBox.Show("Tu datos han sido actualizados exitosamente", "actualixacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSuccessMessage.Text = "Tu datos han sido actualizados exitosamente";
                lblSuccessMessage.Visible = true;
                //return;
                //Application.Exit();
                menuForm.Show();
                this.Close();
            }
        }


        private void lblSuccessMessage_Click(object sender, EventArgs e)
        {

        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void UserprofileForm_Load(object sender, EventArgs e)
        {

        }

    }   
}
