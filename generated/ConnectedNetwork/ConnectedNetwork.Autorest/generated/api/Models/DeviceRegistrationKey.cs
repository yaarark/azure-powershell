// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>The device registration key.</summary>
    public partial class DeviceRegistrationKey :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IDeviceRegistrationKey,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IDeviceRegistrationKeyInternal
    {

        /// <summary>Internal Acessors for RegistrationKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IDeviceRegistrationKeyInternal.RegistrationKey { get => this._registrationKey; set { {_registrationKey = value;} } }

        /// <summary>Backing field for <see cref="RegistrationKey" /> property.</summary>
        private string _registrationKey;

        /// <summary>The registration key for the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string RegistrationKey { get => this._registrationKey; }

        /// <summary>Creates an new <see cref="DeviceRegistrationKey" /> instance.</summary>
        public DeviceRegistrationKey()
        {

        }
    }
    /// The device registration key.
    public partial interface IDeviceRegistrationKey :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The registration key for the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The registration key for the device.",
        SerializedName = @"registrationKey",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationKey { get;  }

    }
    /// The device registration key.
    internal partial interface IDeviceRegistrationKeyInternal

    {
        /// <summary>The registration key for the device.</summary>
        string RegistrationKey { get; set; }

    }
}