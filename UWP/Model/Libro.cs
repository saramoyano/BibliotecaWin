using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Auxiliar;
using Windows.UI.Xaml.Media;

namespace UWP.Model
{
    public class Libro : NotifyBase
    {

        private int _libroID;
        private string _titulo;
        private ImageSource imagen;
        private string autor;
        private string descripcion;
        private string _clasificacion;
        private string _genDesc;

        public int LibroID { get => _libroID; set { _libroID = value; NotificarCambio("LibroID"); } }
        public string Titulo { get => _titulo; set { _titulo = value; NotificarCambio("Titulo"); } }
        public ImageSource Imagen { get => imagen; set { imagen = value; NotificarCambio("Imagen"); } }
    public string Autor { get => autor; set { autor = value; NotificarCambio("Autor"); }}
        public string Descripcion { get => descripcion; set { descripcion = value; NotificarCambio("Descripcion"); } }

        public string Clasificacion { get => _clasificacion; set { _clasificacion = value; NotificarCambio("Clasificacion"); } }

        public string GenDesc { get => _genDesc; set { _genDesc = value; NotificarCambio("GenDesc"); } }
    }
}
