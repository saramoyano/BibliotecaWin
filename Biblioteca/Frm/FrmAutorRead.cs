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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Biblioteca.Frm
{
    public partial class FrmAutorRead : Form
    {
        public FrmAutorRead()
        {
            InitializeComponent();
        }

        private void AñadirAutor_Click(object sender, EventArgs e)
        {
            FrmAutorCreate frmCreate = new FrmAutorCreate();
            frmCreate.ShowDialog();
            cargarLista();
        }


        private void BtEditar_Click(object sender, EventArgs e)
        {
            int autorId = -1;
            try
            {
             autorId= (int)dgvAutores.SelectedRows[0].Cells[0].Value;
            }catch(Exception excepcion)
            {
                MessageBox.Show("Seleccione un autor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (autorId < 0)
            {
                ; 
            }
            else
            {
                FrmAutorUpdate frmUpdate = new FrmAutorUpdate(autorId);
                frmUpdate.ShowDialog();
                tbFiltrar.Text = "";
                cargarLista();
            }
        }


        private void BtEliminar_Click(object sender, EventArgs e)
        {
            int autorId = -1;
            try
            {
                autorId = (int)dgvAutores.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione un autor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (autorId < 0)
            {
                ;
            }
            else
            {
                string autorNombre = (string)dgvAutores.SelectedRows[0].Cells[1].Value;
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Autor.GetAutor().BorrarAutor(autorId);
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message + ", tiene datos asociados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                tbFiltrar.Text = "";
                cargarLista();
            }


        }

        private void FrmAutorRead_Load(object sender, EventArgs e)
        {
            cargarLista();


        }

        private void TbFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                try
                {
                    dgvAutores.DataSource = AccesoDatos.Logic.Autor.GetAutor().ListarAutores().Where(x => x.Apellidos.ToLower().Contains(tbFiltrar.Text.ToLower())).ToList();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message + ", tiene datos asociados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                cargarLista();
            }

        }

        private void cargarLista()
        {
            try
            {
                dgvAutores.DataSource = AccesoDatos.Logic.Autor.GetAutor().ListarAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgvAutores.Columns[0].Visible = false;
            dgvAutores.Columns[3].Visible = false;
        }


    }
}
