// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class AutoUserSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Scope != null)
            {
                writer.WritePropertyName("scope");
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (ElevationLevel != null)
            {
                writer.WritePropertyName("elevationLevel");
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static AutoUserSpecification DeserializeAutoUserSpecification(JsonElement element)
        {
            AutoUserScope? scope = default;
            ElevationLevel? elevationLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = property.Value.GetString().ToAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToElevationLevel();
                    continue;
                }
            }
            return new AutoUserSpecification(scope, elevationLevel);
        }
    }
}
