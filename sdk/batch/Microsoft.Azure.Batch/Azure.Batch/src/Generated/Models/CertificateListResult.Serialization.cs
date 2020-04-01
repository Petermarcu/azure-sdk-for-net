// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class CertificateListResult
    {
        internal static CertificateListResult DeserializeCertificateListResult(JsonElement element)
        {
            IReadOnlyList<Certificate> value = default;
            string odatanextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Certificate> array = new List<Certificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Certificate.DeserializeCertificate(item));
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
            return new CertificateListResult(value, odatanextLink);
        }
    }
}
