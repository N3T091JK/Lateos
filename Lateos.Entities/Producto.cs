using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using Lateos.Entities;

namespace Lateos.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [MaxLength(80)]
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Decripcion { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public DateTime FechaCaducidad { get; set; }
        [Required]

        public int IdCategoria { get; set; }
        [Required]
        public int IdEstado { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Category Categorys { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual DetalleCompra DetalleCompras { get; set; }
      
    }
}
