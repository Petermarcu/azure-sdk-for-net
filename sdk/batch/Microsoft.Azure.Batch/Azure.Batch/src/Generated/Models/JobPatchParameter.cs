// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Batch.Models
{
    /// <summary> The set of changes to be made to a Job. </summary>
    public partial class JobPatchParameter
    {
        /// <summary> Initializes a new instance of JobPatchParameter. </summary>
        public JobPatchParameter()
        {
        }

        /// <summary> Initializes a new instance of JobPatchParameter. </summary>
        /// <param name="priority"> Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. If omitted, the priority of the Job is left unchanged. </param>
        /// <param name="onAllTasksComplete"> If omitted, the completion behavior is left unchanged. You may not change the value from terminatejob to noaction - that is, once you have engaged automatic Job termination, you cannot turn it off again. If you try to do this, the request fails with an &apos;invalid property value&apos; error response; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="constraints"> If omitted, the existing execution constraints are left unchanged. </param>
        /// <param name="poolInfo"> You may change the Pool for a Job only when the Job is disabled. The Patch Job call will fail if you include the poolInfo element and the Job is not disabled. If you specify an autoPoolSpecification in the poolInfo, only the keepAlive property of the autoPoolSpecification can be updated, and then only if the autoPoolSpecification has a poolLifetimeOption of Job (other job properties can be updated as normal). If omitted, the Job continues to run on its current Pool. </param>
        /// <param name="metadata"> If omitted, the existing Job metadata is left unchanged. </param>
        internal JobPatchParameter(int? priority, OnAllTasksComplete? onAllTasksComplete, JobConstraints constraints, PoolInformation poolInfo, IList<MetadataItem> metadata)
        {
            Priority = priority;
            OnAllTasksComplete = onAllTasksComplete;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
        }

        /// <summary> Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. If omitted, the priority of the Job is left unchanged. </summary>
        public int? Priority { get; set; }
        /// <summary> If omitted, the completion behavior is left unchanged. You may not change the value from terminatejob to noaction - that is, once you have engaged automatic Job termination, you cannot turn it off again. If you try to do this, the request fails with an &apos;invalid property value&apos; error response; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }
        /// <summary> If omitted, the existing execution constraints are left unchanged. </summary>
        public JobConstraints Constraints { get; set; }
        /// <summary> You may change the Pool for a Job only when the Job is disabled. The Patch Job call will fail if you include the poolInfo element and the Job is not disabled. If you specify an autoPoolSpecification in the poolInfo, only the keepAlive property of the autoPoolSpecification can be updated, and then only if the autoPoolSpecification has a poolLifetimeOption of Job (other job properties can be updated as normal). If omitted, the Job continues to run on its current Pool. </summary>
        public PoolInformation PoolInfo { get; set; }
        /// <summary> If omitted, the existing Job metadata is left unchanged. </summary>
        public IList<MetadataItem> Metadata { get; set; }
    }
}
