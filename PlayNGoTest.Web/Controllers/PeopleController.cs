using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayNGoTest.Web.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            // We could have injected the context but since this is a simple app I'm going for the most simple solution first
            var context = new CodingExamSampleDbEntities();
            var people = context.People.ToList();

            var viewmodel = new PlayNGoTest.Web.Models.PeopleListViewModel
            {
                People = people
            };

            return View(viewmodel);
        }
    }
}
