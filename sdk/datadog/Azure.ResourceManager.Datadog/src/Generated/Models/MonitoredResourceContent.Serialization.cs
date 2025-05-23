// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitoredResourceContent : IUtf8JsonSerializable, IJsonModel<MonitoredResourceContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitoredResourceContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitoredResourceContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SendingMetrics))
            {
                writer.WritePropertyName("sendingMetrics"u8);
                writer.WriteBooleanValue(SendingMetrics.Value);
            }
            if (Optional.IsDefined(ReasonForMetricsStatus))
            {
                writer.WritePropertyName("reasonForMetricsStatus"u8);
                writer.WriteStringValue(ReasonForMetricsStatus);
            }
            if (Optional.IsDefined(SendingLogs))
            {
                writer.WritePropertyName("sendingLogs"u8);
                writer.WriteBooleanValue(SendingLogs.Value);
            }
            if (Optional.IsDefined(ReasonForLogsStatus))
            {
                writer.WritePropertyName("reasonForLogsStatus"u8);
                writer.WriteStringValue(ReasonForLogsStatus);
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

        MonitoredResourceContent IJsonModel<MonitoredResourceContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitoredResourceContent(document.RootElement, options);
        }

        internal static MonitoredResourceContent DeserializeMonitoredResourceContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            bool? sendingMetrics = default;
            string reasonForMetricsStatus = default;
            bool? sendingLogs = default;
            string reasonForLogsStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"u8))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendingLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"u8))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitoredResourceContent(
                id,
                sendingMetrics,
                reasonForMetricsStatus,
                sendingLogs,
                reasonForLogsStatus,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitoredResourceContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDatadogContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support writing '{options.Format}' format.");
            }
        }

        MonitoredResourceContent IPersistableModel<MonitoredResourceContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitoredResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMonitoredResourceContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitoredResourceContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitoredResourceContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
