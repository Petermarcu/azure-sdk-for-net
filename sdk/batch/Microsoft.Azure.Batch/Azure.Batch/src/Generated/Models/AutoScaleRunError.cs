// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Batch.Models
{
    /// <summary> An error that occurred when executing or evaluating a Pool autoscale formula. </summary>
    public partial class AutoScaleRunError
    {
        /// <summary> Initializes a new instance of AutoScaleRunError. </summary>
        internal AutoScaleRunError()
        {
        }

        /// <summary> Initializes a new instance of AutoScaleRunError. </summary>
        /// <param name="code"> An identifier for the autoscale error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the autoscale error, intended to be suitable for display in a user interface. </param>
        /// <param name="values"> A list of additional error details related to the autoscale error. </param>
        internal AutoScaleRunError(string code, string message, IReadOnlyList<NameValuePair> values)
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary> An identifier for the autoscale error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the autoscale error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
        /// <summary> A list of additional error details related to the autoscale error. </summary>
        public IReadOnlyList<NameValuePair> Values { get; }
    }
}
