using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class Cliente : Persona
    {
        private string referencia;

        public string Referencia { get => referencia; set => referencia = value; }

        public Cliente() : base()
        {

        }

        public Cliente(int dataId, string dataNombre, string dataTelefono, string dataDireccion, string dataReferencia) : base(dataId, dataNombre, dataTelefono, dataDireccion)
        {
            this.referencia = dataReferencia;

        }

    }
    
}