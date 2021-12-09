// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region SBSubscription
        /// <summary> Gets an object representing a SBSubscriptionCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SBSubscriptionCollection" /> object. </returns>
        public static SBSubscriptionCollection GetSBSubscriptions(this ResourceGroup resourceGroup)
        {
            return new SBSubscriptionCollection(resourceGroup);
        }
        #endregion
    }
}