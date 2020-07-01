using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmCambiarPassword : Form
    {
        private String dniUser;
        public FrmCambiarPassword(String dni)
        {
            InitializeComponent();
            this.dniUser = dni;
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (!tbPass1.Text.Equals("") && !tbPass2.Text.Equals(""))
            {
                try
                {
                    AccesoDatos.Model.Usuario usuario = AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Where(x => x.DNI.Equals(dniUser)).FirstOrDefault();
                    String user = usuario.DNI;

                    if (tbPass1.Text.Equals(tbPass2.Text))
                    {
                        String sal = FrmUsuarioRead.CalcularSalt(dniUser, tbPass2.Text);
                        usuario.Salt = sal;
                        AccesoDatos.Logic.Usuario.GetUsuario().ActualizarUsuario(usuario);
                        MessageBox.Show("Contraseña modificada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //this.Close();
            }
            else
            {
                MessageBox.Show("Faltan datos obligatorios!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbPass2_TextChanged(object sender, EventArgs e)
        {
            if (tbPass2.Text.Equals(""))
            {
                lbError.Visible = false;
            }

            if (!tbPass2.Text.Equals("") && !tbPass1.Text.Equals(tbPass2.Text))
            {
                lbError.Visible = true;
            }
            else
            {
                lbError.Visible = false;
            }
        }

        private void TbPass1_TextChanged(object sender, EventArgs e)
        {
            if (tbPass1.Text.Equals(""))
            {
                lbError.Visible = false;
            }

            if (!tbPass1.Text.Equals("") && !tbPass1.Text.Equals(tbPass2.Text))
            {
                lbError.Visible = true;
            }
            else
            {
                lbError.Visible = false;
            }
        }
    }
}
