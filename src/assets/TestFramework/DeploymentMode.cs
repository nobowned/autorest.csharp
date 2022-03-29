// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Resources.Models
{
    /// <summary> The deployment mode. </summary>
    public readonly partial struct DeploymentMode : IEquatable<DeploymentMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string IncrementalValue = "Incremental";
        private const string CompleteValue = "Complete";

        /// <summary> NotSpecified. </summary>
        public static DeploymentMode NotSpecified { get; } = new DeploymentMode(NotSpecifiedValue);
        /// <summary> Incremental. </summary>
        public static DeploymentMode Incremental { get; } = new DeploymentMode(IncrementalValue);
        /// <summary> Complete. </summary>
        public static DeploymentMode Complete { get; } = new DeploymentMode(CompleteValue);
        /// <summary> Determines if two <see cref="DeploymentMode"/> values are the same. </summary>
        public static bool operator ==(DeploymentMode left, DeploymentMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentMode"/> values are not the same. </summary>
        public static bool operator !=(DeploymentMode left, DeploymentMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentMode"/>. </summary>
        public static implicit operator DeploymentMode(string value) => new DeploymentMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}