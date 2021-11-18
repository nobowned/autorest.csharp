// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of MgmtGrpParentWithNonResChWithLoc and their operations over its parent. </summary>
    public partial class MgmtGrpParentWithNonResChWithLocCollection : ArmCollection, IEnumerable<MgmtGrpParentWithNonResChWithLoc>, IAsyncEnumerable<MgmtGrpParentWithNonResChWithLoc>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MgmtGrpParentWithNonResChWithLocsRestOperations _mgmtGrpParentWithNonResChWithLocsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of MgmtGrpParentWithNonResChWithLocCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MgmtGrpParentWithNonResChWithLocCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _mgmtGrpParentWithNonResChWithLocsRestClient = new MgmtGrpParentWithNonResChWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagementGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual MgmtGrpParentWithNonResChWithLocCreateOrUpdateOperation CreateOrUpdate(string mgmtGrpParentWithNonResChWithLocName, MgmtGrpParentWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChWithLocsRestClient.CreateOrUpdate(Id.Name, mgmtGrpParentWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new MgmtGrpParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MgmtGrpParentWithNonResChWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(string mgmtGrpParentWithNonResChWithLocName, MgmtGrpParentWithNonResChWithLocData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChWithLocsRestClient.CreateOrUpdateAsync(Id.Name, mgmtGrpParentWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtGrpParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> Get(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChWithLocsRestClient.Get(Id.Name, mgmtGrpParentWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs/{mgmtGrpParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> GetAsync(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChWithLocsRestClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChWithLoc> GetIfExists(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChWithLocsRestClient.Get(Id.Name, mgmtGrpParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<MgmtGrpParentWithNonResChWithLoc>> GetIfExistsAsync(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChWithLocsRestClient.GetAsync(Id.Name, mgmtGrpParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MgmtGrpParentWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGrpParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(mgmtGrpParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGrpParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string mgmtGrpParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (mgmtGrpParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGrpParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(mgmtGrpParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGrpParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MgmtGrpParentWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MgmtGrpParentWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChWithLocsRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MgmtGrpParentWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChWithLocsRestClient.ListNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChWithLocs
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGrpParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGrpParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MgmtGrpParentWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MgmtGrpParentWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChWithLocsRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MgmtGrpParentWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGrpParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChWithLocsRestClient.ListNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGrpParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<MgmtGrpParentWithNonResChWithLoc> IEnumerable<MgmtGrpParentWithNonResChWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MgmtGrpParentWithNonResChWithLoc> IAsyncEnumerable<MgmtGrpParentWithNonResChWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, MgmtGrpParentWithNonResChWithLoc, MgmtGrpParentWithNonResChWithLocData> Construct() { }
    }
}