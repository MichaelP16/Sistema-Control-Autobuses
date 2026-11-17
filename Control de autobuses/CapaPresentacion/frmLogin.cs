using Control_de_autobuses.Formularios;

namespace Control_de_autobuses
{
    public partial class frmLogin : Form
    {
        private CapaNegocio objNegocio = new CapaNegocio();
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsuario.Text.Trim();
                string pass = txtPassword.Text.Trim();
                CapaEntidades.Usuario usuarioLogueado = objNegocio.ValidarLogin(user, pass);

                if (usuarioLogueado != null)
                {
                    CapaNegocio.SesionActual.UsuarioLogueado = usuarioLogueado;

                    // Usamos Equals con IgnoreCase para evitar fallos por mayúsculas/minúsculas
                    if (usuarioLogueado.Rol.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase))
                    {
                        frmRegistroAsignaciones frmAsig = new frmRegistroAsignaciones();
                        frmAsig.Show();
                        this.Hide();
                    }
                    else if (usuarioLogueado.Rol.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                            usuarioLogueado.Rol.Trim().Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                    {
                        frmDasboard dashboard = new frmDasboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El rol '" + usuarioLogueado.Rol + "' no tiene un formulario asignado.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
