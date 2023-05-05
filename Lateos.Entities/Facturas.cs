using Lateos.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lateos.Entities
{
    public class Facturas
    {
        [Key]
        public int IdFactura { get; set; }
       
        
        [Required]

        public Decimal MontoPago { get; set; }
        [Required]
        public Decimal MontoTotal { get; set; }
        [Required]
        public Decimal Descuento { get; set; }
        [Required]
        public string Observacion { get; set; }
        
        public DateTime FechaRegistro { get; set; }
        
        public int IdCliente { get; set; }
        [Required]
        public int IdUsuario { get; set; }

           [Required]
        public virtual Cliente Clientes
        { get; set; }
        public virtual Usuario Usuarios
        { get; set; }

    }
}
