using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Editorial
    {
        private static Editorial editorial;

        public static Editorial GetEditorial()
        {
            if (editorial == null)
            {
                editorial = new Editorial();
            }
            return editorial;
        }

        public List<Model.Editorial> ListarEditorial()
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.EditorialSet.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarEditorial(Model.Editorial editorial)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.EditorialSet.Add(editorial);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar la editorial ", e);
                }
            }
        }

        public void ActualizarEditorial(Model.Editorial editorial)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var edi = context.EditorialSet.FirstOrDefault(x => x.EditorialId == editorial.EditorialId);
                    context.Entry(edi).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(edi).CurrentValues.SetValues(editorial);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar la editorial ", e);
                }
            }

        }

        public void BorrarEditorial(int EditorialID)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var edi = context.EditorialSet.FirstOrDefault(x => x.EditorialId == EditorialID);
                    context.Entry(edi).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar la editorial ", e);
                }
            }
        }

    }
}
