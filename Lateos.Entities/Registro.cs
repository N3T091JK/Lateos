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
    public class Registro
    {
        [Key]
        public int IdRegistro { get; set; }
        [MaxLength(80)]
        [Required]
        public string Nombre { get; set; }

        public int IdCompraProducto { get; set; }
        [Required]
        public virtual ICollection<CompraProducto> CompraProductos { get; set; }
        public int IdUsuario { get; set; }
        [Required]
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public int IdFactura { get; set; }
        [Required]
        public virtual ICollection<Facturas> Facturas { get; set; }

    }
}
