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
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [MaxLength(80)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Clave { get; set; }
        [Required]
        public int cantidades { get; set; }
        [Required]
        public int idEstado { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required]
        public virtual ICollection<Estado> Estados
        { get; set; }
        public virtual ICollection<Empleado> Empleado
        { get; set; }
        public virtual ICollection<Rol> Rols
        { get; set; }
        [Required]
        public int IdRegistro { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
