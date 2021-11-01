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
    public class VendedoresController : Controller
    {

        public readonly VendedorServico _vendedorServico;

        public readonly DepartmentService _departmentService;

        public VendedoresController(VendedorServico vendedorServico, DepartmentService departmentService)
        {
            _vendedorServico = vendedorServico;
            _departmentService = departmentService;
        }



        public async Task<IActionResult> Index()
        {
            var list = await _vendedorServico.FindAllAsync();

            
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _departmentService.FindAllAsync();
            var viewModel = new SellerFormViewModel { Departamentos = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {

                var departaments =await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Vendedor = vendedor, Departamentos = departaments };
                return View(viewModel);
            }

           await _vendedorServico.InsertAsync(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete (int? id)

        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _vendedorServico.EncontrarPeloIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });

            }
            //   return RedirectToAction(nameof(Index));

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int id)
        {
          await  _vendedorServico.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            {
                if (id == null)
                {
                    return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
                }

                var obj =await _vendedorServico.EncontrarPeloIdAsync(id.Value);
                if (obj == null)
                {
                    return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });

                }
               //  return RedirectToAction(nameof(Index));
               return View(obj);

            }


        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido" });
            }

            var obj = await _vendedorServico.EncontrarPeloIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado" });
            }
            List<Departamento> departamentos = await _departmentService.FindAllAsync();
            SellerFormViewModel viewModel = new SellerFormViewModel { Vendedor = obj, Departamentos = departamentos };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> Edit(int id, Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {

                var departaments =await _departmentService.FindAllAsync();
                var viewModel = new SellerFormViewModel { Vendedor = vendedor, Departamentos = departaments };
                return View(viewModel);
            }
            if (id != vendedor.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Ids não casam" });
            }

            try
            {
               await _vendedorServico.AtualizarAsync(vendedor);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundExceptions e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        public IActionResult Error(string message)
            {
                var viewModel = new ErrorViewModel
                {
                    Message = message,
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                };
                return View(viewModel);
            }
        }
    }

