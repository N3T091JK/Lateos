using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Lateos.Entities;  

namespace Lateos.Entities
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        
        [Required]
        public string Roles { get; set; }
        [Required]
        public int IdRegistro { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
