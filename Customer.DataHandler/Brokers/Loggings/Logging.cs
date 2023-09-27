using System;

namespace Customer.DataHandler.Data.Loggings
{
    internal class Logging
    {
        internal void LoggingError(Exception exception) =>
            Console.WriteLine(exception.Message);
    }
}
