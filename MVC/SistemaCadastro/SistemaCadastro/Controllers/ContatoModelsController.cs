using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Data;
using SistemaCadastro.Models;

namespace SistemaCadastro.Controllers
{
    
    public class ContatoModelsController : Controller
    {
        private readonly Contexto _context;

        public ContatoModelsController(Contexto context)
        {
            _context = context;
        }

        // GET: ContatoModels
       
        public async Task<IActionResult> Index()
        {
              return _context.Contato != null ? 
                          View(await _context.Contato.ToListAsync()) :
                          Problem("Entity set 'Contexto.Contato'  is null.");
        }

        // GET: ContatoModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contato == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        // GET: ContatoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContatoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Celular")] ContatoModel contatoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contatoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contatoModel);
        }

        // GET: ContatoModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contato == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contato.FindAsync(id);
            if (contatoModel == null)
            {
                return NotFound();
            }
            return View(contatoModel);
        }

        // POST: ContatoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Celular")] ContatoModel contatoModel)
        {
            if (id != contatoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contatoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoModelExists(contatoModel.Id))
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
            return View(contatoModel);
        }

        // GET: ContatoModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contato == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        // POST: ContatoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contato == null)
            {
                return Problem("Entity set 'Contexto.Contato'  is null.");
            }
            var contatoModel = await _context.Contato.FindAsync(id);
            if (contatoModel != null)
            {
                _context.Contato.Remove(contatoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContatoModelExists(int id)
        {
          return (_context.Contato?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
