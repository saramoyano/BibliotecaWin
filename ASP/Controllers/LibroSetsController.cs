using ASP.Data;
using ASP.Models;
using ASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Controllers
{
    public class LibroSetsController : Controller
    {
        private readonly ProyectoWinFormsContext _context;

        public LibroSetsController(ProyectoWinFormsContext context)
        {
            _context = context;
        }

        // GET: LibroSets
        public async Task<IActionResult> Index(int? clasificacionId, int? generoId)
        {
            
            ViewData["list"] = new SelectList(_context.ClasificacionSet.ToList(), "ClasificacionId", "Descripcion");
            ViewData["gen"] = new SelectList(_context.GeneroSet.ToList(), "GeneroId", "Descripcion");
            if (clasificacionId != null && generoId != null)
            {
                var proyectoWinFormsContextFiltroAmbos = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Where(s => s.ClasificacionClasificacionId == (clasificacionId)).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero).Where(s => s.GeneroGeneroId == (generoId));
                return View(await proyectoWinFormsContextFiltroAmbos.ToListAsync());
            } else if (clasificacionId != null && generoId == null)
            {
                var proyectoWinFormsContextFiltroCla= _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Where(s => s.ClasificacionClasificacionId == (clasificacionId)).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero);
                return View(await proyectoWinFormsContextFiltroCla.ToListAsync());
            }
                   else if(clasificacionId == null && generoId != null) {
                var proyectoWinFormsContextFiltroGen = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero).Where(s => s.GeneroGeneroId == (generoId));
                return View(await proyectoWinFormsContextFiltroGen.ToListAsync());
            } 
            else
            {
                var proyectoWinFormsContext = _context.LibroSet.Include(l => l.AutorAutor).Include(l => l.ClasificacionClasificacion).Include(l => l.EditorialEditorial).Include(l => l.GeneroGenero);
                return View(await proyectoWinFormsContext.ToListAsync());
            }   
        }

        // GET: LibroSets/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            
            if (id == null)
            {
                return NotFound();
            }

            LibrosClass libro = new LibrosClass();
            libro.Libro = await _context.LibroSet
                .Include(l => l.AutorAutor)
                .Include(l => l.ClasificacionClasificacion)
                .Include(l => l.EditorialEditorial)
                .Include(l => l.GeneroGenero)
                .FirstOrDefaultAsync(m => m.LibroId == id);

            libro.LibroSet = await _context.LibroSet
                .Where(m => m.AutorAutorId == libro.Libro.AutorAutorId && m.LibroId != id)
                .Include(l => l.AutorAutor)
                .Include(l => l.ClasificacionClasificacion)
                .Include(l => l.EditorialEditorial)
                .Include(l => l.GeneroGenero).ToListAsync();
               
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

     

    }
}
