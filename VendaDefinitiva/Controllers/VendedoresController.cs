using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Models;
using VendaDefinitiva.Services;
using VendaDefinitiva.Models.ViewModels;
using VendaDefinitiva.Services.Exceptions;

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

        public IActionResult Delete (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorServico.EncontrarPeloId(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete (int id)
        {
            _vendedorServico.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorServico.EncontrarPeloId(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);


        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _vendedorServico.EncontrarPeloId(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            List<Departamento> departamentos = _departmentService.FindAll();
            SellerFormViewModel viewModel = new SellerFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel); 
                }
        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit (int id, Vendedor vendedor)
        {
            if(id != vendedor.Id)
            {
                return BadRequest();
            }

            try
            {
                _vendedorServico.Atualizar(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundExceptions)
            {
                return NotFound();
            }

            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
