using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace MyShip.Models
{
    public class Cabin:IComparable
    {

        
        [Required]
        public short Id { get; set; }
        

        [Required]
        [Display(Name = "Cabin Number")]
        public short Number { get; set; }
        

        [Required]
        [Display(Name = "Cabin Bunk")]
        public string Bunk { get; set; }
        

        public Lifeboat Lifeboat { get; set; }
        

        [Display(Name = "Lifeboat Number")]
        public byte LifeboatId { get; set; }

        [Required]
        public bool IsEmpty { get; set; }


        public int CompareTo(object obj)
        {
            if (((Cabin) obj).Id > this.Id)
                return -1;
            else
                return 1;
           
            
        }
    }
}