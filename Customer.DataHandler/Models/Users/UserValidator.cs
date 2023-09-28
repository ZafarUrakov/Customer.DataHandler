//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using Customer.DataHandler.Brokers.DateTimes;
using FluentValidation;
using System;

namespace Customer.DataHandler.Models.Users
{
    internal class UserValidator : AbstractValidator<User>
    {
        private readonly DateTimeBroker dateTimeBroker;
        public UserValidator()
        {
            dateTimeBroker = new DateTimeBroker();

            UserValidate();
        }

        private void UserValidate()
        {
            RuleFor(user => user.Id).NotEmpty().WithMessage("Id - Id is required");
            RuleFor(user => user.Firstname).NotEmpty().WithMessage("Firstname - Text is required");
            RuleFor(user => user.Lastname).NotEmpty().WithMessage("Lastname - Text is required");
            RuleFor(user => user.BirthDate).NotEmpty().WithMessage("BirthDate - Date is required");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email - Text is required")
                .EmailAddress().WithMessage("Email - Email is invalid");
            RuleFor(user => user.BirthDate).Must((user, birthDate) =>
            LessThan12(birthDate)).WithMessage("BirthDate - Age must be at least 12 years");
        }

        public bool LessThan12(DateTimeOffset date)
        {
            DateTimeOffset now = this.dateTimeBroker.GetDataTimeOffset();
            int age = (now - date).Days / 365;

            return age > 12;
        }
    }
}
