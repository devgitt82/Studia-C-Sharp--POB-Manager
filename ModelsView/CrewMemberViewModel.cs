using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyShip.Models;

namespace MyShip.ModelsView
{
    public class CrewMemberViewModel
    {
        public CrewMember CrewMember { get; set; }
        
        public IEnumerable<String> Bunks { get; set; }
       
        public IEnumerable<short> CabinNumbers { get; set; }
        
        public IEnumerable<MusterStation> MusterStations { get; set; }
       
        public IEnumerable<Lifeboat> Lifeboats { get; set; }

        



        [Display(Name = "Cabin Number")]
        public string selection { get; set; }

    }
}