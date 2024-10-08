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
    public partial class EndpointModelSkuRateLimitProperties : IUtf8JsonSerializable, IJsonModel<EndpointModelSkuRateLimitProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointModelSkuRateLimitProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EndpointModelSkuRateLimitProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointModelSkuRateLimitProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointModelSkuRateLimitProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(RenewalPeriod))
            {
                writer.WritePropertyName("renewalPeriod"u8);
                writer.WriteNumberValue(RenewalPeriod.Value);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        EndpointModelSkuRateLimitProperties IJsonModel<EndpointModelSkuRateLimitProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointModelSkuRateLimitProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointModelSkuRateLimitProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointModelSkuRateLimitProperties(document.RootElement, options);
        }

        internal static EndpointModelSkuRateLimitProperties DeserializeEndpointModelSkuRateLimitProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? count = default;
            float? renewalPeriod = default;
            IReadOnlyList<EndpointModelSkuRateLimitRuleProperties> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EndpointModelSkuRateLimitRuleProperties> array = new List<EndpointModelSkuRateLimitRuleProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EndpointModelSkuRateLimitRuleProperties.DeserializeEndpointModelSkuRateLimitRuleProperties(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EndpointModelSkuRateLimitProperties(count, renewalPeriod, rules ?? new ChangeTrackingList<EndpointModelSkuRateLimitRuleProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointModelSkuRateLimitProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointModelSkuRateLimitProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointModelSkuRateLimitProperties)} does not support writing '{options.Format}' format.");
            }
        }

        EndpointModelSkuRateLimitProperties IPersistableModel<EndpointModelSkuRateLimitProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointModelSkuRateLimitProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEndpointModelSkuRateLimitProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointModelSkuRateLimitProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointModelSkuRateLimitProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
