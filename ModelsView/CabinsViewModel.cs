using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyShip.Models;

namespace MyShip.ModelsView
{
    public class CabinsViewModel
    {
      
        public IDictionary<Cabin, CrewMember> CabinDictionary { get; set; }
        
        
        public int Selection { get; set; }

    }
}