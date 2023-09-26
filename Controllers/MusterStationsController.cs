using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShip.Models;
using System.Data.Entity;
using MyShip.ModelsView;

namespace MyShip.Controllers
{
    public class MusterStationsController : Controller
    {

        private ApplicationDbContext _context; 



        public MusterStationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(int selection = 1)
        {
            
            var number = selection;

            //SORT With ENTITY
            var crew = _context.CrewMembers.Where(c=>c.Cabin!=null).Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Where((c) => c.MusterStationId == number).OrderBy(c => c.Cabin.Number).ToList();
            var musterStationNames = _context.MusterStations.ToList();


            var viewModel = new FireStationsViewModel()
            {
                Crew = crew,
                MusterStations = musterStationNames
            };
            if (User.IsInRole(RolesModel.AdminRole))
                return View("AdminIndex", viewModel);
            return View("CrewIndex", viewModel);
        }
    }
}