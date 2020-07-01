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
    public partial class FrmEditorialUpdate : Form
    {
        private int id;
        public FrmEditorialUpdate(int id)
        {
            InitializeComponent();
            try
            {
                AccesoDatos.Model.Editorial editorial = AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial().Where(x => x.EditorialId == id).FirstOrDefault();
                this.id = id;
                tbRazonSocial.Text = editorial.RazonSocial;
                tbDireccion.Text = editorial.Direccion;
                tbPoblacion.Text = editorial.Poblacion;
                tbCodigoPostal.Text = editorial.CodigoPostal;
                tbProvincia.Text = editorial.Provincia;
                tbTelefono1.Text = editorial.Telefono1;
                tbTelefono2.Text = editorial.Telefono2;
                tbContacto.Text = editorial.PersonaContacto;
                rtbObservaciones.Text = editorial.Observaciones;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatosObligatorios())
            {
                AccesoDatos.Model.Editorial editorial = new AccesoDatos.Model.Editorial();
                editorial.EditorialId = id;
                editorial.RazonSocial = tbRazonSocial.Text;
                editorial.Direccion = tbDireccion.Text;
                editorial.Poblacion = tbPoblacion.Text;
                editorial.CodigoPostal = tbCodigoPostal.Text;
                editorial.Provincia = tbProvincia.Text;
                editorial.Telefono1 = tbTelefono1.Text;
                editorial.Telefono2 = tbTelefono2.Text;
                editorial.PersonaContacto = tbContacto.Text;
                editorial.Observaciones = rtbObservaciones.Text;
                try
                {
                    AccesoDatos.Logic.Editorial.GetEditorial().ActualizarEditorial(editorial);
                    this.Close();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
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
