// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> The status of the Job Preparation and Job Release Tasks on a Compute Node. </summary>
    public partial class JobPreparationAndReleaseTaskExecutionInformation
    {
        /// <summary> Initializes a new instance of JobPreparationAndReleaseTaskExecutionInformation. </summary>
        internal JobPreparationAndReleaseTaskExecutionInformation()
        {
        }

        /// <summary> Initializes a new instance of JobPreparationAndReleaseTaskExecutionInformation. </summary>
        /// <param name="poolId"> The ID of the Pool containing the Compute Node to which this entry refers. </param>
        /// <param name="nodeId"> The ID of the Compute Node to which this entry refers. </param>
        /// <param name="nodeUrl"> The URL of the Compute Node to which this entry refers. </param>
        /// <param name="jobPreparationTaskExecutionInfo"> Contains information about the execution of a Job Preparation Task on a Compute Node. </param>
        /// <param name="jobReleaseTaskExecutionInfo"> This property is set only if the Job Release Task has run on the Compute Node. </param>
        internal JobPreparationAndReleaseTaskExecutionInformation(string poolId, string nodeId, string nodeUrl, JobPreparationTaskExecutionInformation jobPreparationTaskExecutionInfo, JobReleaseTaskExecutionInformation jobReleaseTaskExecutionInfo)
        {
            PoolId = poolId;
            NodeId = nodeId;
            NodeUrl = nodeUrl;
            JobPreparationTaskExecutionInfo = jobPreparationTaskExecutionInfo;
            JobReleaseTaskExecutionInfo = jobReleaseTaskExecutionInfo;
        }

        /// <summary> The ID of the Pool containing the Compute Node to which this entry refers. </summary>
        public string PoolId { get; }
        /// <summary> The ID of the Compute Node to which this entry refers. </summary>
        public string NodeId { get; }
        /// <summary> The URL of the Compute Node to which this entry refers. </summary>
        public string NodeUrl { get; }
        /// <summary> Contains information about the execution of a Job Preparation Task on a Compute Node. </summary>
        public JobPreparationTaskExecutionInformation JobPreparationTaskExecutionInfo { get; }
        /// <summary> This property is set only if the Job Release Task has run on the Compute Node. </summary>
        public JobReleaseTaskExecutionInformation JobReleaseTaskExecutionInfo { get; }
    }
}
