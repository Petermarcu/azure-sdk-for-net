// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class TaskIdRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("start");
            writer.WriteNumberValue(Start);
            writer.WritePropertyName("end");
            writer.WriteNumberValue(End);
            writer.WriteEndObject();
        }

        internal static TaskIdRange DeserializeTaskIdRange(JsonElement element)
        {
            int start = default;
            int end = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"))
                {
                    start = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    end = property.Value.GetInt32();
                    continue;
                }
            }
            return new TaskIdRange(start, end);
        }
    }
}
