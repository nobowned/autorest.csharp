// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace ExactMatchInheritance
{
    /// <summary> A class representing the ExactMatchModel1 data model. </summary>
    public partial class ExactMatchModel1Data : Resource
    {
        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        public ExactMatchModel1Data()
        {
        }

        /// <summary> Initializes a new instance of ExactMatchModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="new"></param>
        internal ExactMatchModel1Data(ResourceIdentifier id, string name, ResourceType type, string @new) : base(id, name, type)
        {
            New = @new;
        }

        /// <summary> Gets or sets the new. </summary>
        public string New { get; set; }
    }
}
