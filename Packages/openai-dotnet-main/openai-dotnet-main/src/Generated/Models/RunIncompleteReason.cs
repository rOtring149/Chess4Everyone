// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    public readonly partial struct RunIncompleteReason : IEquatable<RunIncompleteReason>
    {
        private readonly string _value;

        public RunIncompleteReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MaxOutputTokenCountValue = "max_completion_tokens";
        private const string MaxInputTokenCountValue = "max_prompt_tokens";
        public static bool operator ==(RunIncompleteReason left, RunIncompleteReason right) => left.Equals(right);
        public static bool operator !=(RunIncompleteReason left, RunIncompleteReason right) => !left.Equals(right);
        public static implicit operator RunIncompleteReason(string value) => new RunIncompleteReason(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunIncompleteReason other && Equals(other);
        public bool Equals(RunIncompleteReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}