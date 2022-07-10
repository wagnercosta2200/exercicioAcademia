﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Data;
using SistemaCadastro.Models;
using SistemaCadastro.Repositorio;

namespace SistemaCadastro.Controllers
{
    public class ContatosController : Controller
    {
        private readonly Contexto _context;

        public ContatosController(Contexto context)
        {
            _context = context;
        }

        //// GET: Contatos
        //public async Task<IActionResult> Index()
        //{
        //      return _context.Contato != null ? 
        //                  View(await _context.Contato.ToListAsync()) :
        //                  Problem("Entity set 'Contexto.Contato'  is null.");
        //}

        //// GET: Contatos/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Contato == null)
        //    {
        //        return NotFound();
        //    }

        //    var contato = await _context.Contato
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (contato == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contato);
        //}

        // GET: Contatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nome,Email,Celular")] ContatoModel contato)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(contato);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(contato);
        //}

        // GET: Contatos/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Contato == null)
        //    {
        //        return NotFound();
        //    }

        //    var contato = await _context.Contato.FindAsync(id);
        //    if (contato == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(contato);
        //}

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Celular")] ContatoModel contato)
        //{
        //    if (id != contato.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(contato);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ContatoExists(contato.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(contato);
        //}

        //// GET: Contatos/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Contato == null)
        //    {
        //        return NotFound();
        //    }

        //    var contato = await _context.Contato
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (contato == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contato);
        //}

        //// POST: Contatos/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Contato == null)
        //    {
        //        return Problem("Entity set 'Contexto.Contato'  is null.");
        //    }
        //    var contato = await _context.Contato.FindAsync(id);
        //    if (contato != null)
        //    {
        //        _context.Contato.Remove(contato);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ContatoExists(int id)
        //{
        //  return (_context.Contato?.Any(e => e.Id == id)).GetValueOrDefault();
        //}






        //Construtor para adicionar no Banco
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatosController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        [HttpPost]
        public IActionResult Create(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
           List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View();
        }

    }

}
