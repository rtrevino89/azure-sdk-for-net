// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Internet access. Example: true | false. </summary>
    public readonly partial struct InternetBoolean : IEquatable<InternetBoolean>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternetBoolean"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternetBoolean(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> true. </summary>
        public static InternetBoolean True { get; } = new InternetBoolean(TrueValue);
        /// <summary> false. </summary>
        public static InternetBoolean False { get; } = new InternetBoolean(FalseValue);
        /// <summary> Determines if two <see cref="InternetBoolean"/> values are the same. </summary>
        public static bool operator ==(InternetBoolean left, InternetBoolean right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternetBoolean"/> values are not the same. </summary>
        public static bool operator !=(InternetBoolean left, InternetBoolean right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternetBoolean"/>. </summary>
        public static implicit operator InternetBoolean(string value) => new InternetBoolean(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternetBoolean other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternetBoolean other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
