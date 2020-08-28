using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TareaCarlosMarcoJosue2.Models
{
    public class PersonCLS
    {
        [Display(Name="Titulo")]
        public string Titulo {get; set;}

        [Display(Name = "Nombre Completo")]
        public string NombreCompleto{get; set;}

        [Display(Name = "Correo")]
        public string Correo{get; set;}

        [Display(Name = "Numero de telefono")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Ciudad")]
        public string City { get; set; }

        [Display(Name = "Direccion ")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Estado")]
        public string Name { get; set; }
    }
}