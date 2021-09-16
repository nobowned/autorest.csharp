// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SupersetInheritance.Models
{
    /// <summary> The SupersetModel2. </summary>
    public partial class SupersetModel2
    {
        /// <summary> Initializes a new instance of SupersetModel2. </summary>
        public SupersetModel2()
        {
        }

        /// <summary> Initializes a new instance of SupersetModel2. </summary>
        /// <param name="iD"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="new"></param>
        internal SupersetModel2(string iD, string name, string type, string @new)
        {
            ID = iD;
            Name = name;
            Type = type;
            New = @new;
        }

        /// <summary> Gets or sets the id. </summary>
        public string ID { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the type. </summary>
        public string Type { get; set; }
        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
