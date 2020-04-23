// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Inheritance.Models
{
    /// <summary> The ClassThatInheritsFromBaseClassAndSomeProperties. </summary>
    public partial class ClassThatInheritsFromBaseClassAndSomeProperties : BaseClass
    {
        /// <summary> Initializes a new instance of ClassThatInheritsFromBaseClassAndSomeProperties. </summary>
        internal ClassThatInheritsFromBaseClassAndSomeProperties()
        {
        }

        /// <summary> Initializes a new instance of ClassThatInheritsFromBaseClassAndSomeProperties. </summary>
        /// <param name="baseClassProperty"> . </param>
        /// <param name="someProperty"> . </param>
        /// <param name="someOtherProperty"> . </param>
        internal ClassThatInheritsFromBaseClassAndSomeProperties(string baseClassProperty, string someProperty, string someOtherProperty) : base(baseClassProperty)
        {
            SomeProperty = someProperty;
            SomeOtherProperty = someOtherProperty;
        }

        public string SomeProperty { get; }
        public string SomeOtherProperty { get; }
    }
}