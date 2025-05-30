// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs
{
    internal class DevTestLabUserOperationSource : IOperationSource<DevTestLabUserResource>
    {
        private readonly ArmClient _client;

        internal DevTestLabUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevTestLabUserResource IOperationSource<DevTestLabUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabUserData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return new DevTestLabUserResource(_client, data);
        }

        async ValueTask<DevTestLabUserResource> IOperationSource<DevTestLabUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabUserData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return await Task.FromResult(new DevTestLabUserResource(_client, data)).ConfigureAwait(false);
        }
    }
}
