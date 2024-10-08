// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using BasicTypeSpec;

namespace BasicTypeSpec.Models
{
    /// <summary> The AnonymousBodyRequest_requiredLiteralString. </summary>
    public readonly partial struct AnonymousBodyRequestRequiredLiteralString : IEquatable<AnonymousBodyRequestRequiredLiteralString>
    {
        private readonly string _value;
        /// <summary> accept. </summary>
        private const string AcceptValue = "accept";

        /// <summary> Initializes a new instance of <see cref="AnonymousBodyRequestRequiredLiteralString"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnonymousBodyRequestRequiredLiteralString(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> accept. </summary>
        public static AnonymousBodyRequestRequiredLiteralString Accept { get; } = new AnonymousBodyRequestRequiredLiteralString(AcceptValue);

        /// <summary> Determines if two <see cref="AnonymousBodyRequestRequiredLiteralString"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(AnonymousBodyRequestRequiredLiteralString left, AnonymousBodyRequestRequiredLiteralString right) => left.Equals(right);

        /// <summary> Determines if two <see cref="AnonymousBodyRequestRequiredLiteralString"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(AnonymousBodyRequestRequiredLiteralString left, AnonymousBodyRequestRequiredLiteralString right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="AnonymousBodyRequestRequiredLiteralString"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator AnonymousBodyRequestRequiredLiteralString(string value) => new AnonymousBodyRequestRequiredLiteralString(value);

        /// <param name="obj"> The object to compare. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnonymousBodyRequestRequiredLiteralString other && Equals(other);

        /// <param name="other"> The instance to compare. </param>
        public bool Equals(AnonymousBodyRequestRequiredLiteralString other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
