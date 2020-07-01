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
    public partial class FrmClasificacionUpdate : Form
    {
        private int id;
        public FrmClasificacionUpdate(int clasificacionId)
        {
            InitializeComponent();
            id = clasificacionId;
            try
            {
                AccesoDatos.Model.Clasificacion clasificacion = AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion().Where(x => x.ClasificacionId == clasificacionId).FirstOrDefault();
                tbDescripcion.Text = clasificacion.Descripcion;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!tbDescripcion.Text.Equals(""))
            {
                AccesoDatos.Model.Clasificacion clasificacion = new AccesoDatos.Model.Clasificacion();
                clasificacion.ClasificacionId = id;
                clasificacion.Descripcion = tbDescripcion.Text;

                try
                {
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().ActualizarClasificacion(clasificacion);
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
