// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace constants.Models
{
    /// <summary> The Enum10. </summary>
    public readonly partial struct Enum10 : IEquatable<Enum10>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum10"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum10(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PathValue = "path";

        /// <summary> path. </summary>
        public static Enum10 Path { get; } = new Enum10(PathValue);
        /// <summary> Determines if two <see cref="Enum10"/> values are the same. </summary>
        public static bool operator ==(Enum10 left, Enum10 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum10"/> values are not the same. </summary>
        public static bool operator !=(Enum10 left, Enum10 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum10"/>. </summary>
        public static implicit operator Enum10(string value) => new Enum10(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum10 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum10 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}