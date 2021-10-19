// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Account
{
    /// <summary> The PurviewAccountCollections service client. </summary>
    public partial class PurviewAccountCollections
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _collectionName;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewAccountCollections for mocking. </summary>
        protected PurviewAccountCollections()
        {
        }

        /// <summary> Initializes a new instance of PurviewAccountCollections. </summary>
        /// <param name="clientDiagnostics"> The ClientDiagnostics instance to use. </param>
        /// <param name="pipeline"> The pipeline instance to use. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The account endpoint of your Purview account. Example: https://{accountName}.purview.azure.com/account/. </param>
        /// <param name="collectionName"> The String to use. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/>, <paramref name="collectionName"/>, or <paramref name="apiVersion"/> is null. </exception>
        internal PurviewAccountCollections(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string collectionName, string apiVersion = "2019-11-01-preview")
        {
            if (clientDiagnostics == null)
            {
                throw new ArgumentNullException(nameof(clientDiagnostics));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (collectionName == null)
            {
                throw new ArgumentNullException(nameof(collectionName));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _collectionName = collectionName;
            _apiVersion = apiVersion;
        }

        /// <summary> Get a collection. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetCollectionAsync(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.GetCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCollectionRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a collection. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetCollection(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.GetCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCollectionRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a collection entity. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateCollectionAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.CreateOrUpdateCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateCollectionRequest(content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a collection entity. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   collectionProvisioningState: &quot;Unknown&quot; | &quot;Creating&quot; | &quot;Moving&quot; | &quot;Deleting&quot; | &quot;Failed&quot; | &quot;Succeeded&quot;,
        ///   description: string,
        ///   friendlyName: string,
        ///   name: string,
        ///   parentCollection: {
        ///     referenceName: string,
        ///     type: string
        ///   },
        ///   systemData: {
        ///     createdAt: string (ISO 8601 Format),
        ///     createdBy: string,
        ///     createdByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;,
        ///     lastModifiedAt: string (ISO 8601 Format),
        ///     lastModifiedBy: string,
        ///     lastModifiedByType: &quot;User&quot; | &quot;Application&quot; | &quot;ManagedIdentity&quot; | &quot;Key&quot;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdateCollection(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.CreateOrUpdateCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateCollectionRequest(content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Collection entity. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteCollectionAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.DeleteCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteCollectionRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a Collection entity. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response DeleteCollection(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.DeleteCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteCollectionRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the parent name and parent friendly name chains that represent the collection path. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   parentFriendlyNameChain: [string],
        ///   parentNameChain: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetCollectionPathAsync(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.GetCollectionPath");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCollectionPathRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the parent name and parent friendly name chains that represent the collection path. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   parentFriendlyNameChain: [string],
        ///   parentNameChain: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetCollectionPath(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewAccountCollections.GetCollectionPath");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCollectionPathRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the child collections names in the collection. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="skipToken"> The String to use. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   count: number,
        ///   nextLink: string,
        ///   value: [
        ///     {
        ///       friendlyName: string,
        ///       name: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetChildCollectionNamesAsync(RequestOptions options, string skipToken = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "PurviewAccountCollections.GetChildCollectionNames");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetChildCollectionNamesRequest(skipToken)
                        : CreateGetChildCollectionNamesNextPageRequest(nextLink, skipToken);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, options, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Lists the child collections names in the collection. </summary>
        /// <param name="options"> The request options. </param>
        /// <param name="skipToken"> The String to use. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   count: number,
        ///   nextLink: string,
        ///   value: [
        ///     {
        ///       friendlyName: string,
        ///       name: string
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetChildCollectionNames(RequestOptions options, string skipToken = null)
#pragma warning restore AZC0002
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "PurviewAccountCollections.GetChildCollectionNames");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetChildCollectionNamesRequest(skipToken)
                        : CreateGetChildCollectionNamesNextPageRequest(nextLink, skipToken);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, options, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetCollectionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(_collectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateCollectionRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(_collectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteCollectionRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(_collectionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier204.Instance;
            return message;
        }

        internal HttpMessage CreateGetChildCollectionNamesRequest(string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(_collectionName, true);
            uri.AppendPath("/getChildCollectionNames", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetCollectionPathRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(_collectionName, true);
            uri.AppendPath("/getCollectionPath", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetChildCollectionNamesNextPageRequest(string nextLink, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    204 => false,
                    _ => true
                };
            }
        }
    }
}
