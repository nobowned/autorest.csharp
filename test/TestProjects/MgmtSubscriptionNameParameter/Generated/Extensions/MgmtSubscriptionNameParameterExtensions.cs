// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A class to add extension methods to MgmtSubscriptionNameParameter. </summary>
    public static partial class MgmtSubscriptionNameParameterExtensions
    {
        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of SBSubscriptionResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SBSubscriptionResources and their operations over a SBSubscriptionResource. </returns>
        public static SBSubscriptionCollection GetSBSubscriptions(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetSBSubscriptions();
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public static async Task<Response<SBSubscriptionResource>> GetSBSubscriptionAsync(this ResourceGroupResource resourceGroupResource, string subscriptionName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetSBSubscriptions().GetAsync(subscriptionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public static Response<SBSubscriptionResource> GetSBSubscription(this ResourceGroupResource resourceGroupResource, string subscriptionName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetSBSubscriptions().Get(subscriptionName, cancellationToken);
        }

        #region SBSubscriptionResource
        /// <summary>
        /// Gets an object representing a <see cref="SBSubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SBSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="SBSubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBSubscriptionResource" /> object. </returns>
        public static SBSubscriptionResource GetSBSubscriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SBSubscriptionResource.ValidateResourceId(id);
                return new SBSubscriptionResource(client, id);
            }
            );
        }
        #endregion
    }
}