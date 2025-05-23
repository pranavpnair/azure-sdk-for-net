// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AdaptiveApplicationControlIssueSummary : IUtf8JsonSerializable, IJsonModel<AdaptiveApplicationControlIssueSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdaptiveApplicationControlIssueSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdaptiveApplicationControlIssueSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlIssueSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdaptiveApplicationControlIssueSummary)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Issue))
            {
                writer.WritePropertyName("issue"u8);
                writer.WriteStringValue(Issue.Value.ToString());
            }
            if (Optional.IsDefined(NumberOfVms))
            {
                writer.WritePropertyName("numberOfVms"u8);
                writer.WriteNumberValue(NumberOfVms.Value);
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

        AdaptiveApplicationControlIssueSummary IJsonModel<AdaptiveApplicationControlIssueSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlIssueSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdaptiveApplicationControlIssueSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdaptiveApplicationControlIssueSummary(document.RootElement, options);
        }

        internal static AdaptiveApplicationControlIssueSummary DeserializeAdaptiveApplicationControlIssueSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdaptiveApplicationControlIssue? issue = default;
            float? numberOfVms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issue = new AdaptiveApplicationControlIssue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("numberOfVms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfVms = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdaptiveApplicationControlIssueSummary(issue, numberOfVms, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdaptiveApplicationControlIssueSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlIssueSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AdaptiveApplicationControlIssueSummary)} does not support writing '{options.Format}' format.");
            }
        }

        AdaptiveApplicationControlIssueSummary IPersistableModel<AdaptiveApplicationControlIssueSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdaptiveApplicationControlIssueSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAdaptiveApplicationControlIssueSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdaptiveApplicationControlIssueSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdaptiveApplicationControlIssueSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
