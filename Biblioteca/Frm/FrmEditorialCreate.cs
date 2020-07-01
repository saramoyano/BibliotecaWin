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
    public partial class FrmEditorialCreate : Form
    {
        public FrmEditorialCreate()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatosObligatorios())
            {
                AccesoDatos.Model.Editorial nuevo = new AccesoDatos.Model.Editorial()
                {
                    RazonSocial = tbRazonSocial.Text,
                    Direccion = tbDireccion.Text,
                    Poblacion = tbPoblacion.Text,
                    CodigoPostal = tbCodigoPostal.Text,
                    Provincia = tbProvincia.Text,
                    Telefono1 = tbTelefono1.Text,
                    Telefono2 = tbTelefono2.Text,
                    PersonaContacto = tbContacto.Text,
                    Observaciones = rtbObservaciones.Text
                };
                try
                {
                    AccesoDatos.Logic.Editorial.GetEditorial().InsertarEditorial(nuevo);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean FaltanDatosObligatorios()
        {
            if (tbRazonSocial.Text.Equals("") || tbDireccion.Text.Equals("") || tbPoblacion.Text.Equals("") || tbCodigoPostal.Text.Equals("") ||
                            tbProvincia.Text.Equals("") || tbTelefono1.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
