// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Extensions;

    /// <summary>The response of a InstanceResource list operation.</summary>
    public partial class InstanceResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResource> _value;

        /// <summary>The InstanceResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="InstanceResourceListResult" /> instance.</summary>
        public InstanceResourceListResult()
        {

        }
    }
    /// The response of a InstanceResource list operation.
    public partial interface IInstanceResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The InstanceResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The InstanceResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResource> Value { get; set; }

    }
    /// The response of a InstanceResource list operation.
    internal partial interface IInstanceResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The InstanceResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.WeightsAndBiases.Models.IInstanceResource> Value { get; set; }

    }
}