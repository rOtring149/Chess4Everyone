// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageImageUrlContent : MessageContent
    {
        internal InternalMessageImageUrlContent(IDictionary<string, BinaryData> serializedAdditionalRawData, string type, InternalMessageContentImageUrlObjectImageUrl imageUrl) : base(serializedAdditionalRawData)
        {
            _type = type;
            _imageUrl = imageUrl;
        }

        internal InternalMessageImageUrlContent()
        {
        }
    }
}
