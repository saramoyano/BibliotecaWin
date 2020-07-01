using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmGeneroUpdate : Form
    {
        private int id;
        public FrmGeneroUpdate(int generoId)
        {
            InitializeComponent();
            id = generoId;
            try
            {
                AccesoDatos.Model.Genero genero = AccesoDatos.Logic.Genero.GetGenero().ListarGenero().Where(x => x.GeneroId == generoId).FirstOrDefault();


                tbDescripcion.Text = genero.Descripcion;

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {

            if (!tbDescripcion.Text.Equals(""))
            {
                //no edita
                AccesoDatos.Model.Genero genero = new AccesoDatos.Model.Genero();
                genero.GeneroId = id;
                genero.Descripcion = tbDescripcion.Text;

                try
                {
                    AccesoDatos.Logic.Genero.GetGenero().ActualizarGenero(genero);
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
