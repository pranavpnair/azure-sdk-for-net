// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DefaultResourceProvisioningState. </summary>
    public readonly partial struct DefaultResourceProvisioningState : IEquatable<DefaultResourceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DefaultResourceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DefaultResourceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string FailedValue = "Failed";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string DeletingValue = "Deleting";
        private const string AcceptedValue = "Accepted";
        private const string CanceledValue = "Canceled";
        private const string ScalingValue = "Scaling";
        private const string DisabledValue = "Disabled";

        /// <summary> NotStarted. </summary>
        public static DefaultResourceProvisioningState NotStarted { get; } = new DefaultResourceProvisioningState(NotStartedValue);
        /// <summary> Failed. </summary>
        public static DefaultResourceProvisioningState Failed { get; } = new DefaultResourceProvisioningState(FailedValue);
        /// <summary> Creating. </summary>
        public static DefaultResourceProvisioningState Creating { get; } = new DefaultResourceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static DefaultResourceProvisioningState Updating { get; } = new DefaultResourceProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static DefaultResourceProvisioningState Succeeded { get; } = new DefaultResourceProvisioningState(SucceededValue);
        /// <summary> Deleting. </summary>
        public static DefaultResourceProvisioningState Deleting { get; } = new DefaultResourceProvisioningState(DeletingValue);
        /// <summary> Accepted. </summary>
        public static DefaultResourceProvisioningState Accepted { get; } = new DefaultResourceProvisioningState(AcceptedValue);
        /// <summary> Canceled. </summary>
        public static DefaultResourceProvisioningState Canceled { get; } = new DefaultResourceProvisioningState(CanceledValue);
        /// <summary> Scaling. </summary>
        public static DefaultResourceProvisioningState Scaling { get; } = new DefaultResourceProvisioningState(ScalingValue);
        /// <summary> Disabled. </summary>
        public static DefaultResourceProvisioningState Disabled { get; } = new DefaultResourceProvisioningState(DisabledValue);
        /// <summary> Determines if two <see cref="DefaultResourceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DefaultResourceProvisioningState left, DefaultResourceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DefaultResourceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DefaultResourceProvisioningState left, DefaultResourceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DefaultResourceProvisioningState"/>. </summary>
        public static implicit operator DefaultResourceProvisioningState(string value) => new DefaultResourceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DefaultResourceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DefaultResourceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
