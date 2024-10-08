// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Returns metadata about the os patching. </summary>
    public partial class OSPatchingStatus
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

        /// <summary> Initializes a new instance of <see cref="OSPatchingStatus"/>. </summary>
        internal OSPatchingStatus()
        {
            OSPatchingErrors = new ChangeTrackingList<MachineLearningError>();
        }

        /// <summary> Initializes a new instance of <see cref="OSPatchingStatus"/>. </summary>
        /// <param name="patchStatus"> The os patching status. </param>
        /// <param name="latestPatchOn"> Time of the latest os patching. </param>
        /// <param name="rebootPending"> Specifies whether this compute instance is pending for reboot to finish os patching. </param>
        /// <param name="scheduledRebootOn"> Time of scheduled reboot. </param>
        /// <param name="osPatchingErrors"> Collection of errors encountered when doing os patching. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSPatchingStatus(PatchStatus? patchStatus, DateTimeOffset? latestPatchOn, bool? rebootPending, DateTimeOffset? scheduledRebootOn, IReadOnlyList<MachineLearningError> osPatchingErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PatchStatus = patchStatus;
            LatestPatchOn = latestPatchOn;
            RebootPending = rebootPending;
            ScheduledRebootOn = scheduledRebootOn;
            OSPatchingErrors = osPatchingErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The os patching status. </summary>
        public PatchStatus? PatchStatus { get; }
        /// <summary> Time of the latest os patching. </summary>
        public DateTimeOffset? LatestPatchOn { get; }
        /// <summary> Specifies whether this compute instance is pending for reboot to finish os patching. </summary>
        public bool? RebootPending { get; }
        /// <summary> Time of scheduled reboot. </summary>
        public DateTimeOffset? ScheduledRebootOn { get; }
        /// <summary> Collection of errors encountered when doing os patching. </summary>
        public IReadOnlyList<MachineLearningError> OSPatchingErrors { get; }
    }
}
