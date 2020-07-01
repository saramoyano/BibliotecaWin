using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Autor
    {
        private static Autor autor;

        public static Autor GetAutor()
        {
            if (autor == null)
            {
                autor = new Autor();
            }
            return autor;
        }
        public List<Model.Autor> ListarAutores()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.AutorSet.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarAutor(Model.Autor autor)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {

                try
                {
                    context.AutorSet.Add(autor);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar el autor ", e);
                }
            }
        }

        public void ActualizarAutor(Model.Autor autor)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var aut = context.AutorSet.FirstOrDefault(x => x.AutorId == autor.AutorId);
                    context.Entry(aut).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(aut).CurrentValues.SetValues(autor);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar el autor ", e);
                }
            }

        }

        public void BorrarAutor(int AutorId)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var aut = context.AutorSet.FirstOrDefault(x => x.AutorId == AutorId);
                    context.Entry(aut).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar el autor ", e);
                }
            }


        }
    }
}
