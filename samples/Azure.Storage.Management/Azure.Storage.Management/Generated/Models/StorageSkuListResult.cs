// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Storage.Management.Models
{
    /// <summary> The response from the List Storage SKUs operation. </summary>
    public partial class StorageSkuListResult
    {
        /// <summary> Get the list result of storage SKUs and their properties. </summary>
        public ICollection<SkuInformation> Value { get; internal set; }
    }
}