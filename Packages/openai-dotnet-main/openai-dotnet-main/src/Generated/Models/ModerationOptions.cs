// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Moderations
{
    internal partial class ModerationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        internal ModerationOptions(BinaryData input, InternalCreateModerationRequestModel? model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            Model = model;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
