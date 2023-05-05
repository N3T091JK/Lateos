using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lateos.Entities;


namespace Lateos.Entities
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

     
        public virtual ICollection<Category> Categorys { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Rol> Rols { get; set; }
    }
}
