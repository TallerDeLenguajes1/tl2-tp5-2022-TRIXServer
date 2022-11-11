using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Cadete : Persona
    {
        private List<Pedido> pedidos;

        public Cadete() : base()
        {
            this.pedidos = new List<Pedido>();
            
        }

        public Cadete(int dataId, string dataNombre, string dataTelefono, string dataDireccion) : base(dataId, dataNombre, dataTelefono, dataDireccion)
        {
            this.pedidos = new List<Pedido>();

        }

        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

    }
    
}