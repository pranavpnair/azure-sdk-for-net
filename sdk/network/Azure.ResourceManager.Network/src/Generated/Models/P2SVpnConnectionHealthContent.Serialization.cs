// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class P2SVpnConnectionHealthContent : IUtf8JsonSerializable, IJsonModel<P2SVpnConnectionHealthContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<P2SVpnConnectionHealthContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<P2SVpnConnectionHealthContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnConnectionHealthContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SVpnConnectionHealthContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(VpnUserNamesFilter))
            {
                writer.WritePropertyName("vpnUserNamesFilter"u8);
                writer.WriteStartArray();
                foreach (var item in VpnUserNamesFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OutputBlobSasUri))
            {
                writer.WritePropertyName("outputBlobSasUrl"u8);
                writer.WriteStringValue(OutputBlobSasUri.AbsoluteUri);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        P2SVpnConnectionHealthContent IJsonModel<P2SVpnConnectionHealthContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnConnectionHealthContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SVpnConnectionHealthContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeP2SVpnConnectionHealthContent(document.RootElement, options);
        }

        internal static P2SVpnConnectionHealthContent DeserializeP2SVpnConnectionHealthContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> vpnUserNamesFilter = default;
            Uri outputBlobSasUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnUserNamesFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vpnUserNamesFilter = array;
                    continue;
                }
                if (property.NameEquals("outputBlobSasUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputBlobSasUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new P2SVpnConnectionHealthContent(vpnUserNamesFilter ?? new ChangeTrackingList<string>(), outputBlobSasUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<P2SVpnConnectionHealthContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnConnectionHealthContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(P2SVpnConnectionHealthContent)} does not support writing '{options.Format}' format.");
            }
        }

        P2SVpnConnectionHealthContent IPersistableModel<P2SVpnConnectionHealthContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SVpnConnectionHealthContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeP2SVpnConnectionHealthContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(P2SVpnConnectionHealthContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<P2SVpnConnectionHealthContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
