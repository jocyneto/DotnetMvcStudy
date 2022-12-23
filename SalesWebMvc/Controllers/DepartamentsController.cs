using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> listDep = new List<Departament>();
            listDep.Add(new Departament { Id = 1, Name = "Sports"});
            listDep.Add(new Departament { Id = 2, Name = "Eletronics"});

            return View(listDep);
        }


    }
}
