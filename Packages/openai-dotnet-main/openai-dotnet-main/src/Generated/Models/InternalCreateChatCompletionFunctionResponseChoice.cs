// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionFunctionResponseChoice
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalCreateChatCompletionFunctionResponseChoice(InternalCreateChatCompletionFunctionResponseChoiceFinishReason finishReason, int index, InternalChatCompletionResponseMessage message)
        {
            Argument.AssertNotNull(message, nameof(message));

            FinishReason = finishReason;
            Index = index;
            Message = message;
        }

        internal InternalCreateChatCompletionFunctionResponseChoice(InternalCreateChatCompletionFunctionResponseChoiceFinishReason finishReason, int index, InternalChatCompletionResponseMessage message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FinishReason = finishReason;
            Index = index;
            Message = message;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionFunctionResponseChoice()
        {
        }

        public InternalCreateChatCompletionFunctionResponseChoiceFinishReason FinishReason { get; }
        public int Index { get; }
        public InternalChatCompletionResponseMessage Message { get; }
    }
}
