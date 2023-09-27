//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using System;

namespace Customer.DataHandler.Models.Users.Exceptions
{
    internal class NullUserException : Exception
    {
        public NullUserException()
            : base(message: "User is null")
        { }
    }
}
