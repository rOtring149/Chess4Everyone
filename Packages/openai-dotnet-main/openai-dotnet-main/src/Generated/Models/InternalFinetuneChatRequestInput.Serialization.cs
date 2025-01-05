// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI.Chat;

namespace OpenAI.FineTuning
{
    internal partial class InternalFinetuneChatRequestInput : IJsonModel<InternalFinetuneChatRequestInput>
    {
        void IJsonModel<InternalFinetuneChatRequestInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneChatRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFinetuneChatRequestInput)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("messages") != true && Optional.IsCollectionDefined(Messages))
            {
                writer.WritePropertyName("messages"u8);
                writer.WriteStartArray();
                foreach (var item in Messages)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("tools") != true && Optional.IsCollectionDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (SerializedAdditionalRawData?.ContainsKey("parallel_tool_calls") != true && Optional.IsDefined(ParallelToolCalls))
            {
                writer.WritePropertyName("parallel_tool_calls"u8);
                writer.WriteBooleanValue(ParallelToolCalls.Value);
            }
            if (SerializedAdditionalRawData?.ContainsKey("functions") != true && Optional.IsCollectionDefined(Functions))
            {
                writer.WritePropertyName("functions"u8);
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        InternalFinetuneChatRequestInput IJsonModel<InternalFinetuneChatRequestInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneChatRequestInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFinetuneChatRequestInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFinetuneChatRequestInput(document.RootElement, options);
        }

        internal static InternalFinetuneChatRequestInput DeserializeInternalFinetuneChatRequestInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BinaryData> messages = default;
            IList<ChatTool> tools = default;
            bool? parallelToolCalls = default;
            IList<ChatFunction> functions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    messages = array;
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatTool> array = new List<ChatTool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatTool.DeserializeChatTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("parallel_tool_calls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelToolCalls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("functions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatFunction> array = new List<ChatFunction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatFunction.DeserializeChatFunction(item, options));
                    }
                    functions = array;
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalFinetuneChatRequestInput(messages ?? new ChangeTrackingList<BinaryData>(), tools ?? new ChangeTrackingList<ChatTool>(), parallelToolCalls, functions ?? new ChangeTrackingList<ChatFunction>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalFinetuneChatRequestInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneChatRequestInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalFinetuneChatRequestInput)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFinetuneChatRequestInput IPersistableModel<InternalFinetuneChatRequestInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalFinetuneChatRequestInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalFinetuneChatRequestInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFinetuneChatRequestInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFinetuneChatRequestInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalFinetuneChatRequestInput FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalFinetuneChatRequestInput(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
