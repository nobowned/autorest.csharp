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
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultResourceMockTests : MockTestBase
    {
        public VaultResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await vaultResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await vaultResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update an existing vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.VaultPatch patch = new MgmtKeyvault.Models.VaultPatch()
            {
                Properties = new MgmtKeyvault.Models.VaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new MgmtKeyvault.Models.MgmtKeyvaultSku(family: new MgmtKeyvault.Models.MgmtKeyvaultSkuFamily("A"), name: MgmtKeyvault.Models.MgmtKeyvaultSkuName.Standard),
                    EnabledForDeployment = true,
                    EnabledForDiskEncryption = true,
                    EnabledForTemplateDeployment = true,
                },
            };
            patch.Properties.AccessPolicies.Add(new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), objectId: "00000000-0000-0000-0000-000000000000", permissions: new MgmtKeyvault.Models.Permissions()));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("encrypt"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("decrypt"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("wrapKey"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("unwrapKey"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("sign"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("verify"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("get"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("list"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("create"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("update"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("import"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("delete"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("backup"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("restore"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("recover"));
            patch.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("purge"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("get"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("list"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("set"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("delete"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("backup"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("restore"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("recover"));
            patch.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("purge"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("get"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("list"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("delete"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("create"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("import"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("update"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("managecontacts"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("getissuers"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("listissuers"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("setissuers"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("deleteissuers"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("manageissuers"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("recover"));
            patch.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("purge"));

            await vaultResource.UpdateAsync(patch);
        }

        [RecordedTest]
        public async Task UpdateAccessPolicy()
        {
            // Example: Add an access policy, or update an access policy with new permissions
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.AccessPolicyUpdateKind operationKind = MgmtKeyvault.Models.AccessPolicyUpdateKind.Add;
            MgmtKeyvault.Models.VaultAccessPolicyParameters vaultAccessPolicyParameters = new MgmtKeyvault.Models.VaultAccessPolicyParameters(properties: new MgmtKeyvault.Models.VaultAccessPolicyProperties(accessPolicies: null));

            await vaultResource.UpdateAccessPolicyAsync(operationKind, vaultAccessPolicyParameters);
        }

        [RecordedTest]
        public async Task GetPrivateLinkResources()
        {
            // Example: KeyVaultListPrivateLinkResources
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await foreach (var _ in vaultResource.GetPrivateLinkResourcesAsync())
            {
            }
        }
    }
}
