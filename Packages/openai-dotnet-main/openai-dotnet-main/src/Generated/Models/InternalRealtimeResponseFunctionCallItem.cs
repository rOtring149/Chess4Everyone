// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseFunctionCallItem : InternalRealtimeResponseItem
    {
        internal InternalRealtimeResponseFunctionCallItem(string id, string name, string callId, string arguments, ConversationItemStatus status) : base(id)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(callId, nameof(callId));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Type = InternalRealtimeItemType.FunctionCall;
            Name = name;
            CallId = callId;
            Arguments = arguments;
            Status = status;
        }

        internal InternalRealtimeResponseFunctionCallItem(InternalRealtimeResponseItemObject @object, InternalRealtimeItemType type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, string callId, string arguments, ConversationItemStatus status) : base(@object, type, id, serializedAdditionalRawData)
        {
            Name = name;
            CallId = callId;
            Arguments = arguments;
            Status = status;
        }

        internal InternalRealtimeResponseFunctionCallItem()
        {
        }

        public string Name { get; }
        public string CallId { get; }
        public string Arguments { get; }
        public ConversationItemStatus Status { get; }
    }
}
