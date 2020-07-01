using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Frm
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (barraProgreso.Value < barraProgreso.Maximum)
            {
                barraProgreso.Value += 100;
            }
        }


        private void FrmSplash_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private async void cargarDatos()
        {
            await Task.Run(() =>
            {
                cargarGenero();
                Thread.Sleep(500);
                cargarUsuario();
                Thread.Sleep(500);
                cargarClasificacion();
                Thread.Sleep(500);
                cargarConfiguracion();
                Thread.Sleep(500);
            });
            this.Close();
        }

        private static void cargarConfiguracion()
        {
            if (!AccesoDatos.Logic.Configuracion.GetConfiguracion().ListarConfiguracion().Any())
            {
                AccesoDatos.Model.Configuracion configuracion = new AccesoDatos.Model.Configuracion();
                configuracion.NumDiasPrestamo1 = 15;
                configuracion.NumDiasPrestamo2 = 30;
                configuracion.MaxPrestamoUsuario = 3;
                try
                {
                    AccesoDatos.Logic.Configuracion.GetConfiguracion().InsertarConfiguracion(configuracion);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
        }

        private static void cargarClasificacion()
        {
            if (!AccesoDatos.Logic.Clasificacion.GetClasificacion().ListarClasificacion().Any())
            {
                try
                {
                    AccesoDatos.Model.Clasificacion todoPublico = new AccesoDatos.Model.Clasificacion();
                    todoPublico.Descripcion = "Todos los públicos";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(todoPublico);

                    AccesoDatos.Model.Clasificacion unoATres = new AccesoDatos.Model.Clasificacion();
                    unoATres.Descripcion = "Entre 1 y 3 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(unoATres);

                    AccesoDatos.Model.Clasificacion cuatroACinco = new AccesoDatos.Model.Clasificacion();
                    cuatroACinco.Descripcion = "Entre 4 y 5 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(cuatroACinco);

                    AccesoDatos.Model.Clasificacion seisAdiez = new AccesoDatos.Model.Clasificacion();
                    seisAdiez.Descripcion = "Entre 6 y 10 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(seisAdiez);

                    AccesoDatos.Model.Clasificacion onceADieciseis = new AccesoDatos.Model.Clasificacion();
                    onceADieciseis.Descripcion = "Entre 11 y 16 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(onceADieciseis);

                    AccesoDatos.Model.Clasificacion diecisieteAdieciocho = new AccesoDatos.Model.Clasificacion();
                    diecisieteAdieciocho.Descripcion = "Entre 17 y 18 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(diecisieteAdieciocho);

                    AccesoDatos.Model.Clasificacion mayorEdad = new AccesoDatos.Model.Clasificacion();
                    mayorEdad.Descripcion = "Entre 17 y 18 años";
                    AccesoDatos.Logic.Clasificacion.GetClasificacion().InsertarClasificacion(mayorEdad);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
        }

        private static void cargarUsuario()
        {
            if (!AccesoDatos.Logic.Usuario.GetUsuario().ListarUsuarios().Any())
            {
                try
                {
                    AccesoDatos.Model.Usuario usuario = new AccesoDatos.Model.Usuario();
                    usuario.DNI = "12345678Z";
                    usuario.Nombre = "Administrador";
                    usuario.Apellidos = "Administrador";
                    usuario.InicioSesion = true;
                    string pass = "123456";
                    usuario.Salt = FrmUsuarioRead.CalcularSalt(usuario.DNI, pass);
                    usuario.Direccion = "Av. Siempreviva 123";
                    usuario.Poblacion = "Murcia";
                    usuario.CodigoPostal = "30100";
                    usuario.Provincia = "Murcia";
                    usuario.Telefono1 = "666666666";
                    usuario.Telefono2 = "";
                    AccesoDatos.Logic.Usuario.GetUsuario().InsertarUsuario(usuario);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
        }

        private static void cargarGenero()
        {
            if (!AccesoDatos.Logic.Genero.GetGenero().ListarGenero().Any())
            {
                try
                {
                    AccesoDatos.Model.Genero accion = new AccesoDatos.Model.Genero();
                    accion.Descripcion = "Acción";

                    AccesoDatos.Logic.Genero.GetGenero().InsertarGenero(accion);

                    AccesoDatos.Model.Genero cuentos = new AccesoDatos.Model.Genero();
                    cuentos.Descripcion = "Cuentos infantiles";
                    AccesoDatos.Logic.Genero.GetGenero().InsertarGenero(cuentos);
                    AccesoDatos.Model.Genero policiaca = new AccesoDatos.Model.Genero();
                    policiaca.Descripcion = "Policíaca";
                    AccesoDatos.Logic.Genero.GetGenero().InsertarGenero(policiaca);

                    AccesoDatos.Model.Genero romantica = new AccesoDatos.Model.Genero();
                    romantica.Descripcion = "Romántica";
                    AccesoDatos.Logic.Genero.GetGenero().InsertarGenero(romantica);
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }
            }
        }
    }
}
