using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyShip.Models;

namespace MyShip.ModelsView
{
    public class CrewListViewModel
    {
        public IEnumerable<CrewMember> Crew { get; set; }
        [Display(Name = "Sort Order")]
       
        
        public CrewMember CrewMember { get; set; }
       
        
        public int Selection { get; set; }
    }
}