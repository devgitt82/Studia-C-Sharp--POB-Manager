using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyShip.Models;

namespace MyShip.ModelsView
{
    public class CertificatesViewModel
    {
        public List<Certificate>  certsList{ get; set; }
        public short CrewId{ get; set; }

        public CrewMember crewmember{ get; set; }
        
    }
}