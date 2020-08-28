using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaCarlosMarcoJosue2.Models;

namespace TareaCarlosMarcoJosue2.Controllers
{
    public class RecursosHumanosController : Controller
    {
        List<RecursosHumanosCLS> listaRecursosHumanos = null;

        // GET: RecursosHumanos
        public ActionResult RecursosHumanosView()
        {
            using (var bd = new ModelAdventureW20162())
            {
                listaRecursosHumanos = (from U in bd.VistaRecursosHumanos
                                        select new RecursosHumanosCLS
                                        {
                                            PrimerNombre = U.PrimerNombre,
                                            SegundoNombre = U.SegundoNombre,
                                            Apellidos = U.Apellidos,
                                            Genero = U.Genero,
                                            FechaContratacion = U.FechaContratacion,
                                            Departamento = U.Departmento,
                                            GrupoDepartamento = U.GrupoDepartamento,
                                            Turno = U.Turno,
                                            TipoSalario = U.TipoSalario,
                                            TasaSalario = U.TasaSalario,
                                            FrecuenciaSalario = U.FrecuenciaSalario
                                        }).Take(20).ToList();
            }
            return View(listaRecursosHumanos);
        }
    }
}