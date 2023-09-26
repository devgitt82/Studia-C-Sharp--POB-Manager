using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShip.Models
{
    public class Lifeboat
    {

        [Required]
        public byte Id { get; set; }


        [Required]
        public byte Number { get; set; }


        [Required]
        public byte Capacity { get; set; }
    }
}