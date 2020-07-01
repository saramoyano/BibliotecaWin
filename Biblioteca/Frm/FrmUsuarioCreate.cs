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
    public partial class FrmUsuarioCreate : Form
    {

        public FrmUsuarioCreate()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatosObligatorios())
            {
                AccesoDatos.Model.Usuario usuario = new AccesoDatos.Model.Usuario();
                usuario.DNI = tbDni.Text;
                usuario.Nombre = tbNombre.Text;
                usuario.Apellidos = tbApellidos.Text;
                usuario.InicioSesion = cbInicioSesion.Checked;
                if (usuario.InicioSesion == true)
                {
                    string sal = "123456";
                    usuario.Salt = FrmUsuarioRead.CalcularSalt(usuario.DNI, sal);
                }
                usuario.Direccion = tbDireccion.Text;
                usuario.Poblacion = tbPoblacion.Text;
                usuario.CodigoPostal = tbCodPostal.Text;
                usuario.Provincia = tbProvincia.Text;
                usuario.Telefono1 = tbTelefono1.Text;
                usuario.Telefono2 = tbTelefono1.Text;
                try
                {
                    AccesoDatos.Logic.Usuario.GetUsuario().InsertarUsuario(usuario);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private bool FaltanDatosObligatorios()
        {
            if(tbDni.Equals("") || tbNombre.Text.Equals("") || tbApellidos.Text.Equals("") || tbDireccion.Text.Equals("") ||
                            tbPoblacion.Text.Equals("") || tbCodPostal.Text.Equals("") || tbProvincia.Text.Equals("") || tbTelefono1.Text.Equals(""))
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
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
