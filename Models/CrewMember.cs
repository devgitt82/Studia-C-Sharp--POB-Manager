using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShip.Models
{
    public class CrewMember
    {
        [Required]
        public short Id { get; set; }
        

        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        

        [Required]
        [StringLength(255)]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Display(Name = "Cabin")]
        public Cabin Cabin { get; set; }
        

        public short? CabinId { get; set; }
        
        public MusterStation MusterStation { get; set; }


        [Display(Name = "Fire Station")] 
        public byte MusterStationId { get; set; }


        [Required]
        [Display(Name = "On Board")]
        public bool IsOnBoard { get; set; }


        [Required]
        [StringLength(255)]
        [Display(Name = "Passport No.")]
        public string PassportNo { get; set; }

        
        [StringLength(255)]
        [Display(Name = "Seamans Book No.")]
        public string SeamansBookNo { get; set; }

        
        [Display(Name = "Date Joined")]
        public DateTime JoinDate { get; set; }

        
        [Display(Name = "Date Disembarked")]
        public DateTime DisembarkDate { get; set; }

        [Display(Name = "Last Cabin")]
        public Cabin LastCabin { get; set; }

        [Display(Name = "Last Cabin")]
        public short? LastCabinId { get; set; }

       


    }
}