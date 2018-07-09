using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            // Error Handling Test
            // Web.config <customErrors mode="RemoteOnly"</customErrors>
            //PersonModel p = new PersonModel();
            //int i = 5 / p.Age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Paul", LastName = "Kazmir", Age = 37 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56 });
            people.Add(new PersonModel { FirstName = "Sarah", LastName = "Connor", Age = 325 });

            return View(people);
        }
    }
}