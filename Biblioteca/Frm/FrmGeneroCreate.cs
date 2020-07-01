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
    public partial class FrmGeneroCreate : Form
    {
        public FrmGeneroCreate()
        {
            InitializeComponent();
        }


        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!tbDescripcion.Text.Equals(""))
            {
                AccesoDatos.Model.Genero genero = new AccesoDatos.Model.Genero();
                genero.Descripcion = tbDescripcion.Text;

                try
                {
                    AccesoDatos.Logic.Genero.GetGenero().InsertarGenero(genero);
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

        private void BtCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
