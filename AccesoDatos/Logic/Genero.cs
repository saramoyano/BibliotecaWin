using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Logic
{
    public class Genero
    {
        private static Genero genero;

        public static Genero GetGenero()
        {
            if (genero == null)
            {
                genero = new Genero();
            }
            return genero;
        }

        public List<Model.Genero> ListarGenero()
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    return context.GeneroSet.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception("Lista sin elementos ", e);
                }
            }
        }

        public void InsertarGenero(Model.Genero genero)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    context.GeneroSet.Add(genero);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido insertar el género ", e);
                }
            }
        }

        public void ActualizarGenero(Model.Genero genero)
        {

            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var g = context.GeneroSet.FirstOrDefault(x => x.GeneroId == genero.GeneroId);
                    context.Entry(g).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(g).CurrentValues.SetValues(genero);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido actualizar el género ", e);
                }
            }

        }

        public void BorrarGenero(int GeneroID)
        {
            using (var context = new Model.BibliotecaContextContainer())
            {
                try
                {
                    var g = context.GeneroSet.FirstOrDefault(x => x.GeneroId == GeneroID);
                    context.Entry(g).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("No se ha podido borrar el género ", e);
                }
            }
        }

    }
}
