// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeClientEventConversationItemTruncate : IJsonModel<InternalRealtimeClientEventConversationItemTruncate>
    {
        void IJsonModel<InternalRealtimeClientEventConversationItemTruncate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemTruncate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("item_id") != true)
            {
                writer.WritePropertyName("item_id"u8);
                writer.WriteStringValue(ItemId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("content_index") != true)
            {
                writer.WritePropertyName("content_index"u8);
                writer.WriteNumberValue(ContentIndex);
            }
            if (SerializedAdditionalRawData?.ContainsKey("audio_end_ms") != true)
            {
                writer.WritePropertyName("audio_end_ms"u8);
                writer.WriteNumberValue(AudioEndMs);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("event_id") != true && Optional.IsDefined(EventId))
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

        InternalRealtimeClientEventConversationItemTruncate IJsonModel<InternalRealtimeClientEventConversationItemTruncate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemTruncate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeClientEventConversationItemTruncate(document.RootElement, options);
        }

        internal static InternalRealtimeClientEventConversationItemTruncate DeserializeInternalRealtimeClientEventConversationItemTruncate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string itemId = default;
            int contentIndex = default;
            int audioEndMs = default;
            InternalRealtimeClientEventType type = default;
            string eventId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("item_id"u8))
                {
                    itemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content_index"u8))
                {
                    contentIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("audio_end_ms"u8))
                {
                    audioEndMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new InternalRealtimeClientEventType(property.Value.GetString());
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
            return new InternalRealtimeClientEventConversationItemTruncate(
                type,
                eventId,
                serializedAdditionalRawData,
                itemId,
                contentIndex,
                audioEndMs);
        }

        BinaryData IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemTruncate)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeClientEventConversationItemTruncate IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRealtimeClientEventConversationItemTruncate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeClientEventConversationItemTruncate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeClientEventConversationItemTruncate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalRealtimeClientEventConversationItemTruncate FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeClientEventConversationItemTruncate(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
