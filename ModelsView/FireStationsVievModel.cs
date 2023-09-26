using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyShip.Models;

namespace MyShip.ModelsView
{
    public class FireStationsViewModel
    {
       
        public IEnumerable<MusterStation> MusterStations{ get; set; }
        
        public IEnumerable<CrewMember> Crew { get; set; }
        
        public CrewMember CrewMember { get; set; }
        
        public int Selection { get; set; }
    }
}