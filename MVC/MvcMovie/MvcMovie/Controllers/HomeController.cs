﻿using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Diagnostics;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //cadastrar Pessoas
        [HttpPost] //METODO que recebe a pessoa
        public IActionResult Cadastrar(Pessoa p)
        {
            string nome = p.Nome;
            string Cpf = p.Cpf;
            //ViewData["nome"] = nome;
            return View("Pessoa");
        }
        // ao clicar no btn cadatrar retorna pessoa
        public IActionResult Pessoa(Pessoa p)
        {
            return View(p);
        }

        public IActionResult Sobre()
        {

            return View();
        }

        public IActionResult Cadastrar()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}