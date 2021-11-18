// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtScopeResource.Models
{
    public partial class DeploymentOperation
    {
        internal static DeploymentOperation DeserializeDeploymentOperation(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> operationId = default;
            Optional<DeploymentOperationProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = DeploymentOperationProperties.DeserializeDeploymentOperationProperties(property.Value);
                    continue;
                }
            }
            return new DeploymentOperation(id.Value, operationId.Value, properties.Value);
        }
    }
}