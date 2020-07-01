using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmClasificacionRead : Form
    {
        public FrmClasificacionRead()
        {
            InitializeComponent();
        }

        private void CargarLista()
        {
            try
            {
                dgvClasificacion.DataSource = AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion();
                dgvClasificacion.Columns[0].Visible = false;
                dgvClasificacion.Columns[2].Visible = false;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void FrmClasificacionRead_Load(object sender, EventArgs e)
        {

            CargarLista();
        }

        private void BtEliminar_Click_1(object sender, EventArgs e)
        {
            int clasificacionId = -1;
            try
            {
                clasificacionId = (int)dgvClasificacion.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione clasificación!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (clasificacionId < 0)
            {
                ;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Clasificacion.GetClasificacion().BorrarClasificacion(clasificacionId);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message + ", tiene datos asociados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                tbFiltrar.Text = "";
                CargarLista();
            }
        }

        private void TbFiltrar_TextChanged_1(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                try
                {
                    dgvClasificacion.DataSource = AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion().Where(x => x.Descripcion.Contains(tbFiltrar.Text.ToLower()));
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
            else
            {
                CargarLista();
            }
        }

        private void BtAñadir_Click_1(object sender, EventArgs e)
        {
            FrmClasificacionCreate frmCreate = new FrmClasificacionCreate();
            frmCreate.ShowDialog();
            CargarLista();
        }

        private void BtEditar_Click_1(object sender, EventArgs e)
        {
            int clasificacionId = -1;
            try
            {
                clasificacionId = (int)dgvClasificacion.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione clasificación!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (clasificacionId < 0)
            {
                ;
            }
            else
            {
                FrmClasificacionUpdate frmUpdate = new FrmClasificacionUpdate(clasificacionId);
                frmUpdate.ShowDialog();
                tbFiltrar.Text = "";
                CargarLista();
            }
        }
    }
}
