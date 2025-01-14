using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Raist.Models
{
    public class Usuario
    {
        [Key]
        public Guid UUID { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int codigoPin { get; set; }
        public List<Alergia> alergias { get; set; }
    }
}
