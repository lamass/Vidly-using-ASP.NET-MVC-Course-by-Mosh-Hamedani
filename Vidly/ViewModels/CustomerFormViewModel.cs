using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {

        public CustomerFormViewModel()
        {
            // setting Id = 0 populates the hidden Id field in CustomerForm
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            BirthDate = customer.BirthDate;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            MembershipTypeId = customer.MembershipTypeId;
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        // navigation property, allows navigation from one type to another 'customer -> MembershipType'
        // navigation properties are useful for loading an object and its related objects together form the database.

        public MembershipType MembershipType { get; set; }
        // navigation properties (matching class) foreign key
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Customer" : "New Customer";
            }
        }
    }
}
