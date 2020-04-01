// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> Parameter group. </summary>
    public partial class FileDeleteFromTaskOptions
    {
        /// <summary> Initializes a new instance of FileDeleteFromTaskOptions. </summary>
        public FileDeleteFromTaskOptions()
        {
        }

        /// <summary> Initializes a new instance of FileDeleteFromTaskOptions. </summary>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        internal FileDeleteFromTaskOptions(int? timeout, Guid? clientRequestId, bool? returnClientRequestId, DateTimeOffset? ocpDate)
        {
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
        }

        /// <summary> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        public Guid? ClientRequestId { get; set; }
        /// <summary> Whether the server should return the client-request-id in the response. </summary>
        public bool? ReturnClientRequestId { get; set; }
        /// <summary> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </summary>
        public DateTimeOffset? OcpDate { get; set; }
    }
}
