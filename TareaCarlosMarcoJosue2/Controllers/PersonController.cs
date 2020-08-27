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
            using (var bd = new AdventureWorks2016Entities())
            {
                listPerson = (from P in bd.Person
                              select new PersonCLS 
                              {
                                  FirstName = P.FirstName,
                                  LastName = P.LastName,
                                  PersonType = P.PersonType

                              }).Take(15).ToList();
            }

       

            return View(listPerson);
        }
    }
}