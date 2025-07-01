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
    public partial class AdiminRegisterUserForm : Form
    {
        public AdiminRegisterUserForm()
        {
            InitializeComponent();
            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;
            lblConfirmPasswordError.Visible = false;
            lblRoleError.Visible = false;
            lblSuccessMessage.Visible = false;

            cmbRole.Items.Add("Administrador");
            cmbRole.Items.Add("usuario");
            cmbRole.Items.Add("soporte");
            cmbRole.SelectedIndex = 1;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AdiminRegisterUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            lblFullNameError.Visible = false;
            lblEmailError.Visible = false;
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;
            lblConfirmPasswordError.Visible = false;
            lblRoleError.Visible = false;
            lblSuccessMessage.Visible = false;

            bool isValid = true;

            if (string.IsNullOrEmpty(txtFullName.Text.Trim()))
            {
                lblFullNameError.Text = "El nombre completo es obligatorio";
                lblFullNameError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) || !IsvalidEmail(txtEmail.Text.Trim()))
            {
                lblEmailError.Text = "Ingrese un correo electronico valido";
                lblEmailError.Visible = true;
                isValid = false;

            }
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()) || txtUserName.Text.Trim().Length < 3)
            {
                lblUsernameError.Text = "El nombre de usuario es obligatorio y debe tener al menos 3 caracteres";
                lblUsernameError.Visible = true;
                isValid = false;

            }

            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$";

            if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Text = "La contraseña es obligatoria";
                lblPasswordError.Visible = true;
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(password, passwordPattern))
            {
                lblPasswordError.Text = "minimo 8 caracteres, mayuscula, minuscula, numero y caracter especial";
                lblPasswordError.Visible = true;
                isValid = false;

            }
            if (password != confirmPassword)
            {
                lblConfirmPasswordError.Text = "La contraseñas no coinciden";
                lblConfirmPasswordError.Visible = true;
                isValid = false;
            }
            if (cmbRole.SelectedItem == null)
            {
                lblRoleError.Text = "Selecciona un rol para el usuario";
                lblRoleError.Visible = true;
                isValid = false;
            }
            if (isValid)
            {
                MessageBox.Show($"Usuario '{txtUserName.Text}' con rol '{cmbRole.SelectedItem.ToString()}' registrado exitosamente.",
                            "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private bool IsvalidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }

        }

        private void lblConfirmPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
