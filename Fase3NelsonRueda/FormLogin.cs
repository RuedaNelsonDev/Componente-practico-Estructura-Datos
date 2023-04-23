namespace Fase3NelsonRueda
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string contrasena = txtLoginContrasena.Text;

            if (contrasena == "123")
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intente nuevamente.");
            }

        }
    }
}