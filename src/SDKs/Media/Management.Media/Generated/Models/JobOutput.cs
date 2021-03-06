// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes all the properties of a JobOutput.
    /// </summary>
    public partial class JobOutput
    {
        /// <summary>
        /// Initializes a new instance of the JobOutput class.
        /// </summary>
        public JobOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobOutput class.
        /// </summary>
        /// <param name="error">If the JobOutput is in the Error state, it
        /// contains the details of the error.</param>
        /// <param name="state">Describes the state of the JobOutput. Possible
        /// values include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="progress">If the JobOutput is in a Processing state,
        /// this contains the job completion percentage.  The value is an
        /// estimate and not intended to be used to predict job completion
        /// times. To determine if the JobOutput is complete, use the State
        /// property.</param>
        public JobOutput(JobError error = default(JobError), JobState state = default(JobState), int progress = default(int))
        {
            Error = error;
            State = state;
            Progress = progress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets if the JobOutput is in the Error state, it contains the
        /// details of the error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public JobError Error { get; private set; }

        /// <summary>
        /// Gets describes the state of the JobOutput. Possible values include:
        /// 'Canceled', 'Canceling', 'Error', 'Finished', 'Processing',
        /// 'Queued', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState State { get; private set; }

        /// <summary>
        /// Gets if the JobOutput is in a Processing state, this contains the
        /// job completion percentage.  The value is an estimate and not
        /// intended to be used to predict job completion times. To determine
        /// if the JobOutput is complete, use the State property.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public int Progress { get; private set; }

    }
}
