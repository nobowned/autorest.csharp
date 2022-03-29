// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using MgmtSignalR;

namespace MgmtSignalR.Models
{
    /// <summary> Object that includes an array of resources and a possible link for next set. </summary>
    internal partial class SignalRResourceList
    {
        /// <summary> Initializes a new instance of SignalRResourceList. </summary>
        internal SignalRResourceList()
        {
            Value = new ChangeTrackingList<SignalRResourceData>();
        }

        /// <summary> Initializes a new instance of SignalRResourceList. </summary>
        /// <param name="value"> List of the resources. </param>
        /// <param name="nextLink">
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal SignalRResourceList(IReadOnlyList<SignalRResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of the resources. </summary>
        public IReadOnlyList<SignalRResourceData> Value { get; }
        /// <summary>
        /// The URL the client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}