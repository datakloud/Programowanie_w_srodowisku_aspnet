using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Customer : IdentityUser
    {
        [Required(ErrorMessage = "Please provide customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool HasNewsletterSubscribed { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name="Membership Type")]
        [Required(ErrorMessage = "Please provide Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}