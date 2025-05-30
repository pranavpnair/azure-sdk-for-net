// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppVolumeResource : IJsonModel<NetAppVolumeData>
    {
        void IJsonModel<NetAppVolumeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetAppVolumeData>)Data).Write(writer, options);

        NetAppVolumeData IJsonModel<NetAppVolumeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetAppVolumeData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetAppVolumeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetAppVolumeData>(Data, options, AzureResourceManagerNetAppContext.Default);

        NetAppVolumeData IPersistableModel<NetAppVolumeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetAppVolumeData>(data, options, AzureResourceManagerNetAppContext.Default);

        string IPersistableModel<NetAppVolumeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetAppVolumeData>)Data).GetFormatFromOptions(options);
    }
}
