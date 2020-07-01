using System;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmAutorCreate : Form
    {
        private string nombres = "";
        private string apellidos = "";


        public FrmAutorCreate()
        {
            InitializeComponent();
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!tbNombre.Text.Equals("") || !tbApellidos.Text.Equals(""))
            {
                AccesoDatos.Model.Autor autor = new AccesoDatos.Model.Autor();
                autor.Nombre = tbNombre.Text;
                autor.Apellidos = tbApellidos.Text;
                try
                {
                    AccesoDatos.Logic.Autor.GetAutor().InsertarAutor(autor);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos Obligatorios!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAutorCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
