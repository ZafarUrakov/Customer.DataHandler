//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using System;
using System.ComponentModel.DataAnnotations;

namespace Customer.DataHandler.Models.Users
{
    internal class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Firstname - Text is required")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname - Text is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "BirthDate - Date is required")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "PhoneNumber - Text is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email - Text is required")]
        [EmailAddress(ErrorMessage = "Email - Email is invalid")]
        public string Email { get; set; }
    }
}
