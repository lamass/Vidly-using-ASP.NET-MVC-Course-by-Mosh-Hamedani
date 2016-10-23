using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        // navigation property, allows navigation from one type to another 'customer -> MembershipType'
        // navigation properties are useful for loading an object and its related objects together form the database.

        // DELETED MembershipType to decouple DTO from domain model;
        public byte MembershipTypeId { get; set; }
    }
}