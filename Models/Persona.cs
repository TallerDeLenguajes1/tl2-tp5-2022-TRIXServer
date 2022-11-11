using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Persona
    {
        private int id_persona;
        private string nombre;
        private string telefono;
        private string direccion;

        public Persona()
        {

        }

        public Persona(int dataId_persona, string dataNombre, string dataTelefono, string dataDireccion)
        {
            this.id_persona = dataId_persona;
            this.nombre = dataNombre;
            this.telefono = dataTelefono;
            this.direccion = dataDireccion;
            
        }

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }

}