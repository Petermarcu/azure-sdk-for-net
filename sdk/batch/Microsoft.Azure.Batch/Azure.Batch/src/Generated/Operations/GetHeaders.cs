// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Batch
{
    internal class GetHeaders
    {
        private readonly Response _response;
    }
}
blic string DataServiceId => _response.Headers.TryGetValue("DataServiceId", out string value) ? value : null;
    }
}
