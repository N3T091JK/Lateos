using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lateos.Entities;
namespace Lateos.Entities
{
    public class DetalleFactura
    {
        [Key]
        public int IdDetalleFactura { get; set; }    
        [Required]
        public int Cantidad { get; set; }     
        public decimal subTotal { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public virtual ICollection<Producto> Productos { get; set; }

        [Required]
        public int IdInventario { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
