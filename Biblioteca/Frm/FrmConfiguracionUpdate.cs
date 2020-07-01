using System;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmConfiguracionUpdate : Form
    {
        private AccesoDatos.Model.Configuracion config;

        public FrmConfiguracionUpdate()
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

        private void FrmConfiguracionUpdate_Load(object sender, EventArgs e)
        {
            nudNumDiasPrestamo1.Value = (decimal)config.NumDiasPrestamo1;
            nudNumDiasPrestamo2.Value = (decimal)config.NumDiasPrestamo2;
            nudMaxPrestamoUsuario.Value = (decimal)config.MaxPrestamoUsuario;
        }


        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            config.NumDiasPrestamo1 = (int)nudNumDiasPrestamo1.Value;
            config.NumDiasPrestamo2 = (int)nudNumDiasPrestamo2.Value;
            config.MaxPrestamoUsuario = (int)nudMaxPrestamoUsuario.Value;
            if (config.NumDiasPrestamo1 > 0 && config.NumDiasPrestamo2 > 0 && config.MaxPrestamoUsuario > 0)
            {
                try
                {
                    AccesoDatos.Logic.Configuracion.GetConfiguracion().ActualizarConfiguracion(config);
                    MessageBox.Show("Datos actualizados!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
