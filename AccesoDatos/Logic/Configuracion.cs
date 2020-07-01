using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Configuracion
    {
        private static Configuracion configuracion;

        public static Configuracion GetConfiguracion()
        {
            if (configuracion == null)
            {
                configuracion = new Configuracion();
            }

            return configuracion;
        }

        public List<Model.Configuracion> ListarConfiguracion()
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.ConfiguracionSet.ToList();
                }
                catch (Exception e)

                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarConfiguracion(Model.Configuracion configuracion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.ConfiguracionSet.Add(configuracion);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar la configuración ", e);
                }

            }
        }

        public void ActualizarConfiguracion(Model.Configuracion configuracion)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var config = context.ConfiguracionSet.FirstOrDefault(x => x.ConfiguracionId == configuracion.ConfiguracionId);
                    context.Entry(config).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(config).CurrentValues.SetValues(configuracion);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar la configuración ", e);
                }
            }
        }

        public void BorrarConfiguracion(int configuracionID)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var config = context.ConfiguracionSet.FirstOrDefault(x => x.ConfiguracionId == configuracionID);
                    context.Entry(config).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar la configuración ", e);
                }
            }
        }
    }
}
