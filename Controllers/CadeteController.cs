using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tl2_tp5_2022_TRIXServer.Models;

namespace tl2_tp5_2022_TRIXServer.Controllers
{
    //[Route("[controller]")]
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;

        public CadeteController(ILogger<CadeteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Database.Cadetes);

        }

        public IActionResult Alta()
        {
            return View();

        }
        
        [HttpPost]
        public IActionResult Alta(AltaCadeteViewModel dataCadete)
        {
            if (ModelState.IsValid)
            {
                Database.Cadetes.Add(new CadeteViewModel(Database.Id_cadete, dataCadete.Nombre, dataCadete.Telefono, dataCadete.Direccion));
                Database.Id_cadete++;
                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Error");

            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}