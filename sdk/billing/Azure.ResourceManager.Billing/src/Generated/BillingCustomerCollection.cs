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
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingCustomerResource"/> and their operations.
    /// Each <see cref="BillingCustomerResource"/> in the collection will belong to the same instance of <see cref="BillingAccountResource"/>.
    /// To get a <see cref="BillingCustomerCollection"/> instance call the GetBillingCustomers method from an instance of <see cref="BillingAccountResource"/>.
    /// </summary>
    public partial class BillingCustomerCollection : ArmCollection, IEnumerable<BillingCustomerResource>, IAsyncEnumerable<BillingCustomerResource>
    {
        private readonly ClientDiagnostics _billingCustomerCustomersClientDiagnostics;
        private readonly CustomersRestOperations _billingCustomerCustomersRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingCustomerCollection"/> class for mocking. </summary>
        protected BillingCustomerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingCustomerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingCustomerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingCustomerCustomersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingCustomerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingCustomerResource.ResourceType, out string billingCustomerCustomersApiVersion);
            _billingCustomerCustomersRestClient = new CustomersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingCustomerCustomersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a customer by its ID at billing account level. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual async Task<Response<BillingCustomerResource>> GetAsync(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingCustomerCustomersRestClient.GetByBillingAccountAsync(Id.Name, customerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a customer by its ID at billing account level. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual Response<BillingCustomerResource> Get(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.Get");
            scope.Start();
            try
            {
                var response = _billingCustomerCustomersRestClient.GetByBillingAccount(Id.Name, customerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the customers that are billed to a billing account. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingCustomerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingCustomerResource> GetAllAsync(BillingCustomerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingCustomerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingCustomerCustomersRestClient.CreateListByBillingAccountRequest(Id.Name, options.Expand, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingCustomerCustomersRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.Expand, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingCustomerResource(Client, BillingCustomerData.DeserializeBillingCustomerData(e)), _billingCustomerCustomersClientDiagnostics, Pipeline, "BillingCustomerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the customers that are billed to a billing account. The operation is supported only for billing accounts with agreement type Microsoft Partner Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingCustomerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingCustomerResource> GetAll(BillingCustomerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new BillingCustomerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingCustomerCustomersRestClient.CreateListByBillingAccountRequest(Id.Name, options.Expand, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingCustomerCustomersRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, options.Expand, options.Filter, options.OrderBy, options.Top, options.Skip, options.Count, options.Search);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingCustomerResource(Client, BillingCustomerData.DeserializeBillingCustomerData(e)), _billingCustomerCustomersClientDiagnostics, Pipeline, "BillingCustomerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingCustomerCustomersRestClient.GetByBillingAccountAsync(Id.Name, customerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual Response<bool> Exists(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingCustomerCustomersRestClient.GetByBillingAccount(Id.Name, customerName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingCustomerResource>> GetIfExistsAsync(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingCustomerCustomersRestClient.GetByBillingAccountAsync(Id.Name, customerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingCustomerResource>(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/customers/{customerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Customers_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingCustomerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customerName"/> is null. </exception>
        public virtual NullableResponse<BillingCustomerResource> GetIfExists(string customerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customerName, nameof(customerName));

            using var scope = _billingCustomerCustomersClientDiagnostics.CreateScope("BillingCustomerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingCustomerCustomersRestClient.GetByBillingAccount(Id.Name, customerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingCustomerResource>(response.GetRawResponse());
                return Response.FromValue(new BillingCustomerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingCustomerResource> IEnumerable<BillingCustomerResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<BillingCustomerResource> IAsyncEnumerable<BillingCustomerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
