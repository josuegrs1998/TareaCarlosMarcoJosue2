using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TareaCarlosMarcoJosue2.Models
{
    public class ProductoCLS
    {
        [Display(Name = "Producto")]
        public string Producto { get; set; }

        [Display(Name = "Numero De Producto")]
        public string NumeroDeProducto { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        [Display(Name = "SubCategoria")]
        public string SubCategoria { get; set; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "Cantidad ")]
        public int Cantidad { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}