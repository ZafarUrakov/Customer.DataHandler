//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using Customer.DataHandler.Brokers.Storages;
using Customer.DataHandler.Models.Users;
using Customer.DataHandler.Models.Users.Exceptions;
using FluentValidation;
using System.Threading.Tasks;

namespace Customer.DataHandler.Services
{
    internal partial class UserService
    {
        private readonly AppDbContext _dbContext;
        private readonly IValidator<User> _userValidator;

        internal UserService(AppDbContext dbContext, IValidator<User> userValidator)
        {
            _dbContext = dbContext;
            _userValidator = userValidator;
        }
        /// <exception cref="NullUserException"></exception>
        /// <exception cref="InvalidUserException"></exception>
        internal Task<User> AddUserAsync(User user)
        {
            if (user is null)
                throw new NullUserException();

            var validationResult = _userValidator.Validate(user);

            if(!validationResult.IsValid)
            {
                throw  new InvalidUserException();
            }

            return this._dbContext.InsertUserAsync(user);
        }
    }
}
