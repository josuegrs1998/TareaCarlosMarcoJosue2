using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaCarlosMarcoJosue2.Models;

namespace TareaCarlosMarcoJosue2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        List<PersonCLS> listPerson = null;
        public ActionResult PersonView()
        {
            using (var bd = new ModelAdventureW20162())
            {
                listPerson = (from P in bd.VistaPersonas
                              select new PersonCLS 
                              {
                                  Titulo = P.Titulo,
                                  NombreCompleto = P.NombreCompleto,
                                  Correo = P.Correo,
                                  PhoneNumber = P.PhoneNumber,
                                  City = P.City,
                                  AddressLine1 = P.AddressLine1,
                                  Name = P.Name

                              }).Take(20).ToList();
            }


            return View(listPerson);
        }
    }
}