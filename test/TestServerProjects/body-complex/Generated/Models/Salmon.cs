// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace body_complex.Models
{
    /// <summary> The Salmon. </summary>
    public partial class Salmon : Fish
    {
        /// <summary> Initializes a new instance of Salmon. </summary>
        /// <param name="length"></param>
        public Salmon(float length) : base(length)
        {
            Fishtype = "salmon";
        }

        /// <summary> Initializes a new instance of Salmon. </summary>
        /// <param name="fishtype"></param>
        /// <param name="species"></param>
        /// <param name="length"></param>
        /// <param name="siblings"></param>
        /// <param name="location"></param>
        /// <param name="iswild"></param>
        internal Salmon(string fishtype, string species, float length, IList<Fish> siblings, string location, bool? iswild) : base(fishtype, species, length, siblings)
        {
            Location = location;
            Iswild = iswild;
            Fishtype = fishtype ?? "salmon";
        }

        /// <summary> Gets or sets the location. </summary>
        public string Location { get; set; }
        /// <summary> Gets or sets the iswild. </summary>
        public bool? Iswild { get; set; }
    }
}
