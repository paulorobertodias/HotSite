using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;

namespace Hotsite.Controllers
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

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            try{
                DatabaseService dbs = new DatabaseService();
                dbs.CadastraInteresse(cad);
            }catch(Exception e){
                _logger.LogError("Erro Geral na inserção dos Dados" + e.Message);
                ViewBag.Mensagem = "Erro ao enviar os Dados.";
                return View("Index",cad);  
            }
            ViewBag.Mensagem = "Cadastro Realizado com Sucesso.";
            return View("Index",cad);   
        }
    }
}