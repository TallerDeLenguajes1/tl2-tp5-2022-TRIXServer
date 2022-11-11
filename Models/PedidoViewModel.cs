using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class PedidoViewModel
    {
        public int Id_pedido { get; set;}
        public string Observaciones { get; set; } 
        public string Estado { get; set;}
        public Cliente ElCliente { get; set; }

        public PedidoViewModel()
        {

        }

        public PedidoViewModel(int dataId_pedido, string dataObservaciones, int dataEstado, string dataNombre, string dataTelefono, string dataDireccion, string dataReferencia)
        {
            this.Id_pedido = dataId_pedido;
            this.Observaciones = dataObservaciones;
            this.Estado = Convert.ToString((status)dataEstado);
            this.ElCliente = new(dataId_pedido, dataNombre, dataTelefono, dataDireccion, dataReferencia);

        }

    }

    public class AltaPedidoViewModel
    {
        [Required]
        [DisplayName("Nombre: ")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Telefono: ")]
        public string Telefono { get; set; }
        
    }
}