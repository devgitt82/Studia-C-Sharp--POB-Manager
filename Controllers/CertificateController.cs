using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShip.Models;
using MyShip.ModelsView;

namespace MyShip.Controllers
{
    public class CertificateController : Controller
    {
        private ApplicationDbContext _context;
        public CertificateController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Certificate
        public ActionResult Index(short id = 1)
        {
            var crewCert = _context.Certificates
                .Where(c => c.CrewMemberId == id).ToList();
            var crewmember = _context.CrewMembers.Single(c => c.Id == id);
            var model = new CertificatesViewModel()
            {
                CrewId = id,
                certsList = crewCert,
                crewmember = crewmember

            };
            return View(model);
        }
        public ActionResult GetCert(string cert, short id)
        {

            var temp = cert.Split('.');            
            var suffix = temp.Last();           
            if (suffix.Equals("pdf"))
            {
                var dir2 = Server.MapPath("/UploadedFiles/" + id.ToString());
                var path2 = Path.Combine(dir2, cert);
                return base.File(path2, "application/pdf");
            }

            if (suffix.Equals("jpg"))
            {
                var dir = Server.MapPath("/UploadedFiles/" + id.ToString());
                var path = Path.Combine(dir, cert);
                return base.File(path, "image/jpeg");
            }
            else
                return RedirectToAction("Index", "Certificate", new { id = id });
        }
        public ActionResult RemoveCert(string cert, short id)
        {
            string dir = Path.Combine(Server.MapPath("/UploadedFiles"), id.ToString());
            var theOne = _context.Certificates.Single(c => c.CrewMemberId == id && c.CoCPath == cert);
            _context.Certificates.Remove(theOne);
            _context.SaveChanges();
            var path = Path.Combine(dir, cert);
            System.IO.File.Delete(path);
            var crewCert = _context.Certificates
                .Where(c => c.CrewMemberId == id).ToList();
            if (crewCert.Count == 0)
            {
                Directory.Delete(dir);
            }
            return RedirectToAction("Index", "Certificate", new { id = id });
        }
    }
}