// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    internal partial class JobStreamRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of JobStreamRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public JobStreamRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string jobStreamId, string clientRequestId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/streams/", false);
            uri.AppendPath(jobStreamId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string jobStreamId, string clientRequestId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/streams/", false);
            uri.AppendPath(jobStreamId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("clientRequestId", clientRequestId);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve the job stream identified by job stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="jobName"/> or <paramref name="jobStreamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="jobName"/> or <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStream>> GetAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string jobStreamId, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, jobName, jobStreamId, clientRequestId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStream value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStream.DeserializeAutomationJobStream(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve the job stream identified by job stream id. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="jobStreamId"> The job stream id. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="jobName"/> or <paramref name="jobStreamId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/>, <paramref name="jobName"/> or <paramref name="jobStreamId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStream> Get(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string jobStreamId, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));
            Argument.AssertNotNullOrEmpty(jobStreamId, nameof(jobStreamId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, automationAccountName, jobName, jobStreamId, clientRequestId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStream value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AutomationJobStream.DeserializeAutomationJobStream(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByJobRequestUri(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter, string clientRequestId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/streams", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByJobRequest(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter, string clientRequestId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Automation/automationAccounts/", false);
            uri.AppendPath(automationAccountName, true);
            uri.AppendPath("/jobs/", false);
            uri.AppendPath(jobName, true);
            uri.AppendPath("/streams", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("clientRequestId", clientRequestId);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of jobs streams identified by job name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStreamListResult>> ListByJobAsync(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var message = CreateListByJobRequest(subscriptionId, resourceGroupName, automationAccountName, jobName, filter, clientRequestId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of jobs streams identified by job name. </summary>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStreamListResult> ListByJob(string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var message = CreateListByJobRequest(subscriptionId, resourceGroupName, automationAccountName, jobName, filter, clientRequestId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByJobNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter, string clientRequestId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByJobNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter, string clientRequestId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            if (clientRequestId != null)
            {
                request.Headers.Add("clientRequestId", clientRequestId);
            }
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieve a list of jobs streams identified by job name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AutomationJobStreamListResult>> ListByJobNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var message = CreateListByJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, jobName, filter, clientRequestId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieve a list of jobs streams identified by job name. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> Name of an Azure Resource group. </param>
        /// <param name="automationAccountName"> The name of the automation account. </param>
        /// <param name="jobName"> The job name. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="clientRequestId"> Identifies this specific client request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="automationAccountName"/> or <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AutomationJobStreamListResult> ListByJobNextPage(string nextLink, string subscriptionId, string resourceGroupName, string automationAccountName, string jobName, string filter = null, string clientRequestId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(automationAccountName, nameof(automationAccountName));
            Argument.AssertNotNullOrEmpty(jobName, nameof(jobName));

            using var message = CreateListByJobNextPageRequest(nextLink, subscriptionId, resourceGroupName, automationAccountName, jobName, filter, clientRequestId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AutomationJobStreamListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = AutomationJobStreamListResult.DeserializeAutomationJobStreamListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
