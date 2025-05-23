// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class WebSiteSlotExtensionOperationSource : IOperationSource<WebSiteSlotExtensionResource>
    {
        private readonly ArmClient _client;

        internal WebSiteSlotExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebSiteSlotExtensionResource IOperationSource<WebSiteSlotExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SiteExtensionInfoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppServiceContext.Default);
            return new WebSiteSlotExtensionResource(_client, data);
        }

        async ValueTask<WebSiteSlotExtensionResource> IOperationSource<WebSiteSlotExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SiteExtensionInfoData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppServiceContext.Default);
            return await Task.FromResult(new WebSiteSlotExtensionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
