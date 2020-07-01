using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Clasificacion
    {
        private static Clasificacion clasificacion;

        public static Clasificacion GetClasificacion()
        {
            if (clasificacion == null)
            {
                clasificacion = new Clasificacion();
            }
            return clasificacion;
        }

        public List<Model.Clasificacion> ListarClasificacion()
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.ClasificacionSet.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarClasificacion(Model.Clasificacion clasificacion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.ClasificacionSet.Add(clasificacion);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar la clasificación ", e);
                }
            }
        }

        public void ActualizarClasificacion(Model.Clasificacion clasificacion)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var cla = context.ClasificacionSet.FirstOrDefault(x => x.ClasificacionId == clasificacion.ClasificacionId);
                    context.Entry(cla).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(cla).CurrentValues.SetValues(clasificacion);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido acualizar la clasificación ", e);
                }
            }

        }

        public void BorrarClasificacion(int clasificacionId)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var cla = context.ClasificacionSet.FirstOrDefault(x => x.ClasificacionId == clasificacionId);
                    context.Entry(cla).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar la clasificación ", e);
                }
            }


        }
    }
}
