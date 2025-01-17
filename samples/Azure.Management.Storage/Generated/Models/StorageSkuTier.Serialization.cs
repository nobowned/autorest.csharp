// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    internal static partial class StorageSkuTierExtensions
    {
        public static string ToSerialString(this StorageSkuTier value) => value switch
        {
            StorageSkuTier.Standard => "Standard",
            StorageSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageSkuTier value.")
        };

        public static StorageSkuTier ToStorageSkuTier(this string value)
        {
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return StorageSkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return StorageSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StorageSkuTier value.");
        }
    }
}
