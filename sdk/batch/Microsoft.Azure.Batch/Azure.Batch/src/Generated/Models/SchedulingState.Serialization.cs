// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class SchedulingStateExtensions
    {
        public static string ToSerialString(this SchedulingState value) => value switch
        {
            SchedulingState.Enabled => "enabled",
            SchedulingState.Disabled => "disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SchedulingState value.")
        };

        public static SchedulingState ToSchedulingState(this string value)
        {
            if (string.Equals(value, "enabled", StringComparison.InvariantCultureIgnoreCase)) return SchedulingState.Enabled;
            if (string.Equals(value, "disabled", StringComparison.InvariantCultureIgnoreCase)) return SchedulingState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SchedulingState value.");
        }
    }
}
