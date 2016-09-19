using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display (Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        // navigation property, allows navigation from one type to another 'customer -> MembershipType'
        // navigation properties are useful for loading an object and its related objects together form the database.
      
        public MembershipType MembershipType { get; set; }
        // navigation properties (matching class) foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}