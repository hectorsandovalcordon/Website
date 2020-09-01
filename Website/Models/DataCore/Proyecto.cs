using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class Proyecto
    {
        [Key]
        public int id_proyecto { get; set; }
        public string titulo { get; set; }
        public string resumen { get; set; }
        public string link { get; set; }
        public DateTime fecha_fin { get; set; }
        public byte[] imagen { get; set; }
    }
}
