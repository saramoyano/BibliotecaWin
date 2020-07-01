using ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.ViewModels
{
    public class LibrosClass
    {
        private LibroSet libro;
        private List<LibroSet> libroSet;

        public LibroSet Libro { get => libro; set => libro = value; }
        public List<LibroSet> LibroSet { get => libroSet; set => libroSet = value; }
    }
}
