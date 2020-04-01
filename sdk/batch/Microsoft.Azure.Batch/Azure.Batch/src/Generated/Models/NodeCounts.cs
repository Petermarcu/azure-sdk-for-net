// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> The number of Compute Nodes in each Compute Node state. </summary>
    public partial class NodeCounts
    {
        /// <summary> Initializes a new instance of NodeCounts. </summary>
        /// <param name="creating"> The number of Compute Nodes in the creating state. </param>
        /// <param name="idle"> The number of Compute Nodes in the idle state. </param>
        /// <param name="offline"> The number of Compute Nodes in the offline state. </param>
        /// <param name="preempted"> The number of Compute Nodes in the preempted state. </param>
        /// <param name="rebooting"> The count of Compute Nodes in the rebooting state. </param>
        /// <param name="reimaging"> The number of Compute Nodes in the reimaging state. </param>
        /// <param name="running"> The number of Compute Nodes in the running state. </param>
        /// <param name="starting"> The number of Compute Nodes in the starting state. </param>
        /// <param name="startTaskFailed"> The number of Compute Nodes in the startTaskFailed state. </param>
        /// <param name="leavingPool"> The number of Compute Nodes in the leavingPool state. </param>
        /// <param name="unknown"> The number of Compute Nodes in the unknown state. </param>
        /// <param name="unusable"> The number of Compute Nodes in the unusable state. </param>
        /// <param name="waitingForStartTask"> The number of Compute Nodes in the waitingForStartTask state. </param>
        /// <param name="total"> The total number of Compute Nodes. </param>
        internal NodeCounts(int creating, int idle, int offline, int preempted, int rebooting, int reimaging, int running, int starting, int startTaskFailed, int leavingPool, int unknown, int unusable, int waitingForStartTask, int total)
        {
            Creating = creating;
            Idle = idle;
            Offline = offline;
            Preempted = preempted;
            Rebooting = rebooting;
            Reimaging = reimaging;
            Running = running;
            Starting = starting;
            StartTaskFailed = startTaskFailed;
            LeavingPool = leavingPool;
            Unknown = unknown;
            Unusable = unusable;
            WaitingForStartTask = waitingForStartTask;
            Total = total;
        }

        /// <summary> The number of Compute Nodes in the creating state. </summary>
        public int Creating { get; }
        /// <summary> The number of Compute Nodes in the idle state. </summary>
        public int Idle { get; }
        /// <summary> The number of Compute Nodes in the offline state. </summary>
        public int Offline { get; }
        /// <summary> The number of Compute Nodes in the preempted state. </summary>
        public int Preempted { get; }
        /// <summary> The count of Compute Nodes in the rebooting state. </summary>
        public int Rebooting { get; }
        /// <summary> The number of Compute Nodes in the reimaging state. </summary>
        public int Reimaging { get; }
        /// <summary> The number of Compute Nodes in the running state. </summary>
        public int Running { get; }
        /// <summary> The number of Compute Nodes in the starting state. </summary>
        public int Starting { get; }
        /// <summary> The number of Compute Nodes in the startTaskFailed state. </summary>
        public int StartTaskFailed { get; }
        /// <summary> The number of Compute Nodes in the leavingPool state. </summary>
        public int LeavingPool { get; }
        /// <summary> The number of Compute Nodes in the unknown state. </summary>
        public int Unknown { get; }
        /// <summary> The number of Compute Nodes in the unusable state. </summary>
        public int Unusable { get; }
        /// <summary> The number of Compute Nodes in the waitingForStartTask state. </summary>
        public int WaitingForStartTask { get; }
        /// <summary> The total number of Compute Nodes. </summary>
        public int Total { get; }
    }
}
