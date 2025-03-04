// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>SKU of nat gateway.</summary>
    public partial class NatGatewaySku :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatGatewaySku,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatGatewaySkuInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.NatGatewaySkuName? _name;

        /// <summary>Name of Nat Gateway SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.NatGatewaySkuName? Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="NatGatewaySku" /> instance.</summary>
        public NatGatewaySku()
        {

        }
    }
    /// SKU of nat gateway.
    public partial interface INatGatewaySku :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>Name of Nat Gateway SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Nat Gateway SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.NatGatewaySkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.NatGatewaySkuName? Name { get; set; }

    }
    /// SKU of nat gateway.
    internal partial interface INatGatewaySkuInternal

    {
        /// <summary>Name of Nat Gateway SKU.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.NatGatewaySkuName? Name { get; set; }

    }
}