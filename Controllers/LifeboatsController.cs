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
    public class LifeboatsController : Controller
    {
        
        
        private ApplicationDbContext _context;




        public LifeboatsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

       
        public ActionResult Index(int selection=1)
        {
            var number = selection;

           //SORT With ENTITY
           var crew = _context.CrewMembers.Include
                ((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Where((c) =>c.Cabin.Lifeboat.Number==number).OrderBy(c =>c.Cabin.Number).ToList();
           var lifeboatNumbers = _context.Lifeboats.ToList();


           var viewModel = new LifeboatViewModel
           {
               Crew = crew,
               Lifeboats = lifeboatNumbers
           };

           if (User.IsInRole(RolesModel.AdminRole))
               return View("AdminIndex", viewModel);
           return View("Index", viewModel);
         
        }
        

        /*SORT WITH ICOMPARER
         *
         *  public ActionResult Index(byte number=1)
            {
            /*var byLifeboat = new CrewmemberComparer();
            var crew = _context.CrewMembers.Include
                ((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Where(c =>c.Cabin.Lifeboat.Number==number).ToList();
            crew.Sort(byLifeboat);
            return View(crew);
        */


    }

    /*MY OWN COMPARER 
     public class CrewmemberComparer : IComparer<CrewMember>
    {
        public int Compare(CrewMember x, CrewMember y)
        {
            return x.Cabin.Lifeboat.Number.CompareTo(y.Cabin.Lifeboat.Number);

        }
    }
    */
}