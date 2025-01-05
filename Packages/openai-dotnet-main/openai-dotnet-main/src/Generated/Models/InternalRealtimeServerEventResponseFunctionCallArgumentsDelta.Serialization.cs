// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeServerEventResponseFunctionCallArgumentsDelta : IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>
    {
        void IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("response_id") != true)
            {
                writer.WritePropertyName("response_id"u8);
                writer.WriteStringValue(ResponseId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("output_index") != true)
            {
                writer.WritePropertyName("output_index"u8);
                writer.WriteNumberValue(OutputIndex);
            }
            if (SerializedAdditionalRawData?.ContainsKey("call_id") != true)
            {
                writer.WritePropertyName("call_id"u8);
                writer.WriteStringValue(CallId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("delta") != true)
            {
                writer.WritePropertyName("delta"u8);
                writer.WriteStringValue(Delta);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("event_id") != true)
            {
                writer.WritePropertyName("event_id"u8);
                writer.WriteStringValue(EventId);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        InternalRealtimeServerEventResponseFunctionCallArgumentsDelta IJsonModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(document.RootElement, options);
        }

        internal static InternalRealtimeServerEventResponseFunctionCallArgumentsDelta DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string responseId = default;
            string itemId = default;
            int outputIndex = default;
            string callId = default;
            string delta = default;
            ConversationUpdateKind type = default;
            string eventId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response_id"u8))
                {
                    responseId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("item_id"u8))
                {
                    itemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output_index"u8))
                {
                    outputIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("call_id"u8))
                {
                    callId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    delta = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToConversationUpdateKind();
                    continue;
                }
                if (property.NameEquals("event_id"u8))
                {
                    eventId = property.Value.GetString();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRealtimeServerEventResponseFunctionCallArgumentsDelta(
                type,
                eventId,
                serializedAdditionalRawData,
                responseId,
                itemId,
                outputIndex,
                callId,
                delta);
        }

        BinaryData IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeServerEventResponseFunctionCallArgumentsDelta IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventResponseFunctionCallArgumentsDelta)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeServerEventResponseFunctionCallArgumentsDelta>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalRealtimeServerEventResponseFunctionCallArgumentsDelta FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeServerEventResponseFunctionCallArgumentsDelta(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
