// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtKeyvault;

namespace MgmtKeyvault.Models
{
    internal partial class MgmtKeyvaultPrivateEndpointConnectionListResult
    {
        internal static MgmtKeyvaultPrivateEndpointConnectionListResult DeserializeMgmtKeyvaultPrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MgmtKeyvaultPrivateEndpointConnectionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MgmtKeyvaultPrivateEndpointConnectionData> array = new List<MgmtKeyvaultPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MgmtKeyvaultPrivateEndpointConnectionData.DeserializeMgmtKeyvaultPrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MgmtKeyvaultPrivateEndpointConnectionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}