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
    public partial class ForgotPasswordStep2Form : Form
    {
        private string _userEmail;
        public ForgotPasswordStep2Form(string userEmail)
        {
            InitializeComponent();
            _userEmail = userEmail;
            lbCodeError.Visible = false;
            txtSecurityCode.MaxLength = 6;
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            lbCodeError.Visible = false;
            string enteredCode = txtSecurityCode.Text.Trim();
            string correctCode = "123456";

            bool isValid = true;

            if (string.IsNullOrEmpty(enteredCode))
            {
                lbCodeError.Text = "El codigo de seguridad es obligatorio";
                lbCodeError.Visible = true;
                isValid = false;
            }
            else if (enteredCode != correctCode)
            {
                lbCodeError.Text = "El codigo de seguridad ingresado es incorrecto";
                lbCodeError.Visible = true;
                isValid = false;
            }
            if (isValid)
            {
                MessageBox.Show("Codigo verificado. Ahora puedes establecer tu nueva contraseña");
                ForgotPasswordStep3Form step3 = new ForgotPasswordStep3Form(_userEmail);
                this.Hide();
                step3.ShowDialog();
                this.Close();
            }

        }

        private void lbCodeError_Click(object sender, EventArgs e)
        {

        }

        private void txtSecurityCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoSeguridad_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordStep2Form_Load(object sender, EventArgs e)
        {

        }
    }
}
