using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Model;

namespace UWP.ViewModel
{
   public class GeneroViewModel
    {
        public ObservableCollection<Genero> Generos;
        public GeneroViewModel()
        {
            Generos = Datos.LogicaGenero.GetInstance().GetGeneros();
        }

    }
}
