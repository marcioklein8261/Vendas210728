using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Services;

namespace VendaDefinitiva.Controllers
{
    public class RegistroDeVendasController : Controller
    {

        private readonly ServicoDeRegistroDeVenda _servicoDeRegistroDeVenda;

        public RegistroDeVendasController(ServicoDeRegistroDeVenda servicoDeRegistroDeVenda)
        {
            _servicoDeRegistroDeVenda = servicoDeRegistroDeVenda;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> BuscaSimplesAsync(DateTime? dataInicial, DateTime? dataFinal)

        //{
        //    var result = await _servicoDeRegistroDeVenda.EncontrarPorDataAsync(dataInicial, dataFinal);
        //    return View();
        //}


        public IActionResult BuscaSimples()
        {
            return View();
        }
        public IActionResult BuscaDeGrupo()
        {
            return View();
        }
    }
}
