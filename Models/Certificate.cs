using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShip.Models
{
    public class Certificate
    {
        [Required] public int Id { get; set; }

        public short CrewMemberId { get; set; }

        [DisplayName("CoC File")] 
        public string CoCPath { get; set; }






    }

}
