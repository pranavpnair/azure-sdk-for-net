// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Credential for docker with username and password. </summary>
    public partial class DockerCredential : DataReferenceCredential
    {
        /// <summary> Initializes a new instance of <see cref="DockerCredential"/>. </summary>
        internal DockerCredential()
        {
            CredentialType = DataReferenceCredentialType.DockerCredentials;
        }

        /// <summary> Initializes a new instance of <see cref="DockerCredential"/>. </summary>
        /// <param name="credentialType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="password"> DockerCredential user password. </param>
        /// <param name="userName"> DockerCredential user name. </param>
        internal DockerCredential(DataReferenceCredentialType credentialType, IDictionary<string, BinaryData> serializedAdditionalRawData, string password, string userName) : base(credentialType, serializedAdditionalRawData)
        {
            Password = password;
            UserName = userName;
            CredentialType = credentialType;
        }

        /// <summary> DockerCredential user password. </summary>
        public string Password { get; }
        /// <summary> DockerCredential user name. </summary>
        public string UserName { get; }
    }
}
