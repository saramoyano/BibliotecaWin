using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;
using UWP.Model;

namespace UWP.ViewModel
{
   public class ClasificacionPageViewModel: NotifyBase

    {
        public ObservableCollection<Clasificacion> Clasificaciones;

        public ClasificacionPageViewModel() {
            Clasificaciones = Datos.LogicaClasificacion.GetClasificacion().GetClasificaciones();
        }

    }
}
