using UWP.Auxiliar;

namespace UWP.Model
{
    public class Clasificacion : NotifyBase
    {
        private int _clasificacionId;
        private string _descripcion;

        public int ClasificacionId
        {
            get => _clasificacionId;
            set { _clasificacionId = value; NotificarCambio("ClasificacionId"); }
        }
        public string Descripcion
        {
            get => _descripcion;
            set { _descripcion = value; NotificarCambio("Descripcion"); }
        }
    }
}
