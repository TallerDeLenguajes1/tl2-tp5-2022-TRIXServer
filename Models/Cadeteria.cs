using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> cadetes;

        public Cadeteria()
        {
            var random = new Random();

            string fileCadeterias = "cadeterias.csv";
            var readFile = File.ReadAllLines(fileCadeterias);
            int randomCadeteria = random.Next(readFile.Length);
            var selectCadeteria = (readFile[randomCadeteria]).Split(", ");

            this.nombre = selectCadeteria[0];
            this.telefono = selectCadeteria[1];
            this.cadetes = new List<Cadete>();

        }

        public Cadeteria(string dataNombre, string dataTelefono)
        {
            this.nombre = dataNombre;
            this.telefono = dataTelefono;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

    }

    public class DBCadeteria
    {
        private Cadeteria laCadeteria;
        private List<Pedido> pedidosSinAsignar;

        public DBCadeteria()
        {
            this.laCadeteria = new Cadeteria();
            this.pedidosSinAsignar = new List<Pedido>();

        }

        public Cadeteria LaCadeteria { get => laCadeteria; set => laCadeteria = value; }
        public List<Pedido> PedidosSinAsignar { get => pedidosSinAsignar; set => pedidosSinAsignar = value; }

    }

    public class CadeteriaUniversal
    {
        private static DBCadeteria dataBase = new DBCadeteria();

        private CadeteriaUniversal()
        {

        }

        public static DBCadeteria instancia
        {
            get { return dataBase; }
        }
    }

}