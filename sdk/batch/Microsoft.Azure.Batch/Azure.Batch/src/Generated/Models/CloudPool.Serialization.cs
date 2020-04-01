// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Models
{
    public partial class CloudPool
    {
        internal static CloudPool DeserializeCloudPool(JsonElement element)
        {
            string id = default;
            string displayName = default;
            string url = default;
            string eTag = default;
            DateTimeOffset? lastModified = default;
            DateTimeOffset? creationTime = default;
            PoolState? state = default;
            DateTimeOffset? stateTransitionTime = default;
            AllocationState? allocationState = default;
            DateTimeOffset? allocationStateTransitionTime = default;
            string vmSize = default;
            CloudServiceConfiguration cloudServiceConfiguration = default;
            VirtualMachineConfiguration virtualMachineConfiguration = default;
            TimeSpan? resizeTimeout = default;
            IReadOnlyList<ResizeError> resizeErrors = default;
            int? currentDedicatedNodes = default;
            int? currentLowPriorityNodes = default;
            int? targetDedicatedNodes = default;
            int? targetLowPriorityNodes = default;
            bool? enableAutoScale = default;
            string autoScaleFormula = default;
            TimeSpan? autoScaleEvaluationInterval = default;
            AutoScaleRun autoScaleRun = default;
            bool? enableInterNodeCommunication = default;
            NetworkConfiguration networkConfiguration = default;
            StartTask startTask = default;
            IReadOnlyList<CertificateReference> certificateReferences = default;
            IReadOnlyList<ApplicationPackageReference> applicationPackageReferences = default;
            IReadOnlyList<string> applicationLicenses = default;
            int? maxTasksPerNode = default;
            TaskSchedulingPolicy taskSchedulingPolicy = default;
            IReadOnlyList<UserAccount> userAccounts = default;
            IReadOnlyList<MetadataItem> metadata = default;
            PoolStatistics stats = default;
            IReadOnlyList<MountConfiguration> mountConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("creationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToPoolState();
                    continue;
                }
                if (property.NameEquals("stateTransitionTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stateTransitionTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("allocationState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationState = property.Value.GetString().ToAllocationState();
                    continue;
                }
                if (property.NameEquals("allocationStateTransitionTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationStateTransitionTime = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudServiceConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudServiceConfiguration = CloudServiceConfiguration.DeserializeCloudServiceConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineConfiguration = VirtualMachineConfiguration.DeserializeVirtualMachineConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("resizeTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resizeTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("resizeErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResizeError> array = new List<ResizeError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResizeError.DeserializeResizeError(item));
                    }
                    resizeErrors = array;
                    continue;
                }
                if (property.NameEquals("currentDedicatedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentLowPriorityNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetDedicatedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDedicatedNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetLowPriorityNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetLowPriorityNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScale"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutoScale = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoScaleFormula"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScaleFormula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoScaleEvaluationInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScaleEvaluationInterval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("autoScaleRun"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScaleRun = AutoScaleRun.DeserializeAutoScaleRun(property.Value);
                    continue;
                }
                if (property.NameEquals("enableInterNodeCommunication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableInterNodeCommunication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("networkConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("startTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTask = StartTask.DeserializeStartTask(property.Value);
                    continue;
                }
                if (property.NameEquals("certificateReferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CertificateReference> array = new List<CertificateReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertificateReference.DeserializeCertificateReference(item));
                    }
                    certificateReferences = array;
                    continue;
                }
                if (property.NameEquals("applicationPackageReferences"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationPackageReference> array = new List<ApplicationPackageReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationPackageReference.DeserializeApplicationPackageReference(item));
                    }
                    applicationPackageReferences = array;
                    continue;
                }
                if (property.NameEquals("applicationLicenses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    applicationLicenses = array;
                    continue;
                }
                if (property.NameEquals("maxTasksPerNode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTasksPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskSchedulingPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taskSchedulingPolicy = TaskSchedulingPolicy.DeserializeTaskSchedulingPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("userAccounts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserAccount> array = new List<UserAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserAccount.DeserializeUserAccount(item));
                    }
                    userAccounts = array;
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetadataItem> array = new List<MetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataItem.DeserializeMetadataItem(item));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("stats"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stats = PoolStatistics.DeserializePoolStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("mountConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MountConfiguration> array = new List<MountConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.MountConfiguration.DeserializeMountConfiguration(item));
                    }
                    mountConfiguration = array;
                    continue;
                }
            }
            return new CloudPool(id, displayName, url, eTag, lastModified, creationTime, state, stateTransitionTime, allocationState, allocationStateTransitionTime, vmSize, cloudServiceConfiguration, virtualMachineConfiguration, resizeTimeout, resizeErrors, currentDedicatedNodes, currentLowPriorityNodes, targetDedicatedNodes, targetLowPriorityNodes, enableAutoScale, autoScaleFormula, autoScaleEvaluationInterval, autoScaleRun, enableInterNodeCommunication, networkConfiguration, startTask, certificateReferences, applicationPackageReferences, applicationLicenses, maxTasksPerNode, taskSchedulingPolicy, userAccounts, metadata, stats, mountConfiguration);
        }
    }
}
