// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class CertificateStateExtensions
    {
        public static string ToSerialString(this CertificateState value) => value switch
        {
            CertificateState.Active => "active",
            CertificateState.Deleting => "deleting",
            CertificateState.DeleteFailed => "deletefailed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateState value.")
        };

        public static CertificateState ToCertificateState(this string value)
        {
            if (string.Equals(value, "active", StringComparison.InvariantCultureIgnoreCase)) return CertificateState.Active;
            if (string.Equals(value, "deleting", StringComparison.InvariantCultureIgnoreCase)) return CertificateState.Deleting;
            if (string.Equals(value, "deletefailed", StringComparison.InvariantCultureIgnoreCase)) return CertificateState.DeleteFailed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CertificateState value.");
        }
    }
}
