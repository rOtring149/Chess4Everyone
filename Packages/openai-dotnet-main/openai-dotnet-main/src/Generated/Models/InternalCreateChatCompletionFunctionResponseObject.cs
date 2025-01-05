// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalCreateChatCompletionFunctionResponseObject : IEquatable<InternalCreateChatCompletionFunctionResponseObject>
    {
        private readonly string _value;

        public InternalCreateChatCompletionFunctionResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ChatCompletionValue = "chat.completion";

        public static InternalCreateChatCompletionFunctionResponseObject ChatCompletion { get; } = new InternalCreateChatCompletionFunctionResponseObject(ChatCompletionValue);
        public static bool operator ==(InternalCreateChatCompletionFunctionResponseObject left, InternalCreateChatCompletionFunctionResponseObject right) => left.Equals(right);
        public static bool operator !=(InternalCreateChatCompletionFunctionResponseObject left, InternalCreateChatCompletionFunctionResponseObject right) => !left.Equals(right);
        public static implicit operator InternalCreateChatCompletionFunctionResponseObject(string value) => new InternalCreateChatCompletionFunctionResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateChatCompletionFunctionResponseObject other && Equals(other);
        public bool Equals(InternalCreateChatCompletionFunctionResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}