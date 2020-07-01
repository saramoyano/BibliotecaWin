using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Model;

namespace UWP.ViewModel
{
   public class LibrosPageViewModel
    {
        public ObservableCollection<Libro> Libros;
        private object parameter;
        private string filtro;
        
        
        public LibrosPageViewModel()
        {
            Libros = Datos.LogicaLibro.GetInstance().GetLibros();
            filtro = "Todos los libros";
        }

        public LibrosPageViewModel(Model.Clasificacion clasificacion)
        {
            Libros = Datos.LogicaLibro.GetInstance().GetLibros(clasificacion.ClasificacionId);
            filtro = "Libros clasificados para " + clasificacion.Descripcion;
        }

        public LibrosPageViewModel(Model.Genero genero)
        {
            Libros = Datos.LogicaLibro.GetInstance().GetLibrosGen(genero.GeneroId);
            filtro = "Libros del genero " + genero.Descripcion;
        }

        public string Filtro { get => filtro; set => filtro = value; }
    }
}
