// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Assistants
{
    internal partial class InternalListRunsResponse
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalListRunsResponse(IEnumerable<ThreadRun> data, string firstId, string lastId, bool hasMore)
        {
            Argument.AssertNotNull(data, nameof(data));
            Argument.AssertNotNull(firstId, nameof(firstId));
            Argument.AssertNotNull(lastId, nameof(lastId));

            Data = data.ToList();
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
        }

        internal InternalListRunsResponse(InternalListRunsResponseObject @object, IReadOnlyList<ThreadRun> data, string firstId, string lastId, bool hasMore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Object = @object;
            Data = data;
            FirstId = firstId;
            LastId = lastId;
            HasMore = hasMore;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalListRunsResponse()
        {
        }

        public InternalListRunsResponseObject Object { get; } = InternalListRunsResponseObject.List;

        public IReadOnlyList<ThreadRun> Data { get; }
        public string FirstId { get; }
        public string LastId { get; }
        public bool HasMore { get; }
    }
}
