﻿using System.Reflection;

namespace DataGg.Core.Extensions;

public static class PropertyInfoExtensions
{
    public static double? GetValueAsDouble(this PropertyInfo pi, object obj)
    {
        var asDouble = pi.GetValue(obj) is double ? 
            (double?)pi.GetValue(obj) : 
            null;
        if (asDouble.HasValue)
        {
            return asDouble;
        }

        long? asLong = pi.GetValue(obj) is long ? (long?)pi.GetValue(obj) : null;

        return asLong;
    }
}