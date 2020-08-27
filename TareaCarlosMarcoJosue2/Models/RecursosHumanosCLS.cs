using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace TareaCarlosMarcoJosue2.Models
{
    public class RecursosHumanosCLS
    {
        [Display(Name = "Primer Nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }

        public string Apellidos { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }
        
        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Display(Name = "Fecha de Contratación")]
        public DateTime FechaContratacion { get; set;}

        public string Departamento { get; set; }
        
        [Display(Name = "Grupo de Departamento")]
        public string GrupoDepartamento { get; set; }

        public string Turno { get; set; }
        
        [Display(Name = "Tipo de Salario")]
        public string TipoSalario {get; set; }

        [Display(Name = "Tasa de Salario")]
        public Decimal TasaSalario { get; set; }

        [Display(Name = "Frecuencia de Salario")]
        public string FrecuenciaSalario { get; set; }

    }
}