using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using MyShip.Models;
using MyShip.ModelsView;
using System.IO;

namespace MyShip.Controllers
{


    public class CrewMemberController : Controller
    {

        private ApplicationDbContext _context;



        public CrewMemberController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(int selection = 1)
        {

            var crewMember = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Include(c => c.LastCabin)
                .Where(c => c.Id == selection).ToList()[0];
            return View(crewMember);
        }


        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult New()
        {

            var emptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();

            var listaNumerow = new List<string>();
            foreach (var cabin in emptyCabins)
            {
                listaNumerow.Add(cabin.Number.ToString() + " " + cabin.Bunk);
            }

            var cabinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
            var bunks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
            var musterStations = _context.MusterStations.ToList();
            var lifeboats = _context.Lifeboats.ToList();


            CrewMemberViewModel viewModel = new CrewMemberViewModel
            {

                CabinNumbers = cabinNumbers,
                Bunks = bunks,
                MusterStations = musterStations,
                Lifeboats = lifeboats

            };

            return View(viewModel);
        }


        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult Save(CrewMemberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var crewMember = _context.CrewMembers.Include((c) => c.Cabin.Lifeboat).Include(c => c.MusterStation).Include(c => c.LastCabin)
                        .Where(c => c.Id == model.CrewMember.Id).ToList()[0];

                var emptyCabinsPlusOne = new List<Cabin>();
                emptyCabinsPlusOne.Add(crewMember.Cabin);

                var emptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();
                emptyCabinsPlusOne.AddRange(emptyCabins);

                var listaNumerow = new List<string>();
                foreach (var cab in emptyCabinsPlusOne)
                {
                    listaNumerow.Add(cab.Number.ToString() + " " + cab.Bunk);
                }

                var cabinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
                var bunks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
                var musterStations = _context.MusterStations.ToList();
                var lifeboats = _context.Lifeboats.ToList();
                CrewMemberViewModel viewModel = new CrewMemberViewModel
                {
                    CabinNumbers = cabinNumbers,
                    Bunks = bunks,
                    MusterStations = musterStations,
                    Lifeboats = lifeboats,
                    CrewMember = crewMember
                };


                return View("Edit", viewModel);
            }
            var temp = model.selection.Split(' ');
            var cabNumber = short.Parse(temp[0]);
            var bunk = temp[1];
            var cabin = _context.Cabins.Where(c => c.Bunk == bunk && c.Number == cabNumber).ToList()[0];
            


            if (model.CrewMember.IsOnBoard == true)
                
            {
                
                if (model.CrewMember.CabinId != model.CrewMember.LastCabinId)
                {
                    var oldcab = _context.CrewMembers.Include(c => c.Cabin).Where(c => c.Id == model.CrewMember.Id).ToList()[0].Cabin;
                    oldcab.IsEmpty = true;
                    _context.Cabins.AddOrUpdate(oldcab);
                    _context.SaveChanges();
                }

                model.CrewMember.Cabin = cabin;
                model.CrewMember.CabinId = cabin.Id;
                model.CrewMember.Cabin.IsEmpty = false;
                model.CrewMember.LastCabin = cabin;
                model.CrewMember.LastCabinId = cabin.Id;
            }
            else
            {
                cabin.IsEmpty = true;
                _context.Cabins.AddOrUpdate(cabin);
                _context.SaveChanges();
                model.CrewMember.Cabin = null;
                model.CrewMember.CabinId = null;
                model.CrewMember.LastCabin = cabin;
                model.CrewMember.LastCabinId = cabin.Id;
                

            }
            _context.CrewMembers.AddOrUpdate(model.CrewMember);
            _context.SaveChanges();
            var id = model.CrewMember.Id;
            return RedirectToAction("Index", "CrewMember", new
            {
                selection = id
            });
        }

        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult SignOn(CrewMemberViewModel model)
        {

            var Member = _context.CrewMembers.Include(c => c.MusterStation).Include(c => c.LastCabin)
                .Where(c => c.Id == model.CrewMember.Id).ToList()[0];
            Member.IsOnBoard = true;

            var mptyCabinsPlusOne = new List<Cabin>();

            var mptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();
            mptyCabinsPlusOne.AddRange(mptyCabins);

            var listaNumerow = new List<string>();
            foreach (var cab in mptyCabinsPlusOne)
            {
                listaNumerow.Add(cab.Number.ToString() + " " + cab.Bunk);
            }

            var abinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
            var unks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
            var usterStations = _context.MusterStations.ToList();
            var ifeboats = _context.Lifeboats.ToList();
            CrewMemberViewModel viewMode = new CrewMemberViewModel
            {
                CabinNumbers = abinNumbers,
                Bunks = unks,
                MusterStations = usterStations,
                Lifeboats = ifeboats,
                CrewMember = Member
            };


            return View("Edit", viewMode);
        }
        public ActionResult SignOff(CrewMemberViewModel model)
        {

            var Member = _context.CrewMembers.Include(c => c.MusterStation).Include(c => c.LastCabin)
                .Where(c => c.Id == model.CrewMember.Id).ToList()[0];
            Member.IsOnBoard = false;


            var cabin = _context.CrewMembers.Include(c => c.Cabin).Where(c => c.Id == model.CrewMember.Id).ToList()[0].Cabin;
            cabin.IsEmpty = true;
            _context.Cabins.AddOrUpdate(cabin);
            _context.SaveChanges();

            Member.Cabin = null;
            Member.CabinId = null;
            Member.LastCabin = cabin;
            Member.LastCabinId = cabin.Id;
            Member.DisembarkDate = DateTime.Today;

            _context.CrewMembers.AddOrUpdate(Member);
            _context.SaveChanges();


            var mptyCabinsPlusOne = new List<Cabin>();

            var mptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();
            mptyCabinsPlusOne.AddRange(mptyCabins);

            var listaNumerow = new List<string>();
            foreach (var cab in mptyCabinsPlusOne)
            {
                listaNumerow.Add(cab.Number.ToString() + " " + cab.Bunk);
            }

            var abinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
            var unks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
            var usterStations = _context.MusterStations.ToList();
            var ifeboats = _context.Lifeboats.ToList();
            CrewMemberViewModel viewMode = new CrewMemberViewModel
            {
                CabinNumbers = abinNumbers,
                Bunks = unks,
                MusterStations = usterStations,
                Lifeboats = ifeboats,
                CrewMember = Member
            };


            return View("Edit", viewMode);
        }

        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult Add(CrewMemberViewModel model)
        {
            if (!ModelState.IsValid)
            {

                var emptyCabinsPlusOne = new List<Cabin>();
                var emptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();
                emptyCabinsPlusOne.AddRange(emptyCabins);

                var listaNumerow = new List<string>();
                foreach (var cab in emptyCabinsPlusOne)
                {
                    listaNumerow.Add(cab.Number.ToString() + " " + cab.Bunk);
                }

                var cabinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
                var bunks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
                var musterStations = _context.MusterStations.ToList();
                var lifeboats = _context.Lifeboats.ToList();
                CrewMemberViewModel viewModel = new CrewMemberViewModel
                {
                    CabinNumbers = cabinNumbers,
                    Bunks = bunks,
                    MusterStations = musterStations,
                    Lifeboats = lifeboats,
                    CrewMember = model.CrewMember

                };
                if (model.selection != null)
                {
                    viewModel.selection = model.selection;
                }

                return View("New", viewModel);
            }
            var temp = model.selection.Split(' ');
            var cabNumber = short.Parse(temp[0]);
            var bunk = temp[1];
            var cabin = _context.Cabins.Where(c => c.Bunk == bunk && c.Number == cabNumber).ToList()[0];


            model.CrewMember.Cabin = cabin;
            model.CrewMember.CabinId = cabin.Id;
            model.CrewMember.IsOnBoard = true;
            model.CrewMember.LastCabin = cabin;
            model.CrewMember.LastCabinId = cabin.Id;
            model.CrewMember.JoinDate = DateTime.Today;
            model.CrewMember.DisembarkDate = DateTime.Now.Date;



            _context.CrewMembers.AddOrUpdate(model.CrewMember);
            _context.SaveChanges();
            var id = _context.CrewMembers.Where(c => c.CabinId == model.CrewMember.CabinId).ToList()[0].Id;
            return RedirectToAction("Index", "CrewMember", new
            {
                selection = id
            });
        }

        [Authorize(Roles = RolesModel.AdminRole)]

        public ActionResult Edit(short selection = 1)
        {
            var crewMember = _context.CrewMembers.Include(c => c.MusterStation).Include(c => c.LastCabin)
                .Where(c => c.Id == selection).ToList()[0];
            if (crewMember.CabinId != null)
            {
                crewMember = _context.CrewMembers.Include((c) => c.Cabin).Include(c => c.MusterStation).Include(c => c.LastCabin)
                    .Where(c => c.Id == selection).ToList()[0];
            };
            var emptyCabinsPlusOne = new List<Cabin>();
            if (crewMember.CabinId != null)
                emptyCabinsPlusOne.Add(crewMember.Cabin);
            var emptyCabins = _context.Cabins.Where(c => c.IsEmpty == true).ToList();
            emptyCabinsPlusOne.AddRange(emptyCabins);

            var listaNumerow = new List<string>();
            foreach (var cabin in emptyCabinsPlusOne)
            {
                listaNumerow.Add(cabin.Number.ToString() + " " + cabin.Bunk);
            }

            var cabinNumbers = _context.Cabins.Select(c => c.Number).Distinct().ToList();
            var bunks = listaNumerow; //new List<string> {"A", "B", "C", "D"};
            var musterStations = _context.MusterStations.ToList();
            var lifeboats = _context.Lifeboats.ToList();

            CrewMemberViewModel viewModel = new CrewMemberViewModel
            {
                CabinNumbers = cabinNumbers,
                Bunks = bunks,
                MusterStations = musterStations,
                Lifeboats = lifeboats,
                CrewMember = crewMember

            };
            return View("Edit", viewModel);
        }

        public ActionResult Remove(CrewMemberViewModel model)
        {
            var theOne = _context.CrewMembers.Single(c => c.Id == model.CrewMember.Id);
            _context.CrewMembers.Remove(theOne);
            _context.SaveChanges();
            return RedirectToAction("Index", "CrewList");
        }

        [HttpGet]
        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = RolesModel.AdminRole)]
        public ActionResult UploadFile(HttpPostedFileBase file, short id)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string path = Path.Combine(Server.MapPath("/UploadedFiles"), id.ToString());
                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                    }

                    if (file.ContentType == "image/jpeg" || file.ContentType == "application/pdf")
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(path, _FileName);
                        file.SaveAs(_path);
                        Certificate cert = new Certificate();
                        cert.CrewMemberId = id;
                        cert.CoCPath = _FileName;

                        _context.Certificates.AddOrUpdate(cert);
                        _context.SaveChanges();
                    }

                    ViewBag.Message = "File Uploaded Successfully!!";
                }

                return RedirectToAction("Index", "Certificate", new { id = id });
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }
    }
}