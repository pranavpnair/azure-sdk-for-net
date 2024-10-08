// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> A policy at billing profile scope. </summary>
    public partial class BillingProfilePolicyProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingProfilePolicyProperties"/>. </summary>
        public BillingProfilePolicyProperties()
        {
            Policies = new ChangeTrackingList<BillingPolicySummary>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingProfilePolicyProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the resource during a long-running operation. </param>
        /// <param name="enterpriseAgreementPolicies"> The policies for Enterprise Agreement enrollments. </param>
        /// <param name="invoiceSectionLabelManagement"> The policy that controls invoice section label management at invoice section scope. This is allowed by default. </param>
        /// <param name="marketplacePurchases"> The policy that controls whether Azure marketplace purchases are allowed. </param>
        /// <param name="reservationPurchases"> The policy that controls whether Azure reservation purchases are allowed. </param>
        /// <param name="savingsPlanPurchases"> The policy that controls whether users with Azure savings plan purchase are allowed. </param>
        /// <param name="viewCharges"> The policy that controls whether the users in customer's organization can view charges at pay-as-you-go prices. </param>
        /// <param name="policies"> List of all policies defined at the billing scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingProfilePolicyProperties(BillingProvisioningState? provisioningState, EnterpriseAgreementPolicies enterpriseAgreementPolicies, InvoiceSectionLabelManagementPolicy? invoiceSectionLabelManagement, MarketplacePurchasesPolicy? marketplacePurchases, ReservationPurchasesPolicy? reservationPurchases, SavingsPlanPurchasesPolicy? savingsPlanPurchases, ViewChargesPolicy? viewCharges, IList<BillingPolicySummary> policies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            EnterpriseAgreementPolicies = enterpriseAgreementPolicies;
            InvoiceSectionLabelManagement = invoiceSectionLabelManagement;
            MarketplacePurchases = marketplacePurchases;
            ReservationPurchases = reservationPurchases;
            SavingsPlanPurchases = savingsPlanPurchases;
            ViewCharges = viewCharges;
            Policies = policies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the resource during a long-running operation. </summary>
        [WirePath("provisioningState")]
        public BillingProvisioningState? ProvisioningState { get; }
        /// <summary> The policies for Enterprise Agreement enrollments. </summary>
        [WirePath("enterpriseAgreementPolicies")]
        public EnterpriseAgreementPolicies EnterpriseAgreementPolicies { get; set; }
        /// <summary> The policy that controls invoice section label management at invoice section scope. This is allowed by default. </summary>
        [WirePath("invoiceSectionLabelManagement")]
        public InvoiceSectionLabelManagementPolicy? InvoiceSectionLabelManagement { get; set; }
        /// <summary> The policy that controls whether Azure marketplace purchases are allowed. </summary>
        [WirePath("marketplacePurchases")]
        public MarketplacePurchasesPolicy? MarketplacePurchases { get; set; }
        /// <summary> The policy that controls whether Azure reservation purchases are allowed. </summary>
        [WirePath("reservationPurchases")]
        public ReservationPurchasesPolicy? ReservationPurchases { get; set; }
        /// <summary> The policy that controls whether users with Azure savings plan purchase are allowed. </summary>
        [WirePath("savingsPlanPurchases")]
        public SavingsPlanPurchasesPolicy? SavingsPlanPurchases { get; set; }
        /// <summary> The policy that controls whether the users in customer's organization can view charges at pay-as-you-go prices. </summary>
        [WirePath("viewCharges")]
        public ViewChargesPolicy? ViewCharges { get; set; }
        /// <summary> List of all policies defined at the billing scope. </summary>
        [WirePath("policies")]
        public IList<BillingPolicySummary> Policies { get; }
    }
}
