// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> Details about an output file upload operation, including under what conditions to perform the upload. </summary>
    public partial class OutputFileUploadOptions
    {
        /// <summary> Initializes a new instance of OutputFileUploadOptions. </summary>
        /// <param name="uploadCondition"> The default is taskcompletion. </param>
        internal OutputFileUploadOptions(OutputFileUploadCondition uploadCondition)
        {
            UploadCondition = uploadCondition;
        }

        /// <summary> The default is taskcompletion. </summary>
        public OutputFileUploadCondition UploadCondition { get; }
    }
}
