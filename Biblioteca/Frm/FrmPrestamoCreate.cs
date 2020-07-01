using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmPrestamoCreate : Form
    {
        public struct CBUsuarios
        {
            public string dni { get; set; }
            public string Nombre { get; set; }
        };

        private AccesoDatos.Model.Configuracion config;

        public FrmPrestamoCreate()
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

        private void FrmPrestamoCreate_Load(object sender, EventArgs e)
        {
            try
            {
                cbUsuario.DataSource = ListaCBUsuarios(AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios());
                cbUsuario.DisplayMember = "Nombre";
                cbLibro.DataSource = AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.StockDisponible > 0).ToList();
                cbLibro.DisplayMember = "Titulo";

                tbFechaInicio.Text = DateTime.Today.ToShortDateString();
                if (DateTime.Today.AddDays((double)config.NumDiasPrestamo1).DayOfWeek == DayOfWeek.Saturday)
                {
                    tbFechaFin.Text = DateTime.Today.AddDays((double)config.NumDiasPrestamo1 + 2).ToShortDateString();
                }
                else if (DateTime.Today.AddDays((double)config.NumDiasPrestamo1).DayOfWeek == DayOfWeek.Sunday)
                {
                    tbFechaFin.Text = DateTime.Today.AddDays((double)config.NumDiasPrestamo1 + 1).ToShortDateString();
                }
                else
                {
                    tbFechaFin.Text = DateTime.Today.AddDays((double)config.NumDiasPrestamo1).ToShortDateString();
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

        }
        private static List<CBUsuarios> ListaCBUsuarios(List<AccesoDatos.Model.Usuario> usuario)
        {
            return usuario.Select(x => new CBUsuarios
            {
                dni = x.DNI,
                Nombre = x.Apellidos + ", " + x.Nombre,
            }).ToList();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            AccesoDatos.Model.Prestamo prestamo = new AccesoDatos.Model.Prestamo();
            int stockLibro = ((AccesoDatos.Model.Libro)cbLibro.SelectedItem).StockDisponible.Value;
            if (!cbUsuario.SelectedValue.Equals("") || !cbLibro.SelectedValue.Equals(""))
            {
                if (stockLibro > 0)
                {
                    try
                    {
                        int numPrestamo = AccesoDatos.Logic.Prestamo.GetPrestamo().ListarPrestamos().Where(x => (x.UsuarioDNI == ((CBUsuarios)cbUsuario.SelectedItem).dni) && x.FechaDevolucion == null).Count();
                        //if (config.MaxPrestamoUsuario == ((AccesoDatos.Model.Usuario)cbUsuario.SelectedItem).Prestamo.Count)
                        if (config.MaxPrestamoUsuario == numPrestamo)
                        {
                            MessageBox.Show("El usuario " + cbUsuario.Text + " ha llegado al límite de préstamos", "Error al crear el préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            prestamo.FechaInicio = DateTime.Parse(tbFechaInicio.Text);
                            prestamo.FechaFin = DateTime.Parse(tbFechaFin.Text);
                            prestamo.UsuarioDNI = ((CBUsuarios)cbUsuario.SelectedItem).dni;
                            prestamo.LibroLibroId = ((AccesoDatos.Model.Libro)cbLibro.SelectedItem).LibroId;
                            AccesoDatos.Logic.Prestamo.GetPrestamo().InsertarPrestamo(prestamo);

                            AccesoDatos.Model.Libro libro = AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.LibroId == prestamo.LibroLibroId).FirstOrDefault();
                            libro.StockDisponible = stockLibro - 1;
                            AccesoDatos.Logic.Libro.GetLibro().ActualizarLibro(libro);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception excepcion)
                    {
                        MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("No hay stock disponible!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAñadirUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioCreate frmUsuarioCreate = new FrmUsuarioCreate();
            if (DialogResult.OK == frmUsuarioCreate.ShowDialog())
            {
                cbUsuario.DataSource = ListaCBUsuarios(AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios());
            }
        }

        private void btAñadirLibro_Click(object sender, EventArgs e)
        {
            FrmLibroCreate frmLibroCreate = new FrmLibroCreate();
            if (DialogResult.OK == frmLibroCreate.ShowDialog())
            {
                cbLibro.DataSource = AccesoDatos.Logic.Libro.GetLibro().ListarLibro().Where(x => x.StockDisponible > 0).ToList();
            }
        }
    }
}
