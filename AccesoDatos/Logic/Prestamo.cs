using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Prestamo
    {
        private static Prestamo prestamo;

        public static Prestamo GetPrestamo()
        {
            if (prestamo == null)
            {
                prestamo = new Prestamo();
            }

            return prestamo;
        }

        public List<Model.Prestamo> ListarPrestamos()
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.PrestamoSet.Include("Usuario").Include("Libro").ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarPrestamo(Model.Prestamo prestamo)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.PrestamoSet.Add(prestamo);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar el préstamo ", e);
                }
            }
        }

        public void ActualizarPrestamo(Model.Prestamo prestamo)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var pres = context.PrestamoSet.FirstOrDefault(x => x.PrestamoId == prestamo.PrestamoId);
                    context.Entry(pres).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(pres).CurrentValues.SetValues(prestamo);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar el préstamo ", e);
                }
            }
        }

        public void BorrarPrestamo(int prestamoID)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var pres = context.PrestamoSet.FirstOrDefault(x => x.PrestamoId == prestamoID);
                    context.Entry(pres).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar el préstamo ", e);
                }
            }
        }
    }
}
