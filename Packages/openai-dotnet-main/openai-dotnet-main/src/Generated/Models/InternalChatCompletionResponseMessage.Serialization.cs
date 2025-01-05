// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionResponseMessage : IJsonModel<InternalChatCompletionResponseMessage>
    {
        void IJsonModel<InternalChatCompletionResponseMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionResponseMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionResponseMessage)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("content") != true)
            {
                if (Content != null)
                {
                    writer.WritePropertyName("content"u8);
                    SerializeContentValue(writer, options);
                }
                else
                {
                    writer.WriteNull("content");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("refusal") != true)
            {
                if (Refusal != null)
                {
                    writer.WritePropertyName("refusal"u8);
                    writer.WriteStringValue(Refusal);
                }
                else
                {
                    writer.WriteNull("refusal");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("tool_calls") != true && Optional.IsCollectionDefined(ToolCalls))
            {
                writer.WritePropertyName("tool_calls"u8);
                writer.WriteStartArray();
                foreach (var item in ToolCalls)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("role") != true)
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("function_call") != true && Optional.IsDefined(FunctionCall))
            {
                writer.WritePropertyName("function_call"u8);
                writer.WriteObjectValue<ChatFunctionCall>(FunctionCall, options);
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

        InternalChatCompletionResponseMessage IJsonModel<InternalChatCompletionResponseMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionResponseMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatCompletionResponseMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatCompletionResponseMessage(document.RootElement, options);
        }

        internal static InternalChatCompletionResponseMessage DeserializeInternalChatCompletionResponseMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatMessageContent content = default;
            string refusal = default;
            IReadOnlyList<ChatToolCall> toolCalls = default;
            ChatMessageRole role = default;
            ChatFunctionCall functionCall = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    DeserializeContentValue(property, ref content);
                    continue;
                }
                if (property.NameEquals("refusal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        refusal = null;
                        continue;
                    }
                    refusal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatToolCall> array = new List<ChatToolCall>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatToolCall.DeserializeChatToolCall(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString().ToChatMessageRole();
                    continue;
                }
                if (property.NameEquals("function_call"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionCall = ChatFunctionCall.DeserializeChatFunctionCall(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            // CUSTOM: Initialize Content collection property.
            return new InternalChatCompletionResponseMessage(
                content ?? new ChatMessageContent(),
                refusal,
                toolCalls ?? new ChangeTrackingList<ChatToolCall>(),
                role,
                functionCall,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalChatCompletionResponseMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionResponseMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionResponseMessage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatCompletionResponseMessage IPersistableModel<InternalChatCompletionResponseMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalChatCompletionResponseMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalChatCompletionResponseMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatCompletionResponseMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatCompletionResponseMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalChatCompletionResponseMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalChatCompletionResponseMessage(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}