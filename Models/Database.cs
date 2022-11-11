using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Database
    {
        static public int id_cadete = InitId();
        static public int id_pedido = InitId();
        static public List<Cadete> cadetes = InitCadete();
        static public List<Pedido> pedidos = InitPedido();

        public Database()
        {
            
        }

        static private int InitId()
        {
            return (1);

        }

        static private List<Cadete> InitCadete()
        {
            List<Cadete> cadete = new();
            return cadete;

        }

        static private List<Pedido> InitPedido()
        {
            List<Pedido> pedido = new();
            return pedido;
            
        }

    }
}