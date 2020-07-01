using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmUsuarioUpdate : Form
    {
        private string uDNI;
        public FrmUsuarioUpdate(string dni)
        {
            InitializeComponent();
            uDNI = dni;
            tbDni.Enabled = false;
            try
            {
                AccesoDatos.Model.Usuario usuario = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.DNI.Equals(uDNI)).FirstOrDefault();
                tbDni.Text = usuario.DNI;
                tbNombre.Text = usuario.Nombre;
                tbApellidos.Text = usuario.Apellidos;
                tbDireccion.Text = usuario.Direccion;
                cbInicioSesion.Checked = usuario.InicioSesion.GetValueOrDefault();
                tbPoblacion.Text = usuario.Poblacion;
                tbCodPostal.Text = usuario.CodigoPostal;
                tbProvincia.Text = usuario.Provincia;
                tbTelefono1.Text = usuario.Telefono1;
                tbTelefono1.Text = usuario.Telefono2;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void BtAceptar_Click_1(object sender, EventArgs e)
        {
            if (!FaltanDatosObligatorios())
            {
                AccesoDatos.Model.Usuario usuario = new AccesoDatos.Model.Usuario();
                usuario.DNI = uDNI;
                usuario.Nombre = tbNombre.Text;
                usuario.Apellidos = tbApellidos.Text;
                usuario.InicioSesion = cbInicioSesion.Checked;
                if (usuario.InicioSesion == true)
                {
                    string sal = "123456";
                    usuario.Salt = FrmUsuarioRead.CalcularSalt(usuario.DNI, sal);
                    MessageBox.Show("Se ha establecido la contraseña por defecto '" + sal + "'.\n" +
                        "Debe cambiarla con la opción de menu 'Cambiar Contraseña'.", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                usuario.Direccion = tbDireccion.Text;
                usuario.Poblacion = tbPoblacion.Text;
                usuario.CodigoPostal = tbCodPostal.Text;
                usuario.Provincia = tbProvincia.Text;
                usuario.Telefono1 = tbTelefono1.Text;
                usuario.Telefono2 = tbTelefono1.Text;

                try
                {
                    AccesoDatos.Logic.Usuario.GetUsuario().ActualizarUsuario(usuario);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool FaltanDatosObligatorios()
        {
            if (tbDni.Equals("") || tbNombre.Text.Equals("") || tbApellidos.Text.Equals("") || tbDireccion.Text.Equals("") ||
                            tbPoblacion.Text.Equals("") || tbCodPostal.Text.Equals("") || tbProvincia.Text.Equals("") || tbTelefono1.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbInicioSesion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInicioSesion.Checked == true)
            {
                lbInicioSesion.Text = "Activado Inicio de Sesión";
            }
            else
            {
                lbInicioSesion.Text = "Desactivado Inicio de Sesión";
            }
        }
    }
}

