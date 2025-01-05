// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter()
        {
            Outputs = new ChangeTrackingList<RunStepUpdateCodeInterpreterOutput>();
        }

        internal InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(string input, IReadOnlyList<RunStepUpdateCodeInterpreterOutput> outputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            Outputs = outputs;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string Input { get; }
        public IReadOnlyList<RunStepUpdateCodeInterpreterOutput> Outputs { get; }
    }
}