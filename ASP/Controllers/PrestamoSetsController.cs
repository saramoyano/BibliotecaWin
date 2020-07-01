using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.Data;
using ASP.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASP.Controllers
{
    [Authorize]
    public class PrestamoSetsController : Controller
    {
        private readonly ProyectoWinFormsContext _context;

        public PrestamoSetsController(ProyectoWinFormsContext context)
        {
            _context = context;
        }

        // GET: PrestamoSets
        public async Task<IActionResult> Index()
        {
            var proyectoWinFormsContext = _context.PrestamoSet.Include(p => p.LibroLibro).Include(p => p.UsuarioDniNavigation).Where(x => x.UsuarioDniNavigation.Email.Equals(User.Identity.Name));
            return View(await proyectoWinFormsContext.ToListAsync());
        }  
    }
}
