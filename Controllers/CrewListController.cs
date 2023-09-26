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
    
    public class CrewListController : Controller
    {

        private ApplicationDbContext _context;



        public CrewListController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(int selection = 1)
        {
           
            //SORT With ENTITY
            List<CrewMember> crew = new List<CrewMember>();

            //ALL CREW BY NAME
            if (selection == 0)
            {
                if (User.IsInRole(RolesModel.AdminRole))
                {
                    var homecrew = _context.CrewMembers.Where(c => c.Cabin == null).Include((c) => c.LastCabin)
                        .Include(c => c.MusterStation)
                        .OrderBy(c => c.LastName).ToList();
                    var currentCrew = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat)
                        .Include(c => c.MusterStation).Include(c => c.LastCabin)
                        .OrderBy(c => c.LastName).Where(c => c.IsOnBoard == true).ToList();
                    crew = new List<CrewMember>();
                    crew.AddRange(currentCrew);
                    crew.AddRange(homecrew);
                    crew.Sort(new CrewMemberComparer2());

                }
                else
                {
                    crew = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation)
                        .Include(c => c.LastCabin)
                        .OrderBy(c => c.FirstName).Where(c => c.IsOnBoard == true).ToList();
                }
            }
            //ALL CREW BY CABIN NUMBER
            if (selection == 1)
            {
               
                if (User.IsInRole(RolesModel.AdminRole))
                {
                    var homecrew = _context.CrewMembers.Where(c=>c.Cabin==null).Include((c) => c.LastCabin).Include(c => c.MusterStation)
                        .OrderBy(c => c.LastCabin.Number).ToList();
                    var currentCrew=_context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Include(c => c.LastCabin)
                        .OrderBy(c => c.Cabin.Number).Where(c => c.IsOnBoard == true).ToList();
                    crew = new List<CrewMember>();
                    crew.AddRange(currentCrew);
                    crew.AddRange(homecrew);
                    crew.Sort(new CrewMemberComparer1());
                }
                else
                {
                    crew = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Include(c=> c.LastCabin)
                        .OrderBy(c => c.Cabin.Number).Where(c => c.IsOnBoard == true).ToList();
                }

            }
            //ON BOARD CREW ONLY
            else if (selection == 2)
            {
                if (User.IsInRole(RolesModel.AdminRole))
                {
                    crew = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Include(c=>c.LastCabin)
                        .OrderBy(c => c.LastName).Where(c => c.IsOnBoard == true).ToList();
                }
                else
                {
                    RedirectToAction("Index");
                }
            }
            //SIGNED OFF CREW ONLY
            else if (selection == 3)
            {
                if (User.IsInRole(RolesModel.AdminRole))
                {
                    crew = _context.CrewMembers.Include(c => c.MusterStation).Include(c=>c.LastCabin)
                        .OrderBy(c => c.LastName).Where(c => c.IsOnBoard == false).ToList();
                }
                else
                {
                    RedirectToAction("Index");
                }
            }
            
            var viewModel = new CrewListViewModel()
            {
                Crew = crew,
                Selection =selection

            };
            if (User.IsInRole(RolesModel.AdminRole))
                return View("AdminIndex",viewModel);
            return View("CrewIndex", viewModel);
        }
        
    }
    public class CrewMemberComparer1 : IComparer<CrewMember>
    {
        public int Compare(CrewMember x, CrewMember y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 1;
            }

            if (x.Cabin == null)
            {
                if (y.Cabin != null) 
                     return 1; 
                else
                {
                    if (x.LastCabinId > y.LastCabinId)
                        return 1;
                    else
                        return -1;
                }
            }

            if (y.Cabin == null)
            {
                if (x.Cabin != null)
                    return -1;
                else
                {
                    if (x.LastCabinId > y.LastCabinId)
                        return 1;
                    else
                        return -1;
                }
            }

            if (x.CabinId > y.CabinId)
            {
                return 1;
            }
            else
                return -1;

        }
    }

    public class CrewMemberComparer2 : IComparer<CrewMember>
    {
        public int Compare(CrewMember x, CrewMember y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 1;
            }
            return  string.Compare(x.LastName, y.LastName);
        }
            
       
    }
}