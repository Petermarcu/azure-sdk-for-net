// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> Options when terminating a Job. </summary>
    public partial class JobTerminateParameter
    {
        /// <summary> Initializes a new instance of JobTerminateParameter. </summary>
        public JobTerminateParameter()
        {
        }

        /// <summary> Initializes a new instance of JobTerminateParameter. </summary>
        /// <param name="terminateReason"> The text you want to appear as the Job&apos;s TerminateReason. The default is &apos;UserTerminate&apos;. </param>
        internal JobTerminateParameter(string terminateReason)
        {
            TerminateReason = terminateReason;
        }

        /// <summary> The text you want to appear as the Job&apos;s TerminateReason. The default is &apos;UserTerminate&apos;. </summary>
        public string TerminateReason { get; set; }
    }
}
