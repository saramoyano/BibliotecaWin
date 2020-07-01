using AccesoDatos.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmLogin : Form
    {

        public Usuario usuario;
        int error = 0;
        String dniUser;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {

            dniUser = tbUsuario.Text;
            String pass = tbContraseña.Text;
            String sal = FrmUsuarioRead.CalcularSalt(dniUser, pass);

            try
            {
                usuario = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.DNI.Equals(dniUser)).FirstOrDefault();
                if (usuario != null)
                {
                    if (usuario.InicioSesion == true)
                    {
                        if (usuario.Salt.Equals(sal))
                        {
                            //MessageBox.Show("Bienvenido");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            lbError.Text = "Contraseña incorrecta!";
                            error++;
                        }
                    }
                    else
                    {
                        //usuario sin inicio de sesion
                        //MessageBox.Show("Bienvenido");
                        //lbError.Text = "Usuario sin acceso!";
                    }
                }
                else
                {
                    lbError.Text = "Usuario incorrecto!";
                    error++;
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

            if (error == 3)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals(""))
            {
                lbError.Text = "";
            }
            try
            {
                dniUser = tbUsuario.Text;
                usuario = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.DNI.Equals(dniUser)).FirstOrDefault();
                if (usuario != null && usuario.InicioSesion == false)
                {
                    tbContraseña.Enabled = false;
                    lbError.Text = "Usuario sin acceso!";

                }
                else if (usuario != null && usuario.InicioSesion == true)
                {
                    tbContraseña.Enabled = true;
                    lbError.Text = "";
                }
            }
            catch (Exception excepcion)
            {
                tbUsuario.Text = "";
                tbContraseña.Text = "";
                MessageBox.Show(excepcion.Message);
            }
        }

        private void TbContraseña_TextChanged(object sender, EventArgs e)
        {
            if (tbContraseña.Text.Equals(""))
            {
                lbError.Text = "";
            }
        }
    }
}
