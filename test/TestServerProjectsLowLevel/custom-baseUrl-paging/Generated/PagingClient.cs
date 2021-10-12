// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace custom_baseUrl_paging_LowLevel
{
    /// <summary> The Paging service client. </summary>
    public partial class PagingClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly string _host;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of PagingClient for mocking. </summary>
        protected PagingClient()
        {
        }

        /// <summary> Initializes a new instance of PagingClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="host"/> is null. </exception>
        public PagingClient(AzureKeyCredential credential, string host = "host", AutoRestParameterizedHostTestPagingClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            options ??= new AutoRestParameterizedHostTestPagingClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _host = host;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlAsync(string accountName, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "PagingClient.GetPagesPartialUrl");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlRequest(accountName)
                        : CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, options, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetPagesPartialUrl(string accountName, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "PagingClient.GetPagesPartialUrl");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlRequest(accountName)
                        : CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, options, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlOperationAsync(string accountName, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "PagingClient.GetPagesPartialUrlOperation");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlOperationRequest(accountName)
                        : CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, options, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetPagesPartialUrlOperation(string accountName, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "PagingClient.GetPagesPartialUrlOperation");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlOperationRequest(accountName)
                        : CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, options, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlOperationNextAsync(string accountName, string nextLink, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "PagingClient.GetPagesPartialUrlOperationNext");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, options, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> GetPagesPartialUrlOperationNext(string accountName, string nextLink, RequestOptions options)
#pragma warning restore AZC0002
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "PagingClient.GetPagesPartialUrlOperationNext");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, options, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetPagesPartialUrlRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlink", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlinkop", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationNextRequest(string accountName, string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlNextPageRequest(string nextLink, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
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
    }
}
