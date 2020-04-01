// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Models
{
    /// <summary> The set of changes to be made to a Task. </summary>
    public partial class TaskUpdateParameter
    {
        /// <summary> Initializes a new instance of TaskUpdateParameter. </summary>
        public TaskUpdateParameter()
        {
        }

        /// <summary> Initializes a new instance of TaskUpdateParameter. </summary>
        /// <param name="constraints"> If omitted, the Task is given the default constraints. For multi-instance Tasks, updating the retention time applies only to the primary Task and not subtasks. </param>
        internal TaskUpdateParameter(TaskConstraints constraints)
        {
            Constraints = constraints;
        }

        /// <summary> If omitted, the Task is given the default constraints. For multi-instance Tasks, updating the retention time applies only to the primary Task and not subtasks. </summary>
        public TaskConstraints Constraints { get; set; }
    }
}
