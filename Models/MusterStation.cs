using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShip.Models
{
    public class MusterStation
    {

        public byte Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Location { get; set; }    

    }
}