// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a BlobContainer along with the instance operations that can be performed on it. </summary>
    public partial class BlobContainer : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BlobContainer"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BlobContainersRestOperations _blobContainersRestClient;
        private readonly BlobContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="BlobContainer"/> class for mocking. </summary>
        protected BlobContainer()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BlobContainer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal BlobContainer(ArmResource options, BlobContainerData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _blobContainersRestClient = new BlobContainersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="BlobContainer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BlobContainer(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _blobContainersRestClient = new BlobContainersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="BlobContainer"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BlobContainer(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _blobContainersRestClient = new BlobContainersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/blobServices/containers";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BlobContainerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Get
        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobContainer>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Get");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Get
        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobContainer> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Get");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Delete
        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BlobContainerDeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Delete");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BlobContainerDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Delete
        /// <summary> Deletes specified container under its account. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BlobContainerDeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Delete");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                var operation = new BlobContainerDeleteOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Update
        /// <summary> Updates container properties as specified in request body. Properties not mentioned in the request will be unchanged. Update fails if the specified container doesn&apos;t already exist. </summary>
        /// <param name="blobContainer"> Properties to update for the blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainer"/> is null. </exception>
        public async virtual Task<Response<BlobContainer>> UpdateAsync(BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Update");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, blobContainer, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Update
        /// <summary> Updates container properties as specified in request body. Properties not mentioned in the request will be unchanged. Update fails if the specified container doesn&apos;t already exist. </summary>
        /// <param name="blobContainer"> Properties to update for the blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blobContainer"/> is null. </exception>
        public virtual Response<BlobContainer> Update(BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Update");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, blobContainer, cancellationToken);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/setLegalHold
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_SetLegalHold
        /// <summary> Sets legal hold tags. Setting the same tag results in an idempotent operation. SetLegalHold follows an append pattern and does not clear out the existing tags that are not specified in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be set to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public async virtual Task<Response<LegalHold>> SetLegalHoldAsync(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.SetLegalHold");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.SetLegalHoldAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, legalHold, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/setLegalHold
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_SetLegalHold
        /// <summary> Sets legal hold tags. Setting the same tag results in an idempotent operation. SetLegalHold follows an append pattern and does not clear out the existing tags that are not specified in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be set to a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual Response<LegalHold> SetLegalHold(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.SetLegalHold");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.SetLegalHold(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, legalHold, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/clearLegalHold
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_ClearLegalHold
        /// <summary> Clears legal hold tags. Clearing the same or non-existent tag results in an idempotent operation. ClearLegalHold clears out only the specified tags in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be clear from a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public async virtual Task<Response<LegalHold>> ClearLegalHoldAsync(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.ClearLegalHold");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.ClearLegalHoldAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, legalHold, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/clearLegalHold
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_ClearLegalHold
        /// <summary> Clears legal hold tags. Clearing the same or non-existent tag results in an idempotent operation. ClearLegalHold clears out only the specified tags in the request. </summary>
        /// <param name="legalHold"> The LegalHold property that will be clear from a blob container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="legalHold"/> is null. </exception>
        public virtual Response<LegalHold> ClearLegalHold(LegalHold legalHold, CancellationToken cancellationToken = default)
        {
            if (legalHold == null)
            {
                throw new ArgumentNullException(nameof(legalHold));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainer.ClearLegalHold");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.ClearLegalHold(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, legalHold, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Lease
        /// <summary> The Lease Container operation establishes and manages a lock on a container for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Container request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LeaseContainerResponse>> LeaseAsync(LeaseContainerRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Lease");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.LeaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_Lease
        /// <summary> The Lease Container operation establishes and manages a lock on a container for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="parameters"> Lease Container request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LeaseContainerResponse> Lease(LeaseContainerRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.Lease");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Lease(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/migrate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_ObjectLevelWorm
        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<BlobContainerObjectLevelWormOperation> ObjectLevelWormAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.ObjectLevelWorm");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.ObjectLevelWormAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BlobContainerObjectLevelWormOperation(_clientDiagnostics, Pipeline, _blobContainersRestClient.CreateObjectLevelWormRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}/migrate
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// OperationId: BlobContainers_ObjectLevelWorm
        /// <summary> This operation migrates a blob container from container level WORM to object level immutability enabled container. Prerequisites require a container level immutability policy either in locked or unlocked state, Account level versioning must be enabled and there should be no Legal hold on the container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual BlobContainerObjectLevelWormOperation ObjectLevelWorm(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainer.ObjectLevelWorm");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.ObjectLevelWorm(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                var operation = new BlobContainerObjectLevelWormOperation(_clientDiagnostics, Pipeline, _blobContainersRestClient.CreateObjectLevelWormRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name).Request, response);
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

        #region ImmutabilityPolicy

        /// <summary> Gets an object representing a ImmutabilityPolicy along with the instance operations that can be performed on it in the BlobContainer. </summary>
        /// <returns> Returns a <see cref="ImmutabilityPolicy" /> object. </returns>
        public ImmutabilityPolicy GetImmutabilityPolicy()
        {
            return new ImmutabilityPolicy(this, new ResourceIdentifier(Id.ToString() + "/immutabilityPolicies/default"));
        }
        #endregion
    }
}
