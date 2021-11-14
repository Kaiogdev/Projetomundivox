using CopaDeVerdade.Database;
using CopaDeVerdade.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeVerdade.Controllers
{
    public class CopaController : Controller
    {
        private readonly CopaContext _context;
        public CopaController(CopaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CadastrarTime(IFormCollection form)
        {
            var time = Request.Form["time"].ToString();

            var TimeParaCadastrar = new Time()
            {
                Nome = time
            };

            _context.Times.Add(TimeParaCadastrar);
            _context.SaveChanges();

            return View(ListarTimes());
        }

        public IActionResult CadastrarTime()
        { 
            return View(ListarTimes());
        }

        public IActionResult GerenciarTorneio()
        {
            var listaTimes = ListarTimes();
            
            if(listaTimes == null ||  listaTimes.Count() < 4)
            {
                ViewBag.Mensagem = "Devem ter pelo menos 4 times.";

                return View();
            }

            return View(listaTimes);
        }

        [HttpPost]
        public IActionResult GerenciarTorneio(IFormCollection form)
        {
            var listaTimes = ListarTimes();

            return View(listaTimes);
        }

        List<Time> ListarTimes()
        {
            var lista = _context.Times.ToList();

            return lista;
        }

    }
}
