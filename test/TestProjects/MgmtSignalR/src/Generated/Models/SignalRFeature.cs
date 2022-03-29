// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtSignalR.Models
{
    /// <summary> Feature of a SignalR resource, which controls the SignalR runtime behavior. </summary>
    public partial class SignalRFeature
    {
        /// <summary> Initializes a new instance of SignalRFeature. </summary>
        /// <param name="flag">
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: &quot;Default&quot;: have your own backend server; &quot;Serverless&quot;: your application doesn&apos;t have a backend server; &quot;Classic&quot;: for backward compatibility. Support both Default and Serverless mode but not recommended; &quot;PredefinedOnly&quot;: for future use.
        /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category respectively.
        /// </param>
        /// <param name="value"> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignalRFeature(FeatureFlags flag, string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Flag = flag;
            Value = value;
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SignalRFeature. </summary>
        /// <param name="flag">
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: &quot;Default&quot;: have your own backend server; &quot;Serverless&quot;: your application doesn&apos;t have a backend server; &quot;Classic&quot;: for backward compatibility. Support both Default and Serverless mode but not recommended; &quot;PredefinedOnly&quot;: for future use.
        /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category respectively.
        /// </param>
        /// <param name="value"> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </param>
        /// <param name="properties"> Optional properties related to this feature. </param>
        internal SignalRFeature(FeatureFlags flag, string value, IDictionary<string, string> properties)
        {
            Flag = flag;
            Value = value;
            Properties = properties;
        }

        /// <summary>
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: &quot;Default&quot;: have your own backend server; &quot;Serverless&quot;: your application doesn&apos;t have a backend server; &quot;Classic&quot;: for backward compatibility. Support both Default and Serverless mode but not recommended; &quot;PredefinedOnly&quot;: for future use.
        /// - EnableConnectivityLogs: &quot;true&quot;/&quot;false&quot;, to enable/disable the connectivity log category respectively.
        /// </summary>
        public FeatureFlags Flag { get; set; }
        /// <summary> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </summary>
        public string Value { get; set; }
        /// <summary> Optional properties related to this feature. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}