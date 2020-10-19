using System;
using System.ComponentModel.DataAnnotations;

namespace Practica1.Models
{
    public class Formulario
    {
        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Distrito")]
        public String District { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Banco")]
        public  String Bank { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Edad")]
        public  int Age { get; set; }

        [Required(ErrorMessage="Campo Obligatorio")]
        [Display(Name="Genero")]
        public String Gender { get; set; }

        public String Respuesta { get; set; }



    }
}
