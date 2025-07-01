using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    public partial class AdminModifyUserForm : Form
    {
        private string _currentUserId;
        public AdminModifyUserForm(string userId, string FullName, string Email, string UserName, string Role, Form menu, Form login)
        {
            InitializeComponent();
            _currentUserId = userId;
            txtUserId.Text = userId;
            txtUserName.Text = FullName;
            txtEmail.Text = Email;
            txtUserName.Text = UserName;
            cmRole.Items.Add("administrador");
            cmRole.Items.Add("usuario");
            cmRole.Items.Add("soporte");
            cmRole.SelectedItem = Role;

            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUserNameError.Visible = false;
            lblRoleError.Visible = false;
            lblSuccesMessage.Visible = false;


        }
        private void lblIdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFullNameError_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRoleError_Click(object sender, EventArgs e)
        {

        }

        private void lblUserNameError_Click(Object sender, EventArgs e)
        {

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {

            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUserNameError.Visible = false;
            lblRoleError.Visible = false;
            lblSuccesMessage.Visible = false;

            bool isValid = true;

            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                lblFullNameError.Text = "El nombre completo es obligatorio";
                lblFullNameError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) || !IsValidEmail(txtEmail.Text.Trim()))
            {
                lblEmailError.Text = "Ingresar un correo electronico valido ";
                lblEmailError.Visible = true;
                isValid = false;
            }
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()) || txtUserName.Text.Trim().Length < 3)
            {
                lblUserNameError.Text = "El nombre de usuario es obligatorio y debe tener al menos 3 caracteres";
                lblUserNameError.Visible = true;
                isValid = false;

            }
            if(cmRole.SelectedItem == null)
            {
                lblRoleError.Text = "Selecciona un rol para usuario";
                lblRoleError.Visible = true;
                isValid = false;

            }
            if(isValid)
            {
                MessageBox.Show($"Usuario ID {_currentUserId} actualizado exitosamente.",
                            "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSuccesMessage.Text = "usuario actualizado exitosamente";
                lblSuccesMessage.Visible = true;
            }


        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha iniciado el proceso de restablecimiento de contraseña para el usuario ID {_currentUserId}. (En un sistema real, se enviaría un enlace/código al correo del usuario para que él la cambie).",
                        "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void lblSuccesMessage_Click(object sender, EventArgs e)
        {

        }

        private void AdminmodifyUserForm_Load(object sender, EventArgs e)
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

    }
}
