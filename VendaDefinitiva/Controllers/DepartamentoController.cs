using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendaDefinitiva.Models;

namespace VendaDefinitiva.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletrônicoa" });
            list.Add(new Departamento { Id = 2, Nome = "Informática" });


            return View(list);
        }
    }
}
