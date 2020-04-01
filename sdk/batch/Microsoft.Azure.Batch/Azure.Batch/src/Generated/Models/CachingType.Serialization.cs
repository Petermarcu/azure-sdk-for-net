// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class CachingTypeExtensions
    {
        public static string ToSerialString(this CachingType value) => value switch
        {
            CachingType.None => "none",
            CachingType.ReadOnly => "readonly",
            CachingType.ReadWrite => "readwrite",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CachingType value.")
        };

        public static CachingType ToCachingType(this string value)
        {
            if (string.Equals(value, "none", StringComparison.InvariantCultureIgnoreCase)) return CachingType.None;
            if (string.Equals(value, "readonly", StringComparison.InvariantCultureIgnoreCase)) return CachingType.ReadOnly;
            if (string.Equals(value, "readwrite", StringComparison.InvariantCultureIgnoreCase)) return CachingType.ReadWrite;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CachingType value.");
        }
    }
}
