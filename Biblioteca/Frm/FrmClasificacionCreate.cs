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
    public partial class FrmClasificacionCreate : Form
    {
        public FrmClasificacionCreate()
        {
            InitializeComponent();
        }


        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!tbDescripcion.Text.Equals(""))
            {
                AccesoDatos.Model.Clasificacion clasificacion = new AccesoDatos.Model.Clasificacion();
                clasificacion.Descripcion = tbDescripcion.Text;
                try
                {
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(clasificacion);
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

        private void BtCancelar_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
