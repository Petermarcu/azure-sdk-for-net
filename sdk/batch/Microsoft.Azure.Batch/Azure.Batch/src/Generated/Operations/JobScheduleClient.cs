// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Batch.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Batch
{
    public partial class JobScheduleClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal JobScheduleRestClient RestClient { get; }
        /// <summary> Initializes a new instance of JobScheduleClient for mocking. </summary>
        protected JobScheduleClient()
        {
        }
        /// <summary> Initializes a new instance of JobScheduleClient. </summary>
        internal JobScheduleClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string batchUrl, string apiVersion = "2020-03-01.11.0")
        {
            RestClient = new JobScheduleRestClient(clientDiagnostics, pipeline, batchUrl, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Checks the specified Job Schedule exists. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule which you want to check. </param>
        /// <param name="jobScheduleExistsOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ExistsAsync(string jobScheduleId, JobScheduleExistsOptions jobScheduleExistsOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.ExistsAsync(jobScheduleId, jobScheduleExistsOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Checks the specified Job Schedule exists. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule which you want to check. </param>
        /// <param name="jobScheduleExistsOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Exists(string jobScheduleId, JobScheduleExistsOptions jobScheduleExistsOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Exists(jobScheduleId, jobScheduleExistsOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> When you delete a Job Schedule, this also deletes all Jobs and Tasks under that schedule. When Tasks are deleted, all the files in their working directories on the Compute Nodes are also deleted (the retention period is ignored). The Job Schedule statistics are no longer accessible once the Job Schedule is deleted, though they are still counted towards Account lifetime statistics. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to delete. </param>
        /// <param name="jobScheduleDeleteOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string jobScheduleId, JobScheduleDeleteOptions jobScheduleDeleteOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.DeleteAsync(jobScheduleId, jobScheduleDeleteOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> When you delete a Job Schedule, this also deletes all Jobs and Tasks under that schedule. When Tasks are deleted, all the files in their working directories on the Compute Nodes are also deleted (the retention period is ignored). The Job Schedule statistics are no longer accessible once the Job Schedule is deleted, though they are still counted towards Account lifetime statistics. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to delete. </param>
        /// <param name="jobScheduleDeleteOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string jobScheduleId, JobScheduleDeleteOptions jobScheduleDeleteOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(jobScheduleId, jobScheduleDeleteOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Gets information about the specified Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to get. </param>
        /// <param name="jobScheduleGetOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CloudJobSchedule>> GetAsync(string jobScheduleId, JobScheduleGetOptions jobScheduleGetOptions, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(jobScheduleId, jobScheduleGetOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets information about the specified Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to get. </param>
        /// <param name="jobScheduleGetOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudJobSchedule> Get(string jobScheduleId, JobScheduleGetOptions jobScheduleGetOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(jobScheduleId, jobScheduleGetOptions, cancellationToken);
        }

        /// <summary> This replaces only the Job Schedule properties specified in the request. For example, if the schedule property is not specified with this request, then the Batch service will keep the existing schedule. Changes to a Job Schedule only impact Jobs created by the schedule after the update has taken place; currently running Jobs are unaffected. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to update. </param>
        /// <param name="jobSchedulePatchParameter"> The parameters for the request. </param>
        /// <param name="jobSchedulePatchOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PatchAsync(string jobScheduleId, JobSchedulePatchParameter jobSchedulePatchParameter, JobSchedulePatchOptions jobSchedulePatchOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.PatchAsync(jobScheduleId, jobSchedulePatchParameter, jobSchedulePatchOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> This replaces only the Job Schedule properties specified in the request. For example, if the schedule property is not specified with this request, then the Batch service will keep the existing schedule. Changes to a Job Schedule only impact Jobs created by the schedule after the update has taken place; currently running Jobs are unaffected. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to update. </param>
        /// <param name="jobSchedulePatchParameter"> The parameters for the request. </param>
        /// <param name="jobSchedulePatchOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Patch(string jobScheduleId, JobSchedulePatchParameter jobSchedulePatchParameter, JobSchedulePatchOptions jobSchedulePatchOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Patch(jobScheduleId, jobSchedulePatchParameter, jobSchedulePatchOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> This fully replaces all the updatable properties of the Job Schedule. For example, if the schedule property is not specified with this request, then the Batch service will remove the existing schedule. Changes to a Job Schedule only impact Jobs created by the schedule after the update has taken place; currently running Jobs are unaffected. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to update. </param>
        /// <param name="jobScheduleUpdateParameter"> The parameters for the request. </param>
        /// <param name="jobScheduleUpdateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateAsync(string jobScheduleId, JobScheduleUpdateParameter jobScheduleUpdateParameter, JobScheduleUpdateOptions jobScheduleUpdateOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.UpdateAsync(jobScheduleId, jobScheduleUpdateParameter, jobScheduleUpdateOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> This fully replaces all the updatable properties of the Job Schedule. For example, if the schedule property is not specified with this request, then the Batch service will remove the existing schedule. Changes to a Job Schedule only impact Jobs created by the schedule after the update has taken place; currently running Jobs are unaffected. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to update. </param>
        /// <param name="jobScheduleUpdateParameter"> The parameters for the request. </param>
        /// <param name="jobScheduleUpdateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Update(string jobScheduleId, JobScheduleUpdateParameter jobScheduleUpdateParameter, JobScheduleUpdateOptions jobScheduleUpdateOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Update(jobScheduleId, jobScheduleUpdateParameter, jobScheduleUpdateOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> No new Jobs will be created until the Job Schedule is enabled again. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to disable. </param>
        /// <param name="jobScheduleDisableOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisableAsync(string jobScheduleId, JobScheduleDisableOptions jobScheduleDisableOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.DisableAsync(jobScheduleId, jobScheduleDisableOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> No new Jobs will be created until the Job Schedule is enabled again. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to disable. </param>
        /// <param name="jobScheduleDisableOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Disable(string jobScheduleId, JobScheduleDisableOptions jobScheduleDisableOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Disable(jobScheduleId, jobScheduleDisableOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Enables a Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to enable. </param>
        /// <param name="jobScheduleEnableOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnableAsync(string jobScheduleId, JobScheduleEnableOptions jobScheduleEnableOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.EnableAsync(jobScheduleId, jobScheduleEnableOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Enables a Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to enable. </param>
        /// <param name="jobScheduleEnableOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Enable(string jobScheduleId, JobScheduleEnableOptions jobScheduleEnableOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Enable(jobScheduleId, jobScheduleEnableOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Terminates a Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to terminates. </param>
        /// <param name="jobScheduleTerminateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TerminateAsync(string jobScheduleId, JobScheduleTerminateOptions jobScheduleTerminateOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.TerminateAsync(jobScheduleId, jobScheduleTerminateOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Terminates a Job Schedule. </summary>
        /// <param name="jobScheduleId"> The ID of the Job Schedule to terminates. </param>
        /// <param name="jobScheduleTerminateOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Terminate(string jobScheduleId, JobScheduleTerminateOptions jobScheduleTerminateOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Terminate(jobScheduleId, jobScheduleTerminateOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Adds a Job Schedule to the specified Account. </summary>
        /// <param name="cloudJobSchedule"> The Job Schedule to be added. </param>
        /// <param name="jobScheduleAddOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AddAsync(JobScheduleAddParameter cloudJobSchedule, JobScheduleAddOptions jobScheduleAddOptions, CancellationToken cancellationToken = default)
        {
            return (await RestClient.AddAsync(cloudJobSchedule, jobScheduleAddOptions, cancellationToken).ConfigureAwait(false)).GetRawResponse();
        }

        /// <summary> Adds a Job Schedule to the specified Account. </summary>
        /// <param name="cloudJobSchedule"> The Job Schedule to be added. </param>
        /// <param name="jobScheduleAddOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Add(JobScheduleAddParameter cloudJobSchedule, JobScheduleAddOptions jobScheduleAddOptions, CancellationToken cancellationToken = default)
        {
            return RestClient.Add(cloudJobSchedule, jobScheduleAddOptions, cancellationToken).GetRawResponse();
        }

        /// <summary> Lists all of the Job Schedules in the specified Account. </summary>
        /// <param name="jobScheduleListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<CloudJobSchedule> ListAsync(JobScheduleListOptions jobScheduleListOptions, CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudJobSchedule>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(jobScheduleListOptions, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<CloudJobSchedule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, jobScheduleListOptions, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the Job Schedules in the specified Account. </summary>
        /// <param name="jobScheduleListOptions"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<CloudJobSchedule> List(JobScheduleListOptions jobScheduleListOptions, CancellationToken cancellationToken = default)
        {
            Page<CloudJobSchedule> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(jobScheduleListOptions, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<CloudJobSchedule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, jobScheduleListOptions, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
