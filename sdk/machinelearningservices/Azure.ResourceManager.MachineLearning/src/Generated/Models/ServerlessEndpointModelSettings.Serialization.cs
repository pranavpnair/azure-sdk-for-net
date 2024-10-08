// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class ServerlessEndpointModelSettings : IUtf8JsonSerializable, IJsonModel<ServerlessEndpointModelSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerlessEndpointModelSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServerlessEndpointModelSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessEndpointModelSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessEndpointModelSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ServerlessEndpointModelSettings IJsonModel<ServerlessEndpointModelSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessEndpointModelSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessEndpointModelSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerlessEndpointModelSettings(document.RootElement, options);
        }

        internal static ServerlessEndpointModelSettings DeserializeServerlessEndpointModelSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ServerlessEndpointModelSettings(modelId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerlessEndpointModelSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessEndpointModelSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerlessEndpointModelSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ServerlessEndpointModelSettings IPersistableModel<ServerlessEndpointModelSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessEndpointModelSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerlessEndpointModelSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerlessEndpointModelSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerlessEndpointModelSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
