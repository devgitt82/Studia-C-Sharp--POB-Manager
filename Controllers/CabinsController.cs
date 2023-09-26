using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MyShip.Models;
using MyShip.ModelsView;

namespace MyShip.Controllers
{
    public class CabinsController : Controller
    {

        private ApplicationDbContext _context;



        public CabinsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(int selection = 1)
        {
            SortedDictionary<Cabin, CrewMember> slownik = new SortedDictionary<Cabin, CrewMember>();
            if (selection == 1)
            {
                IEnumerable<CrewMember> crew;
                crew = _context.CrewMembers.Where(c=>c.Cabin!=null).Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                    .OrderBy(c => c.Cabin.Number).ToList();
                IEnumerable<Cabin> cabins;
                cabins = _context.Cabins.Include(c=> c.Lifeboat).ToList();

                slownik = new SortedDictionary<Cabin, CrewMember>(crew.ToDictionary(c => c.Cabin));
                foreach (var cabin in cabins)
                {

                    if (!slownik.ContainsKey(cabin))
                        slownik.Add(cabin, new CrewMember());
                }
            }
            else if (selection == 2)
            {
                IEnumerable<CrewMember> crew;
                crew = _context.CrewMembers.Where(c => c.CabinId != null).Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                    .OrderBy(c => c.Cabin.Number).ToList();
                slownik = new SortedDictionary<Cabin, CrewMember>(crew.ToDictionary(c => c.Cabin));
            }
            else
            {
                IEnumerable<CrewMember> crew;
                crew = _context.CrewMembers.Where(c => c.CabinId != null).Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                   .OrderBy(c => c.Cabin.Number).ToList();
                IEnumerable<Cabin> cabins;
                cabins = _context.Cabins.Include(c => c.Lifeboat).ToList();

                slownik = new SortedDictionary<Cabin, CrewMember>(crew.ToDictionary(c => c.Cabin));
                foreach (var cabin in cabins)
                {

                    if (slownik.ContainsKey(cabin))
                        slownik.Remove(cabin);
                    else
                    {
                        slownik.Add(cabin, new CrewMember());
                    }
                }
            }
            var viewModel = new CabinsViewModel()
            {
                CabinDictionary = slownik,
                Selection = selection

            };
            if (User.IsInRole(RolesModel.AdminRole))
                return View("AdminIndex", viewModel);
            return View("CrewIndex", viewModel);
        }

        public ActionResult Details(int selection = 1)
        {
            var crew = _context.CrewMembers.Where(c=>c.CabinId!=null).Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                .OrderBy(c => c.Cabin.Number).ToList();
            var dict = crew.ToDictionary(c => c.CabinId);
            if (!dict.ContainsKey((short)selection))
            {

                var temp = _context.Cabins.Where(c => c.Id == selection).Include(c=>c.Lifeboat).ToList()[0];
                if (User.IsInRole(RolesModel.AdminRole))
                    return View("AdminDetails", new CrewMember { CabinId = (short)selection, Cabin = temp });
                return View("Details", new CrewMember { CabinId = (short)selection, Cabin = temp });
            }
            else
            {
                var crewMember = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                    .Where(c => c.CabinId == selection).ToList()[0];

                if (User.IsInRole(RolesModel.AdminRole))
                    return View("AdminDetails", crewMember);
                return View("Details", crewMember);
            }
        }
    }
}