// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for MgmtKeyvaultPrivateEndpointConnection. </summary>
    public partial class MgmtKeyvaultPrivateEndpointConnectionResourceMockTests : MockTestBase
    {
        public MgmtKeyvaultPrivateEndpointConnectionResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: KeyVaultGetPrivateEndpointConnection
            var mgmtKeyvaultPrivateEndpointConnectionResourceId = MgmtKeyvault.MgmtKeyvaultPrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault", "sample-pec");
            var mgmtKeyvaultPrivateEndpointConnectionResource = GetArmClient().GetMgmtKeyvaultPrivateEndpointConnectionResource(mgmtKeyvaultPrivateEndpointConnectionResourceId);

            await mgmtKeyvaultPrivateEndpointConnectionResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: KeyVaultDeletePrivateEndpointConnection
            var mgmtKeyvaultPrivateEndpointConnectionResourceId = MgmtKeyvault.MgmtKeyvaultPrivateEndpointConnectionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault", "sample-pec");
            var mgmtKeyvaultPrivateEndpointConnectionResource = GetArmClient().GetMgmtKeyvaultPrivateEndpointConnectionResource(mgmtKeyvaultPrivateEndpointConnectionResourceId);

            await mgmtKeyvaultPrivateEndpointConnectionResource.DeleteAsync(WaitUntil.Completed);
        }
    }
}
