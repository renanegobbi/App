using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi_OData.Models;

namespace WebApi_OData.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly DbClienteContext _contexto;

        public HomeController(DbClienteContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            ViewData["sessao"] = "Clientes";
            return View(_contexto.Cliente.ToList());
        }

        public IActionResult Pedidos()
        {
            ViewData["sessao"] = "Pedidos";
            return View(_contexto.Pedido.ToList());
        }

        public IActionResult Produtos()
        {
            ViewData["sessao"] = "Produtos";
            return View(_contexto.Produto.ToList());
        }

        public IActionResult Contato()
        {
            ViewData["sessao"] = "Contatos";
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
