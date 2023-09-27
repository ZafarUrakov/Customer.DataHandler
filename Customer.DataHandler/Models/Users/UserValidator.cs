//=================================
// Copyright (c) Sofee LLC.
// Powering True Leadership
//===============================

using FluentValidation;

namespace Customer.DataHandler.Models.Users
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(client => client.Id).NotEmpty().WithMessage("Id - Id is required");
            RuleFor(client => client.Firstname).NotEmpty().WithMessage("Firstname - Text is required");
            RuleFor(client => client.Lastname).NotEmpty().WithMessage("Lastname - Text is required");
            RuleFor(client => client.BirthDate).NotEmpty().WithMessage("BirthDate - Date is required");
            RuleFor(client => client.Email).NotEmpty().WithMessage("Email - Text is required").EmailAddress().WithMessage("Email - Email is invalid");
        }
    }
}
