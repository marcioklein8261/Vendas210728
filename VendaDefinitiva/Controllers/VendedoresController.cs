using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Models;
using VendaDefinitiva.Services;
using VendaDefinitiva.Models.ViewModels;

namespace VendaDefinitiva.Controllers
{
    public class VendedoresController : Controller
    {

        public readonly VendedorServico _vendedorServico;

        public readonly DepartmentService _departmentService;

        public VendedoresController(VendedorServico vendedorServico, DepartmentService departmentService)
        {
            _vendedorServico = vendedorServico;
            _departmentService = departmentService;
        }



        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();

            
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departamentos = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorServico.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
