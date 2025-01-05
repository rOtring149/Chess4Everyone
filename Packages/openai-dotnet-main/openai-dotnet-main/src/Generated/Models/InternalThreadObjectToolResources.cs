// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalThreadObjectToolResources
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalThreadObjectToolResources()
        {
        }

        internal InternalThreadObjectToolResources(InternalThreadObjectToolResourcesCodeInterpreter codeInterpreter, InternalThreadObjectToolResourcesFileSearch fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public InternalThreadObjectToolResourcesCodeInterpreter CodeInterpreter { get; }
        public InternalThreadObjectToolResourcesFileSearch FileSearch { get; }
    }
}