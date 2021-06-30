// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace TenantOnly
{
    /// <summary> A class representing collection of BillingAccount and their operations over a Tenant. </summary>
    public partial class BillingAccountContainer : ResourceContainerBase<TenantResourceIdentifier, BillingAccount, BillingAccountData>
    {
        /// <summary> Initializes a new instance of the <see cref="BillingAccountContainer"/> class for mocking. </summary>
        protected BillingAccountContainer()
        {
        }

        /// <summary> Initializes a new instance of BillingAccountContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BillingAccountContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BillingAccountsRestOperations _restClient => new BillingAccountsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a BillingAccount. Please note some properties can be set only during creation. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<BillingAccount> CreateOrUpdate(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(billingAccountName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BillingAccount. Please note some properties can be set only during creation. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<BillingAccount>> CreateOrUpdateAsync(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(billingAccountName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BillingAccount. Please note some properties can be set only during creation. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public BillingAccountsUpdateOperation StartCreateOrUpdate(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Update(billingAccountName, parameters, cancellationToken: cancellationToken);
                return new BillingAccountsUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(billingAccountName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a BillingAccount. Please note some properties can be set only during creation. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<BillingAccountsUpdateOperation> StartCreateOrUpdateAsync(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.UpdateAsync(billingAccountName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new BillingAccountsUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(billingAccountName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<BillingAccount> Get(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.Get");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = _restClient.Get(billingAccountName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<BillingAccount>> GetAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.Get");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = await _restClient.GetAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of BillingAccount for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BillingAccountOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of BillingAccount for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BillingAccountOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<TenantResourceIdentifier, BillingAccount, BillingAccountData> Construct() { }
    }
}
