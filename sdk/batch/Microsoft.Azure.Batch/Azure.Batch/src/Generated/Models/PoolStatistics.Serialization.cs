// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class PoolStatistics
    {
        internal static PoolStatistics DeserializePoolStatistics(JsonElement element)
        {
            string url = default;
            DateTimeOffset startTime = default;
            DateTimeOffset lastUpdateTime = default;
            UsageStatistics usageStats = default;
            ResourceStatistics resourceStats = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    lastUpdateTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("usageStats"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usageStats = UsageStatistics.DeserializeUsageStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceStats"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStats = ResourceStatistics.DeserializeResourceStatistics(property.Value);
                    continue;
                }
            }
            return new PoolStatistics(url, startTime, lastUpdateTime, usageStats, resourceStats);
        }
    }
}
