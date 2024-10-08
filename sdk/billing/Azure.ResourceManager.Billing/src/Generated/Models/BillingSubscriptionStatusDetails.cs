// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The suspension details for a subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
    public partial class BillingSubscriptionStatusDetails
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

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionStatusDetails"/>. </summary>
        internal BillingSubscriptionStatusDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionStatusDetails"/>. </summary>
        /// <param name="effectiveOn"> The suspension effective date for a subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="reason"> The suspension reason for a subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSubscriptionStatusDetails(DateTimeOffset? effectiveOn, SubscriptionStatusReason? reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EffectiveOn = effectiveOn;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The suspension effective date for a subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        [WirePath("effectiveDate")]
        public DateTimeOffset? EffectiveOn { get; }
        /// <summary> The suspension reason for a subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        [WirePath("reason")]
        public SubscriptionStatusReason? Reason { get; }
    }
}
