using Microsoft.AspNetCore.Mvc;
using VendaDefinitiva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaDefinitiva.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> lista= new List<Produto>();

            lista.Add(new Produto { IdProduto = 1, NomeProduto = "Mouse", UnidadeProduto = "peça" });
            lista.Add(new Produto { IdProduto = 2, NomeProduto = "Bioestatistica", UnidadeProduto = "livro" });

            return View(lista);
        }
    }
}
