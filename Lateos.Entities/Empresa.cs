using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Lateos.Entities
{
    public class Empresa
    {
        [Key]
        public int IdEmprresa { get; set; }
        [MaxLength(80)]
        [Required]
        public string NombreComercial { get; set; }
        [Required]
        public string NombreLegal { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Rubro { get; set; }
        [Required]
        public int IdRegistro { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }
}
