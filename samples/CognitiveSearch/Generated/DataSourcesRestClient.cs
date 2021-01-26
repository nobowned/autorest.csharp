// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CognitiveSearch.Models;

namespace CognitiveSearch
{
    internal partial class DataSourcesRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DataSourcesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataSourcesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-05-06-Preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string dataSourceName, DataSource dataSource, RequestOptions requestOptions, AccessCondition accessCondition)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/datasources('", false);
            uri.AppendPath(dataSourceName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (accessCondition?.IfMatch != null)
            {
                request.Headers.Add("If-Match", accessCondition.IfMatch);
            }
            if (accessCondition?.IfNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", accessCondition.IfNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(dataSource);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new datasource or updates a datasource if it already exists. </summary>
        /// <param name="dataSourceName"> The name of the datasource to create or update. </param>
        /// <param name="dataSource"> The definition of the datasource to create or update. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> or <paramref name="dataSource"/> is null. </exception>
        public async Task<Response<DataSource>> CreateOrUpdateAsync(string dataSourceName, DataSource dataSource, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }

            using var message = CreateCreateOrUpdateRequest(dataSourceName, dataSource, requestOptions, accessCondition);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DataSource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new datasource or updates a datasource if it already exists. </summary>
        /// <param name="dataSourceName"> The name of the datasource to create or update. </param>
        /// <param name="dataSource"> The definition of the datasource to create or update. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> or <paramref name="dataSource"/> is null. </exception>
        public Response<DataSource> CreateOrUpdate(string dataSourceName, DataSource dataSource, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }

            using var message = CreateCreateOrUpdateRequest(dataSourceName, dataSource, requestOptions, accessCondition);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        DataSource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string dataSourceName, RequestOptions requestOptions, AccessCondition accessCondition)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/datasources('", false);
            uri.AppendPath(dataSourceName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (accessCondition?.IfMatch != null)
            {
                request.Headers.Add("If-Match", accessCondition.IfMatch);
            }
            if (accessCondition?.IfNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", accessCondition.IfNoneMatch);
            }
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a datasource. </summary>
        /// <param name="dataSourceName"> The name of the datasource to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string dataSourceName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }

            using var message = CreateDeleteRequest(dataSourceName, requestOptions, accessCondition);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a datasource. </summary>
        /// <param name="dataSourceName"> The name of the datasource to delete. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="accessCondition"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public Response Delete(string dataSourceName, RequestOptions requestOptions = null, AccessCondition accessCondition = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }

            using var message = CreateDeleteRequest(dataSourceName, requestOptions, accessCondition);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string dataSourceName, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/datasources('", false);
            uri.AppendPath(dataSourceName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves a datasource definition. </summary>
        /// <param name="dataSourceName"> The name of the datasource to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public async Task<Response<DataSource>> GetAsync(string dataSourceName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }

            using var message = CreateGetRequest(dataSourceName, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves a datasource definition. </summary>
        /// <param name="dataSourceName"> The name of the datasource to retrieve. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceName"/> is null. </exception>
        public Response<DataSource> Get(string dataSourceName, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (dataSourceName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceName));
            }

            using var message = CreateGetRequest(dataSourceName, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string select, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/datasources", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all datasources available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListDataSourcesResult>> ListAsync(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListDataSourcesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListDataSourcesResult.DeserializeListDataSourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all datasources available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListDataSourcesResult> List(string select = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListDataSourcesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListDataSourcesResult.DeserializeListDataSourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(DataSource dataSource, RequestOptions requestOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/datasources", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(dataSource);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new datasource. </summary>
        /// <param name="dataSource"> The definition of the datasource to create. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> is null. </exception>
        public async Task<Response<DataSource>> CreateAsync(DataSource dataSource, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }

            using var message = CreateCreateRequest(dataSource, requestOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        DataSource value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new datasource. </summary>
        /// <param name="dataSource"> The definition of the datasource to create. </param>
        /// <param name="requestOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSource"/> is null. </exception>
        public Response<DataSource> Create(DataSource dataSource, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            if (dataSource == null)
            {
                throw new ArgumentNullException(nameof(dataSource));
            }

            using var message = CreateCreateRequest(dataSource, requestOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        DataSource value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataSource.DeserializeDataSource(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}