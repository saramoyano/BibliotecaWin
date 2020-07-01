using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmEditorialRead : Form
    {
        public FrmEditorialRead()
        {
            InitializeComponent();
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            FrmEditorialCreate frmCreate = new FrmEditorialCreate();
            frmCreate.ShowDialog();
            cargarLista();
        }

        private void FrmEditorialRead_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            int editorialId = -1;
            try
            {
                editorialId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione una editorial!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (editorialId < 0)
            {
                ;
            }
            else
            {
                FrmEditorialUpdate frmUpdate = new FrmEditorialUpdate(editorialId);
                frmUpdate.ShowDialog();
                cargarLista();
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            int editorialId = -1;
            try
            {
                editorialId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione una editorial!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (editorialId < 0)
            {
                ;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Editorial.GetEditorial().BorrarEditorial(editorialId);
                    }
                    catch (Exception excepcion)
                    {
                        MessageBox.Show(excepcion.Message + ", tiene datos asociados.");
                    }
                }
                cargarLista();
            }
        }

        private void cargarLista()
        {
            try
            {
                dataGridView1.DataSource = AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Razón Social";
                dataGridView1.Columns[2].HeaderText = "Dirección";
                dataGridView1.Columns[6].HeaderText = "Teléfono";
                dataGridView1.Columns[8].HeaderText = "Persona de Contacto";

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        private void TbFiltrar_TextChanged(object sender, EventArgs e)
        {
            CargarListaFiltradaOrdenada();
        }

        private void CargarListaFiltradaOrdenada()
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                try { 
                dataGridView1.DataSource = AccesoDatos.Logic.Editorial.GetEditorial().ListarEditorial().Where(x => x.RazonSocial.ToLower().Contains(tbFiltrar.Text.ToLower())).ToList();
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
            else
            {
                cargarLista();
            }
        }
    }
}
