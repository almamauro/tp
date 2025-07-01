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
    public partial class ForgotPasswordStep3Form : Form
    {
        private string _userEmail;
        public ForgotPasswordStep3Form(string Email)
        {
            InitializeComponent();
            _userEmail = Email;
            lblNewPasswordError.Visible = false;
            lblConfirmPasswordError.Visible = false;
            LblSuccessMessage.Visible = false;


        }

        private void lblNuevaContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPasswod_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNewPasswordError_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmarContraseña_Click(Object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPasswordError_Click(Object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            lblNewPasswordError.Visible = false;
            lblConfirmPasswordError.Visible = false;
            LblSuccessMessage.Visible = false;

            string newPassword = txtNewPasswod.Text;
            string confirmPassword = txtConfirmPassword.Text;

            bool isValid = true;
            string passworPatern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{8,}$";

            if (string.IsNullOrEmpty(newPassword))
            {
                lblNewPasswordError.Text = "La nueva contraseña es obligatoria";
                lblNewPasswordError.Visible = true;
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(newPassword, passworPatern))
            {
                lblNewPasswordError.Text = "La contraseña debe tener almenos 8 caracteres, incluyendo una mayuscula, una minuscula, un numero y un caracter especial";
                lblNewPasswordError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(confirmPassword))
            {
                lblConfirmPasswordError.Text = " La confirmacion de contraseña es obligatoria.";
                lblConfirmPasswordError.Visible = true;
                isValid = false;
            }
            else if (newPassword != confirmPassword)
            {
                lblConfirmPasswordError.Text = "La contraseñas no coiciden";
                lblConfirmPasswordError.Visible = true;
                isValid = false;

            }
            if (isValid)
            {
                MessageBox.Show("Tu contraseña ha sido restablecida exitosamente. Ahora puedes iniciar sesión.",
                            "Contraseña Restablecida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void ForgotPasswordStep3Form_Load(object sender, EventArgs e)
        {

        }
    }
}
