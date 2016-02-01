// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake file status properties information
    /// </summary>
    public partial class FileStatusProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties() { }

        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties(long? accessTime = default(long?), long? blockSize = default(long?), long? childrenNum = default(long?), long? fileId = default(long?), string group = default(string), long? length = default(long?), long? modificationTime = default(long?), string owner = default(string), string pathSuffix = default(string), string permission = default(string), int? replication = default(int?), FileType? type = default(FileType?))
        {
            AccessTime = accessTime;
            BlockSize = blockSize;
            ChildrenNum = childrenNum;
            FileId = fileId;
            Group = group;
            Length = length;
            ModificationTime = modificationTime;
            Owner = owner;
            PathSuffix = pathSuffix;
            Permission = permission;
            Replication = replication;
            Type = type;
        }

        /// <summary>
        /// Gets or sets the last access time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "accessTime")]
        public long? AccessTime { get; set; }

        /// <summary>
        /// Gets or sets the block size for the file.
        /// </summary>
        [JsonProperty(PropertyName = "blockSize")]
        public long? BlockSize { get; set; }

        /// <summary>
        /// Gets or sets the number of children in the directory.
        /// </summary>
        [JsonProperty(PropertyName = "childrenNum")]
        public long? ChildrenNum { get; set; }

        /// <summary>
        /// Gets or sets the file identifier.
        /// </summary>
        [JsonProperty(PropertyName = "fileId")]
        public long? FileId { get; set; }

        /// <summary>
        /// Gets or sets the group owner.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes in a file.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public long? Length { get; set; }

        /// <summary>
        /// Gets or sets the modification time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "modificationTime")]
        public long? ModificationTime { get; set; }

        /// <summary>
        /// Gets or sets the user who is the owner.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the path suffix.
        /// </summary>
        [JsonProperty(PropertyName = "pathSuffix")]
        public string PathSuffix { get; set; }

        /// <summary>
        /// Gets or sets the permission represented as an octal string.
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Gets or sets the number of replications of a file.
        /// </summary>
        [JsonProperty(PropertyName = "replication")]
        public int? Replication { get; set; }

        /// <summary>
        /// Gets or sets the type of the path object. Possible values for this
        /// property include: 'File', 'Directory'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FileType? Type { get; set; }

    }
}
