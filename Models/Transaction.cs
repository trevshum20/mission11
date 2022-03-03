using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStore1.Models
{
    public class Transaction
    {
        [Key]
        [BindNever]
        public int TransactionId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }


        [Required(ErrorMessage = "Please enter a first name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the shipping address:")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please enter your credit card number:")]
        public string CreditCardNumber { get; set; }
        [Required(ErrorMessage = "Please enter your credit card security code:")]
        public string SecurityCode { get; set; }

        [Required(ErrorMessage = "Please enter a city name:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state:")]
        public string State { get; set; }


        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter a country:")]
        public string Country { get; set; }
    }
}
