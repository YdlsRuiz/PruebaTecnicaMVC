using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMVC.Models
{
    public class Persona
    {
        [Key]
        public String Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20,ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres",MinimumLength = 3)]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "La Fecha de Nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El Pasaporte es obligatorio")]
        public String Pasaporte { get; set; }
        public String Direccion { get; set; }
        public String Sexo { get; set; }
    }
}
