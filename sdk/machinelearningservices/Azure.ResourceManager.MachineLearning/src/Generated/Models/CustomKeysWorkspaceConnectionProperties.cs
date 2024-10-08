// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Category:= CustomKeys
    /// AuthType:= CustomKeys (as type discriminator)
    /// Credentials:= {CustomKeys} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.CustomKeys
    /// Target:= {any value}
    /// Use Metadata property bag for ApiVersion and other metadata fields
    /// </summary>
    public partial class CustomKeysWorkspaceConnectionProperties : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="CustomKeysWorkspaceConnectionProperties"/>. </summary>
        public CustomKeysWorkspaceConnectionProperties()
        {
            AuthType = MachineLearningConnectionAuthType.CustomKeys;
        }

        /// <summary> Initializes a new instance of <see cref="CustomKeysWorkspaceConnectionProperties"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="createdByWorkspaceArmId"></param>
        /// <param name="error"></param>
        /// <param name="expiryOn"></param>
        /// <param name="group"> Group based on connection category. </param>
        /// <param name="isSharedToAll"></param>
        /// <param name="metadata"> Store user metadata for this connection. </param>
        /// <param name="peRequirement"></param>
        /// <param name="peStatus"></param>
        /// <param name="sharedUserList"></param>
        /// <param name="target"></param>
        /// <param name="useWorkspaceManagedIdentity"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials"> Custom Keys credential object. </param>
        internal CustomKeysWorkspaceConnectionProperties(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, ResourceIdentifier createdByWorkspaceArmId, string error, DateTimeOffset? expiryOn, ConnectionGroup? group, bool? isSharedToAll, IDictionary<string, string> metadata, ManagedPERequirement? peRequirement, ManagedPEStatus? peStatus, IList<string> sharedUserList, string target, bool? useWorkspaceManagedIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData, CustomKeys credentials) : base(authType, category, createdByWorkspaceArmId, error, expiryOn, group, isSharedToAll, metadata, peRequirement, peStatus, sharedUserList, target, useWorkspaceManagedIdentity, serializedAdditionalRawData)
        {
            Credentials = credentials;
            AuthType = authType;
        }

        /// <summary> Custom Keys credential object. </summary>
        internal CustomKeys Credentials { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> CredentialsKeys
        {
            get
            {
                if (Credentials is null)
                    Credentials = new CustomKeys();
                return Credentials.Keys;
            }
        }
    }
}
