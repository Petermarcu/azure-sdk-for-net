// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    internal static class DiskEncryptionTargetExtensions
    {
        public static string ToSerialString(this DiskEncryptionTarget value) => value switch
        {
            DiskEncryptionTarget.OsDisk => "osdisk",
            DiskEncryptionTarget.TemporaryDisk => "temporarydisk",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskEncryptionTarget value.")
        };

        public static DiskEncryptionTarget ToDiskEncryptionTarget(this string value)
        {
            if (string.Equals(value, "osdisk", StringComparison.InvariantCultureIgnoreCase)) return DiskEncryptionTarget.OsDisk;
            if (string.Equals(value, "temporarydisk", StringComparison.InvariantCultureIgnoreCase)) return DiskEncryptionTarget.TemporaryDisk;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskEncryptionTarget value.");
        }
    }
}
