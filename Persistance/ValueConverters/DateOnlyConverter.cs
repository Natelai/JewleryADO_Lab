﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.ValueConverters
{
    internal sealed class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
            d => d.ToDateTime(TimeOnly.MinValue),
            d => DateOnly.FromDateTime(d))
        { 
        }
    }
}
