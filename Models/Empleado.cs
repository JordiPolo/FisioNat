using System;
using System.ComponentModel.DataAnnotations;

namespace Raist.Models
{
    public class Empleado
    {
        [Key]
        public Guid UUID{get; set;}

        [Required,MaxLength(30,ErrorMessage = "La longitud maxima de {0} es de {1} caracteres")]
        public string nombre {get; set;}

        [Required,MaxLength(30,ErrorMessage = "La longitud maxima de {0} es de {1} caracteres")]
        public string apellido1 {get; set;}

        [Required,MaxLength(30,ErrorMessage = "La longitud maxima de {0} es de {1} caracteres")]
        public string apellido2 {get; set;}
    }
}