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
    public partial class FrmPrestamoHistoricoRead : Form
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

        public FrmPrestamoHistoricoRead()
        {
            InitializeComponent();
        }

        private void FrmPrestamoHistoricoRead_Load(object sender, EventArgs e)
        {
            //dgvPrestamos.DataSource = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion != null).OrderByDescending(x => x.FechaDevolucion).ToList();
            //dgvPrestamos.Columns["Usuario"].Visible = false;
            //dgvPrestamos.Columns["Libro"].Visible = false;
            cargarListaPrestamos();
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

        public void cargarListaPrestamos()
        {
            List<ListaPersonalizada> lista = ListaCBPrestamos(AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => x.FechaDevolucion != null).OrderByDescending(x => x.LibroLibroId).ToList());
            dgvPrestamos.DataSource = lista;
            dgvPrestamos.Columns[0].Visible = false;
            dgvPrestamos.Columns[1].HeaderText = "Fecha de Inicio";
            dgvPrestamos.Columns[2].HeaderText = "Fecha de Fín";
            dgvPrestamos.Columns[3].HeaderText = "Fecha de Devolución";
        }
    }
}
