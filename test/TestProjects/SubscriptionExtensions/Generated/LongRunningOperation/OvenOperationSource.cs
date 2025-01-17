// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace SubscriptionExtensions
{
    internal class OvenOperationSource : IOperationSource<OvenResource>
    {
        private readonly ArmClient _client;

        internal OvenOperationSource(ArmClient client)
        {
            _client = client;
        }

        OvenResource IOperationSource<OvenResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = OvenData.DeserializeOvenData(document.RootElement);
            return new OvenResource(_client, data);
        }

        async ValueTask<OvenResource> IOperationSource<OvenResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = OvenData.DeserializeOvenData(document.RootElement);
            return new OvenResource(_client, data);
        }
    }
}
