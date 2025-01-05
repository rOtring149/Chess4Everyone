// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public abstract partial class RunStepToolCall
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        internal RunStepToolCall(RunStepToolCallKind kind, string id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Id = id;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public string Id { get; }
    }
}