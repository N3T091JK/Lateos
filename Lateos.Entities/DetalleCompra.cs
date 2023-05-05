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
    public class DetalleCompra
    {
        [Key]
        public int IdDetalleCompra { get; set; }
        [MaxLength(80)]

        [Required]
        public String CantidadProductos { get; set; }
        public Decimal PrecioUnitario{ get; set; }
        public Decimal Descuento { get; set; }
        public int IdCompraProducto { get; set; }
        public virtual CompraProducto CompraProductos{ get; set; }
        [Required]
        public int IdInventario { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
