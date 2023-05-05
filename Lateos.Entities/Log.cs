using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lateos.Entities
{
    public class Log
    {
        [Key]
        public int logId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
        [MaxLength(80)]
        [Required]
        public string Usuario { get; set; }

        [MaxLength(80)]
        [Required]
        public string Tabla { get; set; }
        [MaxLength(80)]
        [Required]
        public string Accion { get; set; }
        [MaxLength(200)]
        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int IdRegistro { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }

    }
}