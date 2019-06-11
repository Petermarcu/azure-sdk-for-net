// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// AppInsights credentials.
    /// </summary>
    public partial class AppInsightsCredentials
    {
        /// <summary>
        /// Initializes a new instance of the AppInsightsCredentials class.
        /// </summary>
        public AppInsightsCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppInsightsCredentials class.
        /// </summary>
        /// <param name="appId">The AppInsights application ID.</param>
        /// <param name="instrumentationKey">The AppInsights instrumentation
        /// key. This is not returned in response of GET/PUT on the resource.
        /// To see this please call listKeys API.</param>
        public AppInsightsCredentials(string appId = default(string), string instrumentationKey = default(string))
        {
            AppId = appId;
            InstrumentationKey = instrumentationKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the AppInsights application ID.
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the AppInsights instrumentation key. This is not
        /// returned in response of GET/PUT on the resource. To see this please
        /// call listKeys API.
        /// </summary>
        [JsonProperty(PropertyName = "instrumentationKey")]
        public string InstrumentationKey { get; set; }

    }
}