// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using AdditionalPropertiesEx.Models;
using Azure;
using Azure.Core.Pipeline;

namespace AdditionalPropertiesEx
{
    /// <summary> The AP service client. </summary>
    public partial class APClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal APRestClient RestClient { get; }

        /// <summary> Initializes a new instance of APClient for mocking. </summary>
        protected APClient()
        {
        }

        /// <summary> Initializes a new instance of APClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal APClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new APRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> WriteOnlyAsync(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.WriteOnly");
            scope.Start();
            try
            {
                return await RestClient.WriteOnlyAsync(createParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response WriteOnly(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.WriteOnly");
            scope.Start();
            try
            {
                return RestClient.WriteOnly(createParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OutputAdditionalPropertiesModel>> ReadOnlyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.ReadOnly");
            scope.Start();
            try
            {
                return await RestClient.ReadOnlyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutputAdditionalPropertiesModel> ReadOnly(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.ReadOnly");
            scope.Start();
            try
            {
                return RestClient.ReadOnly(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> WriteOnlyStructAsync(InputAdditionalPropertiesModelStruct createParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.WriteOnlyStruct");
            scope.Start();
            try
            {
                return await RestClient.WriteOnlyStructAsync(createParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response WriteOnlyStruct(InputAdditionalPropertiesModelStruct createParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.WriteOnlyStruct");
            scope.Start();
            try
            {
                return RestClient.WriteOnlyStruct(createParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OutputAdditionalPropertiesModelStruct>> ReadOnlyStructAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.ReadOnlyStruct");
            scope.Start();
            try
            {
                return await RestClient.ReadOnlyStructAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutputAdditionalPropertiesModelStruct> ReadOnlyStruct(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("APClient.ReadOnlyStruct");
            scope.Start();
            try
            {
                return RestClient.ReadOnlyStruct(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
