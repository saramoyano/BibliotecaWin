using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Libro
    {
        private static Libro libro;
        public static Libro GetLibro()
        {
            if (libro == null)
            {
                libro = new Libro();
            }
            return libro;
        }

        public List<Model.Libro> ListarLibro()
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.LibroSet.Include("Autor").Include("Editorial").Include("Clasificacion").Include("Genero").ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }



        public void InsertarLibro(Model.Libro libro)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.LibroSet.Add(libro);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar el libro ", e);
                }
            }
        }

        public void ActualizarLibro(Model.Libro libro)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var li = context.LibroSet.FirstOrDefault(x => x.LibroId == libro.LibroId);
                    context.Entry(li).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(li).CurrentValues.SetValues(libro);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar el libro ", e);
                }
            }
        }



        public void BorrarLibro(int LibroID)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var lib = context.LibroSet.FirstOrDefault(x => x.LibroId == LibroID);
                    context.Entry(lib).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar el libro ", e);
                }
            }
        }

    }
}

