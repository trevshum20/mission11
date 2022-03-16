﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore1.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }


    }
}
