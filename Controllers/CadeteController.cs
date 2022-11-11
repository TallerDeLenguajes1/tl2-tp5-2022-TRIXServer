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

        public IActionResult Edit(int dataId)
        {
            var elCadete = Database.Cadetes.Find(search => search.Id_persona == dataId);
            return View(new EditCadeteViewModel(dataId, elCadete.Nombre, elCadete.Telefono, elCadete.Direccion));

        }
        
        [HttpPost]
        public IActionResult Edit(EditCadeteViewModel dataCadete)
        {
            if (ModelState.IsValid)
            {
                var elCadete = Database.Cadetes.Find(search => search.Id_persona == dataCadete.Id_persona);
                elCadete.Nombre = dataCadete.Nombre;
                elCadete.Telefono = dataCadete.Telefono;
                elCadete.Direccion = dataCadete.Direccion;

                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Error");

            }

        }

        public IActionResult Baja(int dataId)
        {
            var elCadete = Database.Cadetes.Find(search => search.Id_persona == dataId);
            Database.Cadetes.Remove(elCadete);

            return RedirectToAction("Index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}