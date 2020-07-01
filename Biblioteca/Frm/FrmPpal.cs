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
    public partial class FrmPpal : Form
    {
        FrmLogin frmLogin;
        public FrmPpal()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (DialogResult.No == MessageBox.Show("¿Cerrar todo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            frmLogin = new FrmLogin();
            if (DialogResult.Cancel == frmLogin.ShowDialog())
            {
                this.Close();
            }
            else
            {
                personalToolStripMenuItem.Text = frmLogin.usuario.Nombre + " " + frmLogin.usuario.Apellidos;
            }
        }

        public void RefrescarTablas()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (typeof(FrmPrestamoHistoricoRead) == form.GetType())
                {
                    ((FrmPrestamoHistoricoRead)form).cargarListaPrestamos();
                }
                else if (typeof(FrmLibroRead) == form.GetType())
                {
                    ((FrmLibroRead)form).cargarLista();
                }
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frm = new FrmAcercaDe();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void EditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditorialRead frm = new FrmEditorialRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutorRead frm = new FrmAutorRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PréstamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPrestamosRead frm = new FrmPrestamosRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void LibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibroRead frm = new FrmLibroRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioRead frm = new FrmUsuarioRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void GeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneroRead frm = new FrmGeneroRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ClasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClasificacionRead frm = new FrmClasificacionRead();
            frm.MdiParent = this;
            frm.Show();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamoHistoricoRead frm = new FrmPrestamoHistoricoRead();
            frm.MdiParent = this;
            frm.Show();
        }


        private void CambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin.usuario.InicioSesion == true)
            {
                String dni = frmLogin.usuario.DNI;
                FrmCambiarPassword frm = new FrmCambiarPassword(dni);
                //frm.MdiParent = this;
                frm.ShowDialog();
            }
        }

        private void ConfiguraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracionUpdate frm = new FrmConfiguracionUpdate();
            //frm.MdiParent = this;
            frm.ShowDialog();
        }

        public static explicit operator FrmPpal(FrmPrestamoCreate v)
        {
            throw new NotImplementedException();
        }
    }
}
