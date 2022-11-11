using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Database
    {
        static public int Id_cadete = InitId();
        static public int Id_pedido = InitId();
        static public List<CadeteViewModel> Cadetes = InitCadete();
        static public List<PedidoViewModel> Pedidos = InitPedido();

        public Database()
        {
            
        }

        static private int InitId()
        {
            return (1);

        }

        static private List<CadeteViewModel> InitCadete()
        {
            List<CadeteViewModel> cadete = new();
            return cadete;

        }

        static private List<PedidoViewModel> InitPedido()
        {
            List<PedidoViewModel> pedido = new();
            return pedido;
            
        }

    }
}