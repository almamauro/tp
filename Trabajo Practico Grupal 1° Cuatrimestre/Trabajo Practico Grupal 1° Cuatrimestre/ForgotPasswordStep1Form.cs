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
    public partial class ForgotPasswordStep1Form : Form
    {
        public ForgotPasswordStep1Form()
        {
            InitializeComponent();
            lblEmailError.Visible = false;
            lblSuccessMessage.Visible = false;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            lblEmailError.Visible = false;
            lblSuccessMessage.Visible = false;

            string email = txtEmail.Text.Trim();
            bool isValid = true;

            if (string.IsNullOrEmpty(email))
            {
                lblEmailError.Text = "El correo electrónico es obligatorio.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else if (!IsValidEmail(email))
            {
                lblEmailError.Text = "Por favor, ingresa un formato de correo electrónico válido.";
                lblEmailError.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                // --- Simulación de envío de código ---
                // En una aplicación real, aquí se llamaría a un servicio backend
                // que verificaría el correo y, si existe, generaría un código único
                // y lo enviaría por correo electrónico.
                // No revelamos si el correo existe por seguridad.

                MessageBox.Show("Si el correo electrónico está registrado, se ha enviado un código de seguridad. Revisa tu bandeja de entrada o usa '123456' para simulación.",
                                "Código Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre la siguiente etapa (Verificar Código)
                ForgotPasswordStep2Form step2 = new ForgotPasswordStep2Form(email); // Pasamos el email para la siguiente etapa
                this.Hide(); // Oculta este formulario
                step2.ShowDialog();
                this.Close(); // Cierra este formulario después de que la segunda etapa se completa
            }

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

        private void lblEmailError_Click(object sender, EventArgs e)
        {

        }

        private void lblSuccessMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIngresodeCorreo_Click(object sender, EventArgs e)
        {

        }

        private void forgotPasswordStep1Form_Load(object sender, EventArgs e)
        {

        }
    }
}