// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> The VectorStoreDeletionStatusObject. </summary>
    public readonly partial struct VectorStoreDeletionStatusObject : IEquatable<VectorStoreDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VectorStoreDeletedValue = "vector_store.deleted";

        /// <summary> vector_store.deleted. </summary>
        public static VectorStoreDeletionStatusObject VectorStoreDeleted { get; } = new VectorStoreDeletionStatusObject(VectorStoreDeletedValue);
        /// <summary> Determines if two <see cref="VectorStoreDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(VectorStoreDeletionStatusObject left, VectorStoreDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreDeletionStatusObject left, VectorStoreDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VectorStoreDeletionStatusObject"/>. </summary>
        public static implicit operator VectorStoreDeletionStatusObject(string value) => new VectorStoreDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
