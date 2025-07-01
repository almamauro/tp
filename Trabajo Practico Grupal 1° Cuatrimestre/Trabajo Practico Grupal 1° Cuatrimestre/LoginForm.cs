namespace Trabajo_Practico_Grupal_1__Cuatrimestre
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblUsernameEmailError.Visible = false;
            lblPaswordError.Visible = false;

        }

        private void LblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtUsernameEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsernameEmailError_Click(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaswordError_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblUsernameEmailError.Visible=false;
            lblPaswordError.Visible=false;

            string UsernameEmail = txtUsernameEmail.Text.Trim();
            string Password=txtPassword.Text;
            bool isValid = true;

            if (string.IsNullOrEmpty(UsernameEmail))
            {
                lblUsernameEmailError.Text = "Este campo es obligatorio. ";
                lblUsernameEmailError.Visible = true;
                isValid = false;
            }
            else if (UsernameEmail.Contains("@") )  
            {
                lblUsernameEmailError.Text = "Por favor, ingresa un formato de correo electrónico válido.";
                lblUsernameEmailError.Visible = true;
                isValid = false;
            }
            else if (!UsernameEmail.Contains("@") && UsernameEmail.Length < 3)
            {
                lblUsernameEmailError.Text = "El nombre de usuario debe tener al menos tres caracteres. ";
                lblUsernameEmailError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                lblPaswordError.Text = "La contraseña es obligatoria. ";
                lblPaswordError.Visible = true;
                isValid = false;
            }
            else if (Password.Length < 8)
            {
                lblPaswordError.Text = "La contraseña debe tener al menos 8 caracteres. ";
                lblPaswordError.Visible = true;
                isValid = false;
            }
            if (UsernameEmail == "admin@gmail.com" &&  Password == "admin123!")
            {
                MessageBox.Show("Bienvenido, Administrador", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenuAdminForm adminMenu = new MainMenuAdminForm(UsernameEmail, this);
                adminMenu.Show();
                this.Hide();

            }
            else if(UsernameEmail == "fermauroalma@gmail.com" && Password == "fer123!")
            {
                MessageBox.Show("bienvenido, usuario", "acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information );
                MainMenuForm menuForm = new MainMenuForm(UsernameEmail, this); 
                menuForm.Show();
                this.Hide();
                


            }
            else { MessageBox.Show("credenciales incorrectas. por favor, intente de nuevo. ", "error de login", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lnkForgotPasword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordStep1Form forgotPasswordForm = new ForgotPasswordStep1Form();
             forgotPasswordForm.ShowDialog();
        }
        
    }
}
