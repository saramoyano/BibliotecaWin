using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmUsuarioRead : Form
    {
        public FrmUsuarioRead()
        {
            InitializeComponent();
        }

        private void BtAñadir_Click(object sender, EventArgs e)
        {
            FrmUsuarioCreate frmCreate = new FrmUsuarioCreate();
            frmCreate.ShowDialog();
            cargarLista();
        }


        private void cargarLista()
        {
            if (cbInicioSesion.Checked)
            {
                try
                {
                    dgvUsuarios.DataSource = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.InicioSesion == true).ToList();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    dgvUsuarios.DataSource = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            dgvUsuarios.Columns[3].Visible = false;
            dgvUsuarios.Columns[4].Visible = false;
            dgvUsuarios.Columns[5].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;
            dgvUsuarios.Columns[7].Visible = false;
            dgvUsuarios.Columns[8].Visible = false;
            dgvUsuarios.Columns[9].Visible = false;
            dgvUsuarios.Columns[10].Visible = false;
            dgvUsuarios.Columns["Prestamo"].Visible = false;
            dgvUsuarios.Columns["InicioSesion"].Visible = true;

        }

        private void BtReiniciarContraseña_Click(object sender, EventArgs e)
        {
            string dni = "";
            AccesoDatos.Model.Usuario usuario = null;
            try
            {
                dni = (string)dgvUsuarios.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFiltrar.Text = "";
            }

            if (!dni.Equals(""))
            {
                try
                {
                    usuario = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.DNI.Equals(dni)).FirstOrDefault();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if ((usuario != null) && (usuario.InicioSesion == true))
                {
                    if (DialogResult.Yes == MessageBox.Show("¿Esta seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                    {
                        string sal = "123456";
                        usuario.Salt = CalcularSalt(usuario.DNI, sal);
                        try
                        {
                            AccesoDatos.Logic.Usuario.GetUsuario().ActualizarUsuario(usuario);
                            MessageBox.Show("Se le ha asignado la contraseña provisoria 123456. Debe cambiarla", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show(excep.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario esta deshabilitado!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static string CalcularSalt(string sUser, string sPass)
        {
            HashAlgorithm hash = new SHA512Managed();
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(sUser + sPass);
            byte[] hashBytes = hash.ComputeHash(plainTextBytes);
            return Convert.ToBase64String(hashBytes);
        }


        private void BtEditar_Click_1(object sender, EventArgs e)
        {

            string dni = "";
            try
            {
                dni = (string)dgvUsuarios.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excep)
            {
                MessageBox.Show("Seleccione un usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFiltrar.Text = "";
            }
            if (dni.Equals(""))
            {
                ;
            }
            else
            {
                FrmUsuarioUpdate frmUpdate = new FrmUsuarioUpdate(dni);
                frmUpdate.ShowDialog();
            }
            cargarLista();

        }

        private void BtEliminar_Click_1(object sender, EventArgs e)
        {
            string dni = "";
            try
            {
                dni = (string)dgvUsuarios.SelectedRows[0].Cells[0].Value;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show("Seleccione un usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbFiltrar.Text = "";
            }
            if (dni.Equals(""))
            {
                ;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("¿Está seguro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1))
                {
                    try
                    {
                        AccesoDatos.Logic.Usuario.GetUsuario().BorrarUsuario(dni);
                    }
                    catch (Exception excepcion)
                    {
                        MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            cargarLista();
        }

        private void FrmUsuarioRead_Load_1(object sender, EventArgs e)
        {

            cargarLista();

        }

        private void CbInicioSesion_CheckedChanged(object sender, EventArgs e)
        {

            cargarLista();

        }

        private void TbFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (!tbFiltrar.Text.Equals(""))
            {
                try
                {
                    dgvUsuarios.DataSource = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.Apellidos.ToLower().Contains(tbFiltrar.Text.ToLower())).ToList();
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
