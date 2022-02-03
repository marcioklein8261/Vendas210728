using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Models;
using VendaDefinitiva.Services;
using VendaDefinitiva.Models.ViewModels;
using VendaDefinitiva.Services.Exceptions;
using System.Diagnostics;


namespace VendaDefinitiva.Controllers
{
    public class ProductsController : Controller
    {
        public readonly ProdutoService _produtoServico;

        public ProductsController(ProdutoService produtoServico)
        {
            _produtoServico = produtoServico;

        }



        public IActionResult Index()
        {
            var list = _produtoServico.EncontreTodo();
            return View(list);
        }

        //[ValidateAntiForgeryToken]
        //[HttpPost]
        //public IActionResult Create(Produto produto)
        //{
        //    _produtoServico.Create(produto);
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult Entrada()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Entrada(Produto produto)
        {
            _produtoServico.Inserir(produto);
            return RedirectToAction(nameof(Index));
        }



    }
}
