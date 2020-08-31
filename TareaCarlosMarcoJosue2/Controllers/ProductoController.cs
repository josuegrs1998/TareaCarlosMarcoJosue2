using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaCarlosMarcoJosue2.Models;

namespace TareaCarlosMarcoJosue2.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Person
        List<ProductoCLS> listProducto = null;
        public ActionResult ProductoView()
        {
            using (var bd = new AdventureWorks2016Entities1())
            {
                listProducto = (from P in bd.VistaProducto
                              select new ProductoCLS 
                              {
                                  Producto = P.Producto,
                                  NumeroDeProducto = P.NumeroDeProducto,
                                  Color = P.Color,
                                  SubCategoria = P.SubCategoria,
                                  Categoria = P.Categoria,
                                  Cantidad = (int)P.Cantidad,
                                  Description = P.Description

                              }).Take(20).ToList();
            }


            return View(listProducto);
        }
    }
}