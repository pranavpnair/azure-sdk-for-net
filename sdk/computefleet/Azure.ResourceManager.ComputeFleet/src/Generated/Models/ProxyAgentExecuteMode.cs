// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
    /// ProxyAgent will start to audit or monitor but not enforce access control over
    /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
    /// access control. The default value is Enforce mode.
    /// </summary>
    public readonly partial struct ProxyAgentExecuteMode : IEquatable<ProxyAgentExecuteMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProxyAgentExecuteMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProxyAgentExecuteMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuditValue = "Audit";
        private const string EnforceValue = "Enforce";

        /// <summary> Audit Mode. </summary>
        public static ProxyAgentExecuteMode Audit { get; } = new ProxyAgentExecuteMode(AuditValue);
        /// <summary> Enforce Mode. </summary>
        public static ProxyAgentExecuteMode Enforce { get; } = new ProxyAgentExecuteMode(EnforceValue);
        /// <summary> Determines if two <see cref="ProxyAgentExecuteMode"/> values are the same. </summary>
        public static bool operator ==(ProxyAgentExecuteMode left, ProxyAgentExecuteMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProxyAgentExecuteMode"/> values are not the same. </summary>
        public static bool operator !=(ProxyAgentExecuteMode left, ProxyAgentExecuteMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProxyAgentExecuteMode"/>. </summary>
        public static implicit operator ProxyAgentExecuteMode(string value) => new ProxyAgentExecuteMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProxyAgentExecuteMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProxyAgentExecuteMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
