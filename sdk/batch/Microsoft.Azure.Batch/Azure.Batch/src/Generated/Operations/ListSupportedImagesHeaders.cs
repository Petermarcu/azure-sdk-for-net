// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Batch
{
    internal class ListSupportedImagesHeaders
    {
        private readonly Response _response;
        public ListSupportedImagesHeaders(Response response)
        {
            _response = response;
        }
        public Guid? ClientRequestId => _response.Headers.TryGetValue("client-request-id", out Guid? value) ? value : null;
        public Guid? RequestId => _response.Headers.TryGetValue("request-id", out Guid? value) ? value : null;
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
    }
}
