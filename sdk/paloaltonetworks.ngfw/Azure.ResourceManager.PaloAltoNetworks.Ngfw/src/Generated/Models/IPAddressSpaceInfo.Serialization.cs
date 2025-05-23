// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class IPAddressSpaceInfo : IUtf8JsonSerializable, IJsonModel<IPAddressSpaceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPAddressSpaceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IPAddressSpaceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPAddressSpaceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPAddressSpaceInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace"u8);
                writer.WriteStringValue(AddressSpace);
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

        IPAddressSpaceInfo IJsonModel<IPAddressSpaceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPAddressSpaceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPAddressSpaceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPAddressSpaceInfo(document.RootElement, options);
        }

        internal static IPAddressSpaceInfo DeserializeIPAddressSpaceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            string addressSpace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressSpace"u8))
                {
                    addressSpace = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IPAddressSpaceInfo(resourceId, addressSpace, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPAddressSpaceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPAddressSpaceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerPaloAltoNetworksNgfwContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IPAddressSpaceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        IPAddressSpaceInfo IPersistableModel<IPAddressSpaceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPAddressSpaceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIPAddressSpaceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IPAddressSpaceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPAddressSpaceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
