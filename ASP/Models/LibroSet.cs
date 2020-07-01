using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public partial class LibroSet
    {
        public LibroSet()
        {
            PrestamoSet = new HashSet<PrestamoSet>();
        }

        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public int? Stock { get; set; }
        public int? StockDisponible { get; set; }
        public byte[] Imagen { get; set; }
        public int AutorAutorId { get; set; }
        public int ClasificacionClasificacionId { get; set; }
        public int GeneroGeneroId { get; set; }
        public int EditorialEditorialId { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get {
                if (Descripcion.Length > 30) 
                {
                    return Descripcion.Substring(0, 30)+"...";
                }
                else
                {
                    return Descripcion.Substring(0, Descripcion.Length - 1);
                }
            } }

        [Display(Name="Autor")]
        public virtual AutorSet AutorAutor { get; set; }
        [Display(Name = "Clasificacion")]
        public virtual ClasificacionSet ClasificacionClasificacion { get; set; }
        [Display(Name = "Editorial")]
        public virtual EditorialSet EditorialEditorial { get; set; }
        [Display(Name = "Genero")]
        public virtual GeneroSet GeneroGenero { get; set; }
        public virtual ICollection<PrestamoSet> PrestamoSet { get; set; }
    }
}
