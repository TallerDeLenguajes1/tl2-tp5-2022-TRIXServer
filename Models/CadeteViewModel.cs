using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace tl2_tp5_2022_TRIXServer.Models
{
    public class CadeteViewModel : Persona
    {
        public List<Pedido> Pedidos { get; set; }

        public CadeteViewModel() : base()
        {

        }

        public CadeteViewModel(int dataId, string dataNombre, string dataTelefono, string dataDireccion) : base(dataId, dataNombre, dataTelefono, dataDireccion)
        {
            this.Id_persona = dataId;
            this.Nombre = dataNombre;
            this.Telefono = dataTelefono;
            this.Direccion = dataDireccion;
            this.Pedidos = new List<Pedido>();
            
        }
        
    }

    public class AltaCadeteViewModel
    {
        [Required]
        [DisplayName("Nombre: ")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Telefono: ")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Direccion: ")]
        public string Direccion { get; set; }

    }

    public class EditCadeteViewModel
    {
        [Required]
        [NotNull]
        public int Id_persona { get; set; }

        [Required]
        [DisplayName("Nombre: ")]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Telefono: ")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(40)]
        [DisplayName("Direccion: ")]
        public string Direccion { get; set; }

        public EditCadeteViewModel()
        {

        }  

        public EditCadeteViewModel(int dataId, string dataNombre, string dataTelefono, string dataDireccion)
        {
            this.Id_persona = dataId;
            this.Nombre = dataNombre;
            this.Telefono = dataTelefono;
            this.Direccion = dataDireccion;

        }

    }

}