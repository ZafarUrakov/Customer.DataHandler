//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using System;

namespace Customer.DataHandler.Models.Users.Exceptions
{
    internal class InvalidUserException : Exception
    {
        public InvalidUserException()
            : base(message: "Client is invalide. Fix the errors and try again.")
        { }
    }
}
