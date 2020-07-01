using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmAutorUpdate : Form
    {
        private int id;
        public FrmAutorUpdate(int autorId)
        {
            InitializeComponent();
            id = autorId;
            try
            {
                AccesoDatos.Model.Autor autor = AccesoDatos.Logic.Autor.GetAutor().ListarAutores().Where(x => x.AutorId == id).FirstOrDefault();
                tbNombre.Text = autor.Nombre;
                tbApellidos.Text = autor.Apellidos;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            AccesoDatos.Model.Autor autor = new AccesoDatos.Model.Autor();
            autor.AutorId = id;
            autor.Nombre = tbNombre.Text;
            autor.Apellidos = tbApellidos.Text;

            try
            {
                AccesoDatos.Logic.Autor.GetAutor().ActualizarAutor(autor);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
