// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalIncludedRunStepProperty : IEquatable<InternalIncludedRunStepProperty>
    {
        private readonly string _value;

        public InternalIncludedRunStepProperty(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileSearchResultContentValue = "step_details.tool_calls[*].file_search.results[*].content";

        public static InternalIncludedRunStepProperty FileSearchResultContent { get; } = new InternalIncludedRunStepProperty(FileSearchResultContentValue);
        public static bool operator ==(InternalIncludedRunStepProperty left, InternalIncludedRunStepProperty right) => left.Equals(right);
        public static bool operator !=(InternalIncludedRunStepProperty left, InternalIncludedRunStepProperty right) => !left.Equals(right);
        public static implicit operator InternalIncludedRunStepProperty(string value) => new InternalIncludedRunStepProperty(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalIncludedRunStepProperty other && Equals(other);
        public bool Equals(InternalIncludedRunStepProperty other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
