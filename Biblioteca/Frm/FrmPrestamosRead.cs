using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmPrestamosRead : Form
    {
        private struct ListaPersonalizada
        {
            public int ID { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public Nullable<DateTime> FechaDevolucion { get; set; }
            public string Usuario { get; set; }
            public string Libro { get; set; }
        }
        private AccesoDatos.Model.Configuracion config;

        public FrmPrestamosRead()
        {
            InitializeComponent();
            try
            {
                config = AccesoDatos.Logic.Configuracion.GetConfiguracion().ListarConfiguracion().FirstOrDefault();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void FrmPrestamosRead_Load(object sender, EventArgs e)
        {
            cargarListaPrestamos();
        }

        private void tsbCrear_Click(object sender, EventArgs e)
        {
            FrmPrestamoCreate frmPrestamoCreate = new FrmPrestamoCreate();
            if (DialogResult.OK == frmPrestamoCreate.ShowDialog())
            {
                cargarListaPrestamos();
                ((FrmPpal)this.MdiParent).RefrescarTablas();

            }
            
        }

        private void tsbDevolver_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)dgvPrestamos.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFiltrar.Text = "";
            }

            if (id != 0)
            {

                DialogResult dialogResult = MessageBox.Show("¿Desea devolver el libro prestado?", "Devolver libro prestado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    DataGridViewRow row = dgvPrestamos.CurrentRow;
                    AccesoDatos.Model.Prestamo prestamo = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.PrestamoId == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                    prestamo.FechaDevolucion = DateTime.Today;
                    AccesoDatos.Logic.Prestamo.GetPrestamo().ActualizarPrestamo(prestamo);

                    AccesoDatos.Model.Libro libro = AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.LibroId == prestamo.LibroLibroId).FirstOrDefault();
                    libro.StockDisponible = libro.StockDisponible + 1;
                    AccesoDatos.Logic.Libro.GetLibro().ActualizarLibro(libro);

                    cargarListaPrestamos();
                    ((FrmPpal)this.MdiParent).RefrescarTablas();
                }
            }
        }

        private void tsbAmpliar_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)dgvPrestamos.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFiltrar.Text = "";
            }

            if (id != 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea ampliar la fecha de devolución?", "Ampliar fecha de devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvPrestamos.CurrentRow;
                    try
                    {
                        AccesoDatos.Model.Prestamo prestamo = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.PrestamoId == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                        if (prestamo.FechaFin.AddDays((double)config.NumDiasPrestamo2).DayOfWeek == DayOfWeek.Saturday)
                        {
                            prestamo.FechaFin = prestamo.FechaFin.AddDays((double)config.NumDiasPrestamo2 + 2);
                        }
                        else if (prestamo.FechaFin.AddDays((double)config.NumDiasPrestamo2).DayOfWeek == DayOfWeek.Sunday)
                        {
                            prestamo.FechaFin = prestamo.FechaFin.AddDays((double)config.NumDiasPrestamo2 + 1);
                        }
                        else
                        {
                            prestamo.FechaFin = prestamo.FechaFin.AddDays((double)config.NumDiasPrestamo2);
                        }
                        AccesoDatos.Logic.Prestamo.GetPrestamo().ActualizarPrestamo(prestamo);
                        cargarListaPrestamos();
                    }
                    catch (Exception excepcion)
                    {
                        MessageBox.Show(excepcion.Message);
                    }
                }
            }
        }

        private void tstbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                List<ListaPersonalizada> prestamosFiltrados = ListaCBPrestamos(AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.Usuario.Apellidos.ToLower().Contains(tbFiltrar.Text.ToLower())).Where(x => x.FechaDevolucion == null).OrderBy(x => x.FechaFin).ToList());
                dgvPrestamos.DataSource = prestamosFiltrados;
                //dgvPrestamos.DataSource = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion == null).OrderBy(x => x.FechaFin);
            }
            else
            {
                //dgvPrestamos.DataSource = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion == null).OrderBy(x => x.FechaFin);
                //dgvPrestamos.DataSource = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion == null).OrderBy(x => x.FechaFin).Where(x => (x.Usuario.Apellidos + ", " + x.Usuario.Nombre).Contains(tbFiltrar.Text));
                cargarListaPrestamos();
            }
        }

        private static List<ListaPersonalizada> ListaCBPrestamos(List<AccesoDatos.Model.Prestamo> prestamo)
        {
            return prestamo.Select(x => new ListaPersonalizada
            {
                ID = x.PrestamoId,
                FechaInicio = x.FechaInicio,
                FechaFin = x.FechaFin,
                FechaDevolucion = x.FechaDevolucion,
                Usuario = x.Usuario.Apellidos + ", " + x.Usuario.Nombre,
                Libro = x.Libro.Titulo,
            }).ToList();
        }

        private void cargarListaPrestamos()
        {
            List<ListaPersonalizada> lista = ListaCBPrestamos(AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion == null).OrderBy(x => x.FechaFin).ToList());
            dgvPrestamos.DataSource = lista;
            dgvPrestamos.Columns[0].Visible = false;
            dgvPrestamos.Columns[1].HeaderText = "Fecha de Inicio";
            dgvPrestamos.Columns[2].HeaderText = "Fecha de Fín";
            dgvPrestamos.Columns[3].HeaderText = "Fecha de Devolución";
            //dgvPrestamos.Columns["FechaDevolucion"].Visible = false;
            //dgvPrestamos.Columns["Usuario"].Visible = false;
            //dgvPrestamos.Columns["Libro"].Visible = false;
        }
    }
}
