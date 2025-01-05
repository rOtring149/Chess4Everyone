// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunStepFileSearchResult
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal RunStepFileSearchResult(string fileId, string fileName, float score)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));
            Argument.AssertNotNull(fileName, nameof(fileName));

            FileId = fileId;
            FileName = fileName;
            Score = score;
            Content = new ChangeTrackingList<RunStepFileSearchResultContent>();
        }

        internal RunStepFileSearchResult(string fileId, string fileName, float score, IReadOnlyList<RunStepFileSearchResultContent> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            FileName = fileName;
            Score = score;
            Content = content;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal RunStepFileSearchResult()
        {
        }

        public string FileId { get; }
        public string FileName { get; }
        public float Score { get; }
        public IReadOnlyList<RunStepFileSearchResultContent> Content { get; }
    }
}