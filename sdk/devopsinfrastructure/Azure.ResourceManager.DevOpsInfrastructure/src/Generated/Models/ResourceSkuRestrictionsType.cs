// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    /// <summary> Describes the kind of SKU restrictions that can exist. </summary>
    public readonly partial struct ResourceSkuRestrictionsType : IEquatable<ResourceSkuRestrictionsType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictionsType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceSkuRestrictionsType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LocationValue = "Location";
        private const string ZoneValue = "Zone";

        /// <summary> SKU restricted by location. </summary>
        public static ResourceSkuRestrictionsType Location { get; } = new ResourceSkuRestrictionsType(LocationValue);
        /// <summary> SKU restricted by availability zone. </summary>
        public static ResourceSkuRestrictionsType Zone { get; } = new ResourceSkuRestrictionsType(ZoneValue);
        /// <summary> Determines if two <see cref="ResourceSkuRestrictionsType"/> values are the same. </summary>
        public static bool operator ==(ResourceSkuRestrictionsType left, ResourceSkuRestrictionsType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceSkuRestrictionsType"/> values are not the same. </summary>
        public static bool operator !=(ResourceSkuRestrictionsType left, ResourceSkuRestrictionsType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceSkuRestrictionsType"/>. </summary>
        public static implicit operator ResourceSkuRestrictionsType(string value) => new ResourceSkuRestrictionsType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceSkuRestrictionsType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceSkuRestrictionsType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
