/* 
 * Biblioteca versión 1.15
 * Autores:
 * José Espin
 * Sara Moyano
 * Fecha de creación: 07/10/2019 
 * Fecha de ultima revisión: 10/10/2019
 * 
*/


using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmLibroUpdate : Form
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

        private int idLibro;
        public FrmLibroUpdate(int idLibro)
        {
            InitializeComponent();
            AccesoDatos.Model.Libro libro = AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.LibroId == idLibro).FirstOrDefault();
            this.idLibro = idLibro;
            tbTitulo.Text = libro.Titulo;
            nStock.Text = libro.Stock.ToString();
            cbAutor.DataSource = ListaCBAutores(AccesoDatos.Logic.Autor.GetAutor().ListarAutores());
            cbAutor.DisplayMember = "Nombre";
            cbAutor.ValueMember = "id";
            cbAutor.SelectedValue = libro.AutorAutorId;
            cbEditorial.DataSource = ListaCBEditoriales(AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial());
            cbEditorial.DisplayMember = "RazonSocial";
            cbEditorial.ValueMember = "id";
            cbEditorial.SelectedValue = libro.EditorialEditorialId;
            cbClasificacion.DataSource = AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion();
            cbClasificacion.DisplayMember = "Descripcion";
            cbClasificacion.ValueMember = "ClasificacionId";
            cbClasificacion.SelectedValue = libro.ClasificacionClasificacionId;
            cbGenero.DataSource = AccesoDatos.Logic.Genero.GetGenero().ListarGenero();
            cbGenero.DisplayMember = "Descripcion";
            cbGenero.ValueMember = "GeneroId";
            cbGenero.SelectedValue = libro.GeneroGeneroId;
            rtbDescripcion.Text = libro.Descripcion;

            if (libro.Imagen != null)
            {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(libro.Imagen, 0, Convert.ToInt32(libro.Imagen.Length));
                pbImagen.Image = new Bitmap(mStream, false);
                mStream.Dispose();
            }

        }

        private void BtImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
                pbImagen.Tag = openFileDialog1.FileName;
                //MessageBox.Show(pbImagen.Tag.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Boolean FaltanDatosObligatorios()
        {
            if (tbTitulo.Text == "" || cbAutor.Text == "" || cbEditorial.Text == "" ||
                cbClasificacion.Text == "" || cbGenero.Text == "" || int.Parse(nStock.Text) == 0 || pbImagen.Image == null)
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

            AccesoDatos.Model.Libro libro = new AccesoDatos.Model.Libro();

            if (!FaltanDatosObligatorios())
            {
                libro.LibroId = idLibro;
                libro.Titulo = tbTitulo.Text;
                libro.Stock = int.Parse(nStock.Text);
                libro.StockDisponible = int.Parse(nStock.Text);
                libro.AutorAutorId = ((CBAutores)cbAutor.SelectedItem).id;
                libro.ClasificacionClasificacionId = ((AccesoDatos.Model.Clasificacion)cbClasificacion.SelectedItem).ClasificacionId; ;
                libro.GeneroGeneroId = ((AccesoDatos.Model.Genero)cbGenero.SelectedItem).GeneroId; ;
                libro.EditorialEditorialId = ((CBEditorial)cbEditorial.SelectedItem).id;
                libro.Descripcion = rtbDescripcion.Text;

                try
                {
                    if (pbImagen.Tag == null)
                    {
                        ImageConverter converter = new ImageConverter();
                        libro.Imagen = (byte[])converter.ConvertTo(pbImagen.Image, typeof(byte[]));
                    }
                    else
                    {
                        libro.Imagen = File.ReadAllBytes(pbImagen.Tag.ToString());
                    }
                    AccesoDatos.Logic.Libro.GetLibro().ActualizarLibro(libro);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
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
