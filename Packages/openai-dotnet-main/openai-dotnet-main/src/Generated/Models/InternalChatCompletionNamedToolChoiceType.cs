// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalChatCompletionNamedToolChoiceType : IEquatable<InternalChatCompletionNamedToolChoiceType>
    {
        private readonly string _value;

        public InternalChatCompletionNamedToolChoiceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        public static InternalChatCompletionNamedToolChoiceType Function { get; } = new InternalChatCompletionNamedToolChoiceType(FunctionValue);
        public static bool operator ==(InternalChatCompletionNamedToolChoiceType left, InternalChatCompletionNamedToolChoiceType right) => left.Equals(right);
        public static bool operator !=(InternalChatCompletionNamedToolChoiceType left, InternalChatCompletionNamedToolChoiceType right) => !left.Equals(right);
        public static implicit operator InternalChatCompletionNamedToolChoiceType(string value) => new InternalChatCompletionNamedToolChoiceType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalChatCompletionNamedToolChoiceType other && Equals(other);
        public bool Equals(InternalChatCompletionNamedToolChoiceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
