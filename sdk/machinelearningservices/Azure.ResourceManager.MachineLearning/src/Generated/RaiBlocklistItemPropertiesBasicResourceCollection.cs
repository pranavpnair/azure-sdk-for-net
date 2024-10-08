// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="RaiBlocklistItemPropertiesBasicResource"/> and their operations.
    /// Each <see cref="RaiBlocklistItemPropertiesBasicResource"/> in the collection will belong to the same instance of <see cref="RaiBlocklistPropertiesBasicResource"/>.
    /// To get a <see cref="RaiBlocklistItemPropertiesBasicResourceCollection"/> instance call the GetRaiBlocklistItemPropertiesBasicResources method from an instance of <see cref="RaiBlocklistPropertiesBasicResource"/>.
    /// </summary>
    public partial class RaiBlocklistItemPropertiesBasicResourceCollection : ArmCollection, IEnumerable<RaiBlocklistItemPropertiesBasicResource>, IAsyncEnumerable<RaiBlocklistItemPropertiesBasicResource>
    {
        private readonly ClientDiagnostics _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics;
        private readonly ConnectionRaiBlocklistItemRestOperations _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient;
        private readonly ClientDiagnostics _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsClientDiagnostics;
        private readonly ConnectionRaiBlocklistItemsRestOperations _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RaiBlocklistItemPropertiesBasicResourceCollection"/> class for mocking. </summary>
        protected RaiBlocklistItemPropertiesBasicResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RaiBlocklistItemPropertiesBasicResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RaiBlocklistItemPropertiesBasicResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", RaiBlocklistItemPropertiesBasicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RaiBlocklistItemPropertiesBasicResource.ResourceType, out string raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemApiVersion);
            _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient = new ConnectionRaiBlocklistItemRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemApiVersion);
            _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", RaiBlocklistItemPropertiesBasicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RaiBlocklistItemPropertiesBasicResource.ResourceType, out string raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsApiVersion);
            _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient = new ConnectionRaiBlocklistItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RaiBlocklistPropertiesBasicResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RaiBlocklistPropertiesBasicResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Update the state of specified blocklist item associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="data"> The <see cref="RaiBlocklistItemPropertiesBasicResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RaiBlocklistItemPropertiesBasicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string raiBlocklistItemName, RaiBlocklistItemPropertiesBasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<RaiBlocklistItemPropertiesBasicResource>(new RaiBlocklistItemPropertiesBasicResourceOperationSource(Client), _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics, Pipeline, _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the state of specified blocklist item associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="data"> The <see cref="RaiBlocklistItemPropertiesBasicResourceData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RaiBlocklistItemPropertiesBasicResource> CreateOrUpdate(WaitUntil waitUntil, string raiBlocklistItemName, RaiBlocklistItemPropertiesBasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<RaiBlocklistItemPropertiesBasicResource>(new RaiBlocklistItemPropertiesBasicResourceOperationSource(Client), _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics, Pipeline, _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified custom blocklist item associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<Response<RaiBlocklistItemPropertiesBasicResource>> GetAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemPropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified custom blocklist item associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual Response<RaiBlocklistItemPropertiesBasicResource> Get(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemPropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the custom blocklist items associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RaiBlocklistItemPropertiesBasicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RaiBlocklistItemPropertiesBasicResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RaiBlocklistItemPropertiesBasicResource(Client, RaiBlocklistItemPropertiesBasicResourceData.DeserializeRaiBlocklistItemPropertiesBasicResourceData(e)), _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsClientDiagnostics, Pipeline, "RaiBlocklistItemPropertiesBasicResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the custom blocklist items associated with the Azure OpenAI connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RaiBlocklistItemPropertiesBasicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RaiBlocklistItemPropertiesBasicResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RaiBlocklistItemPropertiesBasicResource(Client, RaiBlocklistItemPropertiesBasicResourceData.DeserializeRaiBlocklistItemPropertiesBasicResourceData(e)), _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemsClientDiagnostics, Pipeline, "RaiBlocklistItemPropertiesBasicResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual Response<bool> Exists(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual async Task<NullableResponse<RaiBlocklistItemPropertiesBasicResource>> GetIfExistsAsync(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RaiBlocklistItemPropertiesBasicResource>(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemPropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}/raiBlocklists/{raiBlocklistName}/raiBlocklistItems/{raiBlocklistItemName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectionRaiBlocklistItem_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RaiBlocklistItemPropertiesBasicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="raiBlocklistItemName"> Name of the RaiBlocklist Item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="raiBlocklistItemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="raiBlocklistItemName"/> is null. </exception>
        public virtual NullableResponse<RaiBlocklistItemPropertiesBasicResource> GetIfExists(string raiBlocklistItemName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(raiBlocklistItemName, nameof(raiBlocklistItemName));

            using var scope = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemClientDiagnostics.CreateScope("RaiBlocklistItemPropertiesBasicResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _raiBlocklistItemPropertiesBasicResourceConnectionRaiBlocklistItemRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, raiBlocklistItemName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RaiBlocklistItemPropertiesBasicResource>(response.GetRawResponse());
                return Response.FromValue(new RaiBlocklistItemPropertiesBasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RaiBlocklistItemPropertiesBasicResource> IEnumerable<RaiBlocklistItemPropertiesBasicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RaiBlocklistItemPropertiesBasicResource> IAsyncEnumerable<RaiBlocklistItemPropertiesBasicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
