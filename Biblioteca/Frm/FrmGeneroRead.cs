using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmGeneroRead : Form
    {
        public FrmGeneroRead()
        {
            InitializeComponent();
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            FrmGeneroCreate frmCreate = new FrmGeneroCreate();
            frmCreate.ShowDialog();
            CargarLista();
        }


        private void CargarLista()
        {
            try
            {
                dgvGenero.DataSource = AccesoDatos.Logic.Genero.GetGenero().ListarGenero();
                dgvGenero.Columns[0].Visible = false;
                dgvGenero.Columns[2].Visible = false;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void FrmGeneroRead_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void BtEditar_Click_1(object sender, EventArgs e)
        {
            int generoId = -1;
            try
            {
                generoId = (int)dgvGenero.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione un género!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (generoId > 0)
            {
                FrmGeneroUpdate frmUpdate = new FrmGeneroUpdate(generoId);
                frmUpdate.ShowDialog();
                tbFiltrar.Text = "";
                CargarLista();
            }
        }

        private void BtEliminar_Click_1(object sender, EventArgs e)
        {
            int generoId = -1;
            try
            {
                generoId = (int)dgvGenero.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione un género!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (generoId > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Genero.GetGenero().BorrarGenero(generoId);
                    }
                    catch (Exception excepcion)
                    {
                        MessageBox.Show(excepcion.Message + ", tiene datos asociados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                tbFiltrar.Text = "";
                CargarLista();
            }
        }

        private void TbFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                try
                {
                    dgvGenero.DataSource = AccesoDatos.Logic.Genero.GetGenero().ListarGenero().Where(x => x.Descripcion.ToLower().Contains(tbFiltrar.Text.ToLower())).ToList();
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
    }
}
