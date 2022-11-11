using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Pedido
    {
        private int id_pedido;
        private string observaciones;
        private status estado;
        private Cliente elCliente;

        public Pedido()
        {
            this.id_pedido = 0;
            this.observaciones = "";
            this.estado = (status)1;
            this.elCliente = new Cliente();
            
        }

        public Pedido(int id_pedido, string observaciones, int estado, Cliente cliente)
        {
            this.id_pedido = id_pedido;
            this.observaciones = observaciones;
            this.estado = (status)estado;
            this.elCliente = cliente;
            
        }

        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public Cliente ElCliente { get => elCliente; set => elCliente = value; }
        internal status Estado { get => estado; set => estado = value; }

    }

    enum status
    {
        Preparacion = 1,
        Traslado = 2,
        Entregado = 3,

    }
    
}

