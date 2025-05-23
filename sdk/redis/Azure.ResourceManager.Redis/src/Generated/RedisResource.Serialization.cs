// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisResource : IJsonModel<RedisData>
    {
        void IJsonModel<RedisData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisData>)Data).Write(writer, options);

        RedisData IJsonModel<RedisData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RedisData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RedisData>(Data, options, AzureResourceManagerRedisContext.Default);

        RedisData IPersistableModel<RedisData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisData>(data, options, AzureResourceManagerRedisContext.Default);

        string IPersistableModel<RedisData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisData>)Data).GetFormatFromOptions(options);
    }
}
