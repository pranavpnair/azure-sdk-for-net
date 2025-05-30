// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class RouteMapResource : IJsonModel<RouteMapData>
    {
        void IJsonModel<RouteMapData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RouteMapData>)Data).Write(writer, options);

        RouteMapData IJsonModel<RouteMapData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RouteMapData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RouteMapData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RouteMapData>(Data, options, AzureResourceManagerNetworkContext.Default);

        RouteMapData IPersistableModel<RouteMapData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RouteMapData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<RouteMapData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RouteMapData>)Data).GetFormatFromOptions(options);
    }
}
