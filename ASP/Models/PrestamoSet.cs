using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.Models
{
    public partial class PrestamoSet
    {
        public int PrestamoId { get; set; }

        [Display(Name = "Fecha Préstamo")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha Límite Devolución")]
        public DateTime FechaFin { get; set; }

        [Display(Name = "Fecha Devolucion")]
        public DateTime? FechaDevolucion { get; set; }

        
        public string UsuarioDni { get; set; }
        public int LibroLibroId { get; set; }
        [Display(Name = "Libro")]
        public virtual LibroSet LibroLibro { get; set; }

        [Display(Name = "Usuario")]
        public virtual UsuarioSet UsuarioDniNavigation { get; set; }
    }
}
