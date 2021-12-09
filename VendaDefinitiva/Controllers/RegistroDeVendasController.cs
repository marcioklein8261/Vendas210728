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

        public async Task<IActionResult> BuscaSimples(DateTime? Inicial, DateTime? Final)
        {
            if (!Inicial.HasValue)
            {
                Inicial = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!Final.HasValue)
            {
                Final = DateTime.Now;
            }

            ViewData["Inicial"] = Inicial.Value.ToString("yyyy-MM-dd");
            ViewData["Final"] = Final.Value.ToString("yyyy-MM-dd");
            var result = await _servicoDeRegistroDeVenda.EncontrarPorDataAsync(Inicial, Final);
            return View(result);
        }

        //public async Task<IActionResult> BuscaSimplesAsync(DateTime? dataInicial, DateTime? dataFinal)

        //{

        //    if (!dataInicial.HasValue)
        //    {
        //        dataInicial = new DateTime(DateTime.Now.Year, 1, 1);
        //    }
        //    if (!dataFinal.HasValue)
        //    {
        //        dataFinal = DateTime.Now;
        //    }
        //    ViewData["minDate"] = dataInicial.Value.ToString("yyyy-MM-dd");
        //    ViewData["maxDate"] = dataFinal.Value.ToString("yyyy-MM-dd");
        //    var result = await _servicoDeRegistroDeVenda.EncontrarPorDataAsync(dataInicial, dataFinal);
        //    return View(result);

        //    }

        //public IActionResult BuscaSimples()
        //{
        //    return View();
        //}
        //public IActionResult BuscaSimples(DateTime? dataInicial, DateTime? dataFinal)

        //{

        //    if (!dataInicial.HasValue)
        //    {
        //        dataInicial = new DateTime(DateTime.Now.Year, 1, 1);
        //    }
        //    if (!dataFinal.HasValue)
        //    {
        //        dataFinal = DateTime.Now;
        //    }
        //    ViewData["minDate"] = dataInicial.Value.ToString("yyyy-MM-dd");
        //    ViewData["maxDate"] = dataFinal.Value.ToString("yyyy-MM-dd");
        //    var result = _servicoDeRegistroDeVenda.EncontrarPorDataAsync(dataInicial, dataFinal);
        //    return View(result);

        //    }




        public IActionResult BuscaDeGrupo()
        {
            return View();
        }
    }
}
