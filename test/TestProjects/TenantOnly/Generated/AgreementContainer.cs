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
    /// <summary> A class representing collection of Agreement and their operations over a BillingAccount. </summary>
    public partial class AgreementContainer : ResourceContainerBase<TenantResourceIdentifier, Agreement, AgreementData>
    {
        /// <summary> Initializes a new instance of the <see cref="AgreementContainer"/> class for mocking. </summary>
        protected AgreementContainer()
        {
        }

        /// <summary> Initializes a new instance of AgreementContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AgreementContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private AgreementsRestOperations _restClient => new AgreementsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => BillingAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<Agreement> Get(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementContainer.Get");
            scope.Start();
            try
            {
                if (agreementName == null)
                {
                    throw new ArgumentNullException(nameof(agreementName));
                }

                var response = _restClient.Get(Id.Name, agreementName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new Agreement(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<Agreement>> GetAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementContainer.Get");
            scope.Start();
            try
            {
                if (agreementName == null)
                {
                    throw new ArgumentNullException(nameof(agreementName));
                }

                var response = await _restClient.GetAsync(Id.Name, agreementName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Agreement(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of Agreement for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AgreementOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of Agreement for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AgreementContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AgreementOperations.ResourceType);
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
        // public ArmBuilder<TenantResourceIdentifier, Agreement, AgreementData> Construct() { }
    }
}
