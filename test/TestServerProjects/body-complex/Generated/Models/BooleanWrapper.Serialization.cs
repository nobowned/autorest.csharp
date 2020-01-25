// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class BooleanWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (FieldTrue != null)
            {
                writer.WritePropertyName("field_true");
                writer.WriteBooleanValue(FieldTrue.Value);
            }
            if (FieldFalse != null)
            {
                writer.WritePropertyName("field_false");
                writer.WriteBooleanValue(FieldFalse.Value);
            }
            writer.WriteEndObject();
        }
        internal static BooleanWrapper DeserializeBooleanWrapper(JsonElement element)
        {
            BooleanWrapper result = new BooleanWrapper();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field_true"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FieldTrue = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("field_false"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FieldFalse = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}