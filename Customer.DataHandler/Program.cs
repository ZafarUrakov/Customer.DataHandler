//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using Customer.DataHandler.Brokers.Storages;
using Customer.DataHandler.Models.Users;
using Customer.DataHandler.Services;
using System;
using System.Threading.Tasks;

namespace Sofee.Prosurer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();
            var userService = new UserService(context, new UserValidator());

            var user = new User
            {
                Id = new Guid(),
                Firstname = "Joh",
                Lastname = "Doe",
                BirthDate = new DateTime(2020, 5, 15),
                Email = "johndoeexample.com"
            };

            var validator = new UserValidator();
            var validationResult = validator.Validate(user);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            await userService.AddUserAsync(user);
        }
    }
}