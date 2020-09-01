using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class ProyectoController : Controller
    {
        private readonly WebContext _context;

        public ProyectoController(WebContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Proyectos/listarProyectos")]
        public IEnumerable<Proyecto> listarProyectos() 
        {
                List<Proyecto> proyectos = _context.Proyectos.ToList();

            return proyectos;

        }
    }
}