// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Extensions;

    /// <summary>The response of a TrafficController list operation.</summary>
    public partial class TrafficControllerListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficControllerListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficControllerListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Origin(Microsoft.Azure.PowerShell.Cmdlets.Alb.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficController[] _value;

        /// <summary>The TrafficController items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Origin(Microsoft.Azure.PowerShell.Cmdlets.Alb.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficController[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="TrafficControllerListResult" /> instance.</summary>
        public TrafficControllerListResult()
        {

        }
    }
    /// The response of a TrafficController list operation.
    public partial interface ITrafficControllerListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The TrafficController items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Alb.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The TrafficController items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficController) })]
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficController[] Value { get; set; }

    }
    /// The response of a TrafficController list operation.
    internal partial interface ITrafficControllerListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The TrafficController items on this page</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Alb.Models.Api20230501Preview.ITrafficController[] Value { get; set; }

    }
}