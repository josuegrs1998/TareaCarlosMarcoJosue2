using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TareaCarlosMarcoJosue2.Models
{
    public class PersonCLS
    {
        [Display(Name="Nombre")]
        public string FirstName {get; set;}

        [Display(Name = "Apellido")]
        public string LastName{get; set;}

        [Display(Name = "Tipo de Persona")]
        public string PersonType{get; set;}
    }
}