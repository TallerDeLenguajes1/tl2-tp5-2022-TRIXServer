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
    public class PedidoController : Controller
    {
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Database.Pedidos);

        }

        public IActionResult Alta()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Alta(AltaPedidoViewModel dataPedido)
        {
            Database.Pedidos.Add(new PedidoViewModel(Database.Id_pedido, dataPedido.Observaciones, 1, dataPedido.Nombre, dataPedido.Telefono, dataPedido.Direccion, dataPedido.Referencia));
            Database.Id_pedido++;
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int dataId)
        {
            var elPedido = Database.Pedidos.Find(search => search.Id_pedido == dataId);
            return View(new EditPedidoViewModel(dataId, elPedido.ElCliente.Nombre, elPedido.ElCliente.Telefono, elPedido.ElCliente.Direccion, elPedido.ElCliente.Referencia, elPedido.Observaciones));

        }

        [HttpPost]
        public IActionResult Edit(EditPedidoViewModel dataPedido)
        {
            if (ModelState.IsValid)
            {
                var elPedido = Database.Pedidos.Find(search => search.Id_pedido == dataPedido.Id_pedido);
                elPedido.ElCliente.Nombre = dataPedido.Nombre;
                elPedido.ElCliente.Telefono = dataPedido.Telefono;
                elPedido.ElCliente.Direccion = dataPedido.Direccion;
                elPedido.ElCliente.Referencia = dataPedido.Referencia;
                elPedido.Observaciones = dataPedido.Observaciones;

                return RedirectToAction("Index");

            }
            else
            {
                return RedirectToAction("Error");

            }

        }

        public IActionResult Baja(int dataId)
        {
            var elPedido = Database.Pedidos.Find(search => search.Id_pedido == dataId);
            Database.Pedidos.Remove(elPedido);

            return RedirectToAction("Index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}