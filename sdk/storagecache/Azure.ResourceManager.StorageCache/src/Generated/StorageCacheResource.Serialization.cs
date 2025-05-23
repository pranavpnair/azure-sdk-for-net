// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.StorageCache
{
    public partial class StorageCacheResource : IJsonModel<StorageCacheData>
    {
        void IJsonModel<StorageCacheData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<StorageCacheData>)Data).Write(writer, options);

        StorageCacheData IJsonModel<StorageCacheData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<StorageCacheData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<StorageCacheData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<StorageCacheData>(Data, options, AzureResourceManagerStorageCacheContext.Default);

        StorageCacheData IPersistableModel<StorageCacheData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<StorageCacheData>(data, options, AzureResourceManagerStorageCacheContext.Default);

        string IPersistableModel<StorageCacheData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<StorageCacheData>)Data).GetFormatFromOptions(options);
    }
}
