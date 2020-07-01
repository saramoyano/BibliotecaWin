using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Usuario
    {
        private static Usuario usuario;

        public static Usuario GetUsuario()
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
            return usuario;
        }

        public List<Model.Usuario> ListarUsuarios()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.UsuarioSet.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarUsuario(Model.Usuario usuario)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.UsuarioSet.Add(usuario);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar el usuario ", e);
                }
            }
        }

        public void ActualizarUsuario(Model.Usuario usuario)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var usu = context.UsuarioSet.FirstOrDefault(x => x.DNI == usuario.DNI);
                    context.Entry(usu).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(usu).CurrentValues.SetValues(usuario);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar el usuario ", e);
                }
            }

        }

        public void BorrarUsuario(String UsuarioDNI)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var usu = context.UsuarioSet.FirstOrDefault(x => x.DNI.Equals(UsuarioDNI));
                    context.Entry(usu).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar el usuario ", e);
                }
            }


        }
    }
}
