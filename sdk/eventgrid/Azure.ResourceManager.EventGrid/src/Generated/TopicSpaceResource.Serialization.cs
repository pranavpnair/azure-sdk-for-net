// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicSpaceResource : IJsonModel<TopicSpaceData>
    {
        void IJsonModel<TopicSpaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TopicSpaceData>)Data).Write(writer, options);

        TopicSpaceData IJsonModel<TopicSpaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TopicSpaceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TopicSpaceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TopicSpaceData>(Data, options, AzureResourceManagerEventGridContext.Default);

        TopicSpaceData IPersistableModel<TopicSpaceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TopicSpaceData>(data, options, AzureResourceManagerEventGridContext.Default);

        string IPersistableModel<TopicSpaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TopicSpaceData>)Data).GetFormatFromOptions(options);
    }
}
