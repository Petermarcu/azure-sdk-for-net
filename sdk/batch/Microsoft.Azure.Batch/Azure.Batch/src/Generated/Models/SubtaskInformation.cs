// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Models
{
    /// <summary> Information about an Azure Batch subtask. </summary>
    public partial class SubtaskInformation
    {
        /// <summary> Initializes a new instance of SubtaskInformation. </summary>
        internal SubtaskInformation()
        {
        }

        /// <summary> Initializes a new instance of SubtaskInformation. </summary>
        /// <param name="id"> The ID of the subtask. </param>
        /// <param name="nodeInfo"> Information about the Compute Node on which a Task ran. </param>
        /// <param name="startTime"> The time at which the subtask started running. If the subtask has been restarted or retried, this is the most recent time at which the subtask started running. </param>
        /// <param name="endTime"> This property is set only if the subtask is in the Completed state. </param>
        /// <param name="exitCode"> This property is set only if the subtask is in the completed state. In general, the exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. However, if the Batch service terminates the subtask (due to timeout, or user termination via the API) you may see an operating system-defined exit code. </param>
        /// <param name="containerInfo"> This property is set only if the Task runs in a container context. </param>
        /// <param name="failureInfo"> This property is set only if the Task is in the completed state and encountered a failure. </param>
        /// <param name="state"> The state of the subtask. </param>
        /// <param name="stateTransitionTime"> The time at which the subtask entered its current state. </param>
        /// <param name="previousState"> This property is not set if the subtask is in its initial running state. </param>
        /// <param name="previousStateTransitionTime"> This property is not set if the subtask is in its initial running state. </param>
        /// <param name="result"> If the value is &apos;failed&apos;, then the details of the failure can be found in the failureInfo property. </param>
        internal SubtaskInformation(int? id, ComputeNodeInformation nodeInfo, DateTimeOffset? startTime, DateTimeOffset? endTime, int? exitCode, TaskContainerExecutionInformation containerInfo, TaskFailureInformation failureInfo, SubtaskState? state, DateTimeOffset? stateTransitionTime, SubtaskState? previousState, DateTimeOffset? previousStateTransitionTime, TaskExecutionResult? result)
        {
            Id = id;
            NodeInfo = nodeInfo;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            ContainerInfo = containerInfo;
            FailureInfo = failureInfo;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Result = result;
        }

        /// <summary> The ID of the subtask. </summary>
        public int? Id { get; }
        /// <summary> Information about the Compute Node on which a Task ran. </summary>
        public ComputeNodeInformation NodeInfo { get; }
        /// <summary> The time at which the subtask started running. If the subtask has been restarted or retried, this is the most recent time at which the subtask started running. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> This property is set only if the subtask is in the Completed state. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> This property is set only if the subtask is in the completed state. In general, the exit code for a process reflects the specific convention implemented by the application developer for that process. If you use the exit code value to make decisions in your code, be sure that you know the exit code convention used by the application process. However, if the Batch service terminates the subtask (due to timeout, or user termination via the API) you may see an operating system-defined exit code. </summary>
        public int? ExitCode { get; }
        /// <summary> This property is set only if the Task runs in a container context. </summary>
        public TaskContainerExecutionInformation ContainerInfo { get; }
        /// <summary> This property is set only if the Task is in the completed state and encountered a failure. </summary>
        public TaskFailureInformation FailureInfo { get; }
        /// <summary> The state of the subtask. </summary>
        public SubtaskState? State { get; }
        /// <summary> The time at which the subtask entered its current state. </summary>
        public DateTimeOffset? StateTransitionTime { get; }
        /// <summary> This property is not set if the subtask is in its initial running state. </summary>
        public SubtaskState? PreviousState { get; }
        /// <summary> This property is not set if the subtask is in its initial running state. </summary>
        public DateTimeOffset? PreviousStateTransitionTime { get; }
        /// <summary> If the value is &apos;failed&apos;, then the details of the failure can be found in the failureInfo property. </summary>
        public TaskExecutionResult? Result { get; }
    }
}
