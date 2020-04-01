// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Batch.Models
{
    /// <summary> The result of listing the Certificates in the Account. </summary>
    public partial class CertificateListResult
    {
        /// <summary> Initializes a new instance of CertificateListResult. </summary>
        internal CertificateListResult()
        {
        }

        /// <summary> Initializes a new instance of CertificateListResult. </summary>
        /// <param name="value"> The list of Certificates. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal CertificateListResult(IReadOnlyList<Certificate> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> The list of Certificates. </summary>
        public IReadOnlyList<Certificate> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
