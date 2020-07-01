using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmLibroRead : Form
    {
        public struct LibroView
        {
            public int idLibro { get; set; }
            public string Titulo { get; set; }
            public int StockDisponible { get; set; }
            public string Autor { get; set; }
            public string Genero { get; set; }
            public string Editorial { get; set; }
            public byte[] Imagen { get; set; }
            public string Descripcion { get; set; }

        };


        public FrmLibroRead()
        {
            InitializeComponent();
        }

        private void FrmLibroRead_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            FrmLibroCreate frmCreate = new FrmLibroCreate();
            frmCreate.ShowDialog();
            cargarLista();
        }


        private void TbFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                cargarListaFiltrada();
            }
            else
            {
                cargarLista();
            }
        }

        private static List<LibroView> ListaView(List<AccesoDatos.Model.Libro> lista)
        {
            return lista.Select(x => new LibroView
            {
                idLibro = x.LibroId,
                Titulo = x.Titulo,
                StockDisponible = x.StockDisponible.GetValueOrDefault(),
                //Autor = AccesoDatos.Logic.Autor.GetAutor().ListarAutores().Where(a => a.AutorId == x.AutorAutorId).FirstOrDefault().Apellidos + ", " +
                //                AccesoDatos.Logic.Autor.GetAutor().ListarAutores().Where(a => a.AutorId == x.AutorAutorId).FirstOrDefault().Nombre,
                Autor = x.Autor.Apellidos + ", " + x.Autor.Nombre,
                //Genero = AccesoDatos.Logic.Genero.GetGenero().ListarGenero().Where(g => g.GeneroId == x.GeneroGeneroId).FirstOrDefault().Descripcion,
                Genero = x.Genero.Descripcion,
                //Editorial = AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial().Where(e => e.EditorialId == x.EditorialEditorialId).FirstOrDefault().RazonSocial,
                Editorial = x.Editorial.RazonSocial,
                Imagen = x.Imagen,
                Descripcion = x.Descripcion
            }).ToList();
        }

        public void cargarLista()
        {

                List<LibroView> libros = ListaView(AccesoDatos.Logic.Libro.GetLibro().ListarLibro());
                dataGridView1.DataSource = libros;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.Columns[1].HeaderText = "Título";
                dataGridView1.Columns[2].HeaderText = "Stock Disponible";
                dataGridView1.Columns[7].HeaderText = "Descripción";

        }
        private void cargarListaFiltrada()
        {
            try
            {
                List<LibroView> librosFiltrados = ListaView(AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.Titulo.ToLower().Contains(tbFiltrar.Text.ToLower())).ToList());
                dataGridView1.DataSource = librosFiltrados;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            int libroId = -1;
            try
            {
                libroId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un libro!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (libroId > 0)
            {
                FrmLibroUpdate frmUpdate = new FrmLibroUpdate(libroId);
                frmUpdate.ShowDialog();
                cargarLista();
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            int libroId = -1;
            try
            {
                libroId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un libro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (libroId > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Libro.GetLibro().BorrarLibro(libroId);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message + ", tiene datos asociados.");
                    }
                }
                cargarLista();
            }
            //if (tbFiltrar.Text.Equals(""))
            //{
            //    cargarLista();
            //}
            //else
            //{
            //    cargarListaFiltrada();
            //}
        }
    }
}
