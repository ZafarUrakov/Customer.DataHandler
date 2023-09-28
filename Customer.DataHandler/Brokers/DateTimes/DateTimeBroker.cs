//=================================
// Copyright (c) Customer LLC.
// Powering True Leadership
//===============================

using System;

namespace Customer.DataHandler.Brokers.DateTimes
{
    internal class DateTimeBroker
    {
        internal DateTimeOffset GetDataTimeOffset() =>
            DateTimeOffset.UtcNow;
    }
}
