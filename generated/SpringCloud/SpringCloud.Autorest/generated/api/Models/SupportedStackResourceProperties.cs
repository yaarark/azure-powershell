// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Supported stack resource properties</summary>
    public partial class SupportedStackResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedStackResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISupportedStackResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="StackId" /> property.</summary>
        private string _stackId;

        /// <summary>The id of supported stack</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string StackId { get => this._stackId; set => this._stackId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of supported stack</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SupportedStackResourceProperties" /> instance.</summary>
        public SupportedStackResourceProperties()
        {

        }
    }
    /// Supported stack resource properties
    public partial interface ISupportedStackResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>The id of supported stack</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The id of supported stack",
        SerializedName = @"stackId",
        PossibleTypes = new [] { typeof(string) })]
        string StackId { get; set; }
        /// <summary>The version of supported stack</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of supported stack",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Supported stack resource properties
    internal partial interface ISupportedStackResourcePropertiesInternal

    {
        /// <summary>The id of supported stack</summary>
        string StackId { get; set; }
        /// <summary>The version of supported stack</summary>
        string Version { get; set; }

    }
}