// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> Parameter group. </summary>
    public partial class JobListFromJobScheduleOptions
    {
        /// <summary> Initializes a new instance of JobListFromJobScheduleOptions. </summary>
        public JobListFromJobScheduleOptions()
        {
        }

        /// <summary> Initializes a new instance of JobListFromJobScheduleOptions. </summary>
        /// <param name="filter"> An OData $filter clause. For more information on constructing this filter, see https://docs.microsoft.com/en-us/rest/api/batchservice/odata-filters-in-batch#list-jobs-in-a-job-schedule. </param>
        /// <param name="select"> An OData $select clause. </param>
        /// <param name="expand"> An OData $expand clause. </param>
        /// <param name="maxResults"> The maximum number of items to return in the response. A maximum of 1000 Jobs can be returned. </param>
        /// <param name="timeout"> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </param>
        /// <param name="clientRequestId"> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </param>
        /// <param name="returnClientRequestId"> Whether the server should return the client-request-id in the response. </param>
        /// <param name="ocpDate"> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </param>
        internal JobListFromJobScheduleOptions(string filter, string select, string expand, int? maxResults, int? timeout, Guid? clientRequestId, bool? returnClientRequestId, DateTimeOffset? ocpDate)
        {
            Filter = filter;
            Select = select;
            Expand = expand;
            MaxResults = maxResults;
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
        }

        /// <summary> An OData $filter clause. For more information on constructing this filter, see https://docs.microsoft.com/en-us/rest/api/batchservice/odata-filters-in-batch#list-jobs-in-a-job-schedule. </summary>
        public string Filter { get; set; }
        /// <summary> An OData $select clause. </summary>
        public string Select { get; set; }
        /// <summary> An OData $expand clause. </summary>
        public string Expand { get; set; }
        /// <summary> The maximum number of items to return in the response. A maximum of 1000 Jobs can be returned. </summary>
        public int? MaxResults { get; set; }
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
