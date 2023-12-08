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
    [Area("LogAd")]
    public class JoiaController : Controller
    {
        private readonly AppDbContext _context;

        public JoiaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: JoiaControllerr
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Joias.Include(b => b.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        // GET: JoiaControllerr/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Joias == null)
            {
                return NotFound();
            }

            var brincoColarPulseira = await _context.Joias
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.BrincoColarPulseiraId == id);
            if (brincoColarPulseira == null)
            {
                return NotFound();
            }

            return View(brincoColarPulseira);
        }

        // GET: JoiaControllerr/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");
            return View();
        }

        // POST: JoiaControllerr/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrincoColarPulseiraId,Nome,Descricao,Imagem,Ativo,CategoriaId")] BrincoColarPulseira brincoColarPulseira)
        {
           
                _context.Add(brincoColarPulseira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: JoiaControllerr/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Joias == null)
            {
                return NotFound();
            }

            var brincoColarPulseira = await _context.Joias.FindAsync(id);
            if (brincoColarPulseira == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", brincoColarPulseira.CategoriaId);
            return View(brincoColarPulseira);
        }

        // POST: JoiaControllerr/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrincoColarPulseiraId,Nome,Descricao,Imagem,Ativo,CategoriaId")] BrincoColarPulseira brincoColarPulseira)
        {
            if (id != brincoColarPulseira.BrincoColarPulseiraId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brincoColarPulseira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrincoColarPulseiraExists(brincoColarPulseira.BrincoColarPulseiraId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome", brincoColarPulseira.CategoriaId);
            return View(brincoColarPulseira);
        }

        // GET: JoiaControllerr/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Joias == null)
            {
                return NotFound();
            }

            var brincoColarPulseira = await _context.Joias
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.BrincoColarPulseiraId == id);
            if (brincoColarPulseira == null)
            {
                return NotFound();
            }

            return View(brincoColarPulseira);
        }

        // POST: JoiaControllerr/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Joias == null)
            {
                return Problem("Entity set 'AppDbContext.Joias'  is null.");
            }
            var brincoColarPulseira = await _context.Joias.FindAsync(id);
            if (brincoColarPulseira != null)
            {
                _context.Joias.Remove(brincoColarPulseira);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrincoColarPulseiraExists(int id)
        {
          return (_context.Joias?.Any(e => e.BrincoColarPulseiraId == id)).GetValueOrDefault();
        }
    }
}
