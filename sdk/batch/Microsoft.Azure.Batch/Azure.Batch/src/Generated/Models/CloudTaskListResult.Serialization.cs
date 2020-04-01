// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class CloudTaskListResult
    {
        internal static CloudTaskListResult DeserializeCloudTaskListResult(JsonElement element)
        {
            IReadOnlyList<CloudTask> value = default;
            string odatanextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CloudTask> array = new List<CloudTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CloudTask.DeserializeCloudTask(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odatanextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CloudTaskListResult(value, odatanextLink);
        }
    }
}
