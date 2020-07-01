using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmLibroCreate : Form
    {

        public struct CBAutores
        {
            public int id { get; set; }
            public string Nombre { get; set; }
        };
        public struct CBEditorial
        {
            public int id { get; set; }
            public string RazonSocial { get; set; }
        };
        public struct CBClasificacion
        {
            public int id { get; set; }
            public string Descripcion { get; set; }
        }; public struct CBGenero
        {
            public int id { get; set; }
            public string Descripcion { get; set; }
        };

        public FrmLibroCreate()
        {
            InitializeComponent();
        }

        private void FrmLibroCreate_Load(object sender, EventArgs e)
        {
            cbAutor.DataSource = ListaCBAutores(AccesoDatos.Logic.Autor.GetAutor().ListarAutores());
            cbEditorial.DataSource = ListaCBEditoriales(AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial());
            cbClasificacion.DataSource = ListaCBClasificaciones(AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion());
            cbGenero.DataSource = ListaCBGeneros(AccesoDatos.Logic.Genero.GetGenero().ListarGenero());
            cbAutor.DisplayMember = "Nombre";
            cbEditorial.DisplayMember = "RazonSocial";
            cbClasificacion.DisplayMember = "Descripcion";
            cbGenero.DisplayMember = "Descripcion";

        }

        private static List<CBAutores> ListaCBAutores(List<AccesoDatos.Model.Autor> autor)
        {
            return autor.Select(x => new CBAutores
            {
                id = x.AutorId,
                Nombre = x.Apellidos + ", " + x.Nombre,
            }).ToList();
        }
        private static List<CBEditorial> ListaCBEditoriales(List<AccesoDatos.Model.Editorial> editorial)
        {
            return editorial.Select(x => new CBEditorial
            {
                id = x.EditorialId,
                RazonSocial = x.RazonSocial,
            }).ToList();
        }
        private static List<CBClasificacion> ListaCBClasificaciones(List<AccesoDatos.Model.Clasificacion> clasificacion)
        {
            return clasificacion.Select(x => new CBClasificacion
            {
                id = x.ClasificacionId,
                Descripcion = x.Descripcion,
            }).ToList();
        }
        private static List<CBGenero> ListaCBGeneros(List<AccesoDatos.Model.Genero> genero)
        {
            return genero.Select(x => new CBGenero
            {
                id = x.GeneroId,
                Descripcion = x.Descripcion,
            }).ToList();
        }

        private void BtImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
                pbImagen.Tag = openFileDialog1.FileName;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean FaltanDatosObligatorios()
        {
            if (tbTitulo.Text == "" || cbAutor.Text == "" || cbEditorial.Text == "" || rtbDescripcion.Text == "" ||
                cbClasificacion.Text == "" || cbGenero.Text == "" || int.Parse(nStock.Text) == 0 || pbImagen.Tag == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatosObligatorios())
            {
                cbAutor.DisplayMember = "id";
                cbEditorial.DisplayMember = "id";
                cbClasificacion.DisplayMember = "id";
                cbGenero.DisplayMember = "id";
                AccesoDatos.Model.Libro nuevo = new AccesoDatos.Model.Libro()
                {
                    Titulo = tbTitulo.Text,
                    Stock = int.Parse(nStock.Text),
                    StockDisponible = int.Parse(nStock.Text),
                    AutorAutorId = int.Parse(cbAutor.Text),
                    EditorialEditorialId = int.Parse(cbEditorial.Text),
                    ClasificacionClasificacionId = int.Parse(cbClasificacion.Text),
                    GeneroGeneroId = int.Parse(cbGenero.Text),
                    Descripcion = rtbDescripcion.Text
                };

                if (pbImagen.Tag != null)
                {
                    nuevo.Imagen = File.ReadAllBytes(pbImagen.Tag.ToString());
                }
                try
                {
                    AccesoDatos.Logic.Libro.GetLibro().InsertarLibro(nuevo);
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

        private void BtAñadirAutor_Click(object sender, EventArgs e)
        {
            FrmAutorCreate frmAutorCreate = new FrmAutorCreate();
            if (DialogResult.OK == frmAutorCreate.ShowDialog())
            {
                cbAutor.DataSource = ListaCBAutores(AccesoDatos.Logic.Autor.GetAutor().ListarAutores());
            }
        }

        private void BtAñadirEditorial_Click(object sender, EventArgs e)
        {
            FrmEditorialCreate frmEditorialCreate = new FrmEditorialCreate();
            if (DialogResult.OK == frmEditorialCreate.ShowDialog())
            {
                cbEditorial.DataSource = ListaCBEditoriales(AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial());
            }
        }
    }
}
