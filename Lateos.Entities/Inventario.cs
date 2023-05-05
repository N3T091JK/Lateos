using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lateos.Entities
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
