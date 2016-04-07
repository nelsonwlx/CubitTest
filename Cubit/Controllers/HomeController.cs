using Cubit.Data.People;
using Cubit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cubit.Controllers
{
    public class HomeController : Controller
    {

        private const int RecordsPerPage = 50;

        private static PeopleManager _PeopleManager;
        
        public ActionResult Index(PeopleManager peopleManager)
        {
            _PeopleManager = peopleManager;

            // Get and pass Races for selection
            var races = GetRaceList();
            ViewBag.Races = races;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetPeopleList(int raceId, int pages)
        {
            var topN = pages * RecordsPerPage;

            var peopleList = _PeopleManager.GetSelectedPeople((PeopleFactory.Races)raceId, topN);

            var peopleListView = PartialView("_PeopleList", peopleList);

            return peopleListView;
        }

        private IEnumerable<SelectListItem> GetRaceList()
        {
            var dict = new Dictionary<int, string>();
            
            foreach(PeopleFactory.Races e in Enum.GetValues(typeof(PeopleFactory.Races)))
            {
                var value = (int)e;
                var name = e.ToString();
                dict.Add(value, name);
            }

            return dict.Select(x => new SelectListItem() { Value = x.Key.ToString(), Text = x.Value });
        }
    }
}