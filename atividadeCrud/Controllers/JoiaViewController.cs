using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _atividadeCrud.Context;
using _atividadeCrud.Models;

namespace atividadeCrud.Controllers
{
    public class JoiaViewController : Controller
    {
        private readonly AppDbContext _context;

        public JoiaViewController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JoiaControllerr
        public IActionResult Index()
        {
            var appDbContext = _context.Joias.Include(b => b.Categoria);
            return View( appDbContext.ToList());
        }

        // GET: JoiaControllerr/Details/5
        
    }
}
