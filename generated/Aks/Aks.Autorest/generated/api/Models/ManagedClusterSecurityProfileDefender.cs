// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Microsoft Defender settings for the security profile.</summary>
    public partial class ManagedClusterSecurityProfileDefender :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefender,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderInternal
    {

        /// <summary>Backing field for <see cref="LogAnalyticsWorkspaceResourceId" /> property.</summary>
        private string _logAnalyticsWorkspaceResourceId;

        /// <summary>
        /// Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled,
        /// this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field
        /// empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string LogAnalyticsWorkspaceResourceId { get => this._logAnalyticsWorkspaceResourceId; set => this._logAnalyticsWorkspaceResourceId = value; }

        /// <summary>Internal Acessors for SecurityMonitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoring Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderInternal.SecurityMonitoring { get => (this._securityMonitoring = this._securityMonitoring ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterSecurityProfileDefenderSecurityMonitoring()); set { {_securityMonitoring = value;} } }

        /// <summary>Backing field for <see cref="SecurityMonitoring" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoring _securityMonitoring;

        /// <summary>
        /// Microsoft Defender threat detection for Cloud settings for the security profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoring SecurityMonitoring { get => (this._securityMonitoring = this._securityMonitoring ?? new Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterSecurityProfileDefenderSecurityMonitoring()); set => this._securityMonitoring = value; }

        /// <summary>Whether to enable Defender threat detection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Inlined)]
        public bool? SecurityMonitoringEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoringInternal)SecurityMonitoring).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoringInternal)SecurityMonitoring).Enabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="ManagedClusterSecurityProfileDefender" /> instance.</summary>
        public ManagedClusterSecurityProfileDefender()
        {

        }
    }
    /// Microsoft Defender settings for the security profile.
    public partial interface IManagedClusterSecurityProfileDefender :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled,
        /// this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field
        /// empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field empty.",
        SerializedName = @"logAnalyticsWorkspaceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string LogAnalyticsWorkspaceResourceId { get; set; }
        /// <summary>Whether to enable Defender threat detection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to enable Defender threat detection",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityMonitoringEnabled { get; set; }

    }
    /// Microsoft Defender settings for the security profile.
    internal partial interface IManagedClusterSecurityProfileDefenderInternal

    {
        /// <summary>
        /// Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled,
        /// this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field
        /// empty.
        /// </summary>
        string LogAnalyticsWorkspaceResourceId { get; set; }
        /// <summary>
        /// Microsoft Defender threat detection for Cloud settings for the security profile.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterSecurityProfileDefenderSecurityMonitoring SecurityMonitoring { get; set; }
        /// <summary>Whether to enable Defender threat detection</summary>
        bool? SecurityMonitoringEnabled { get; set; }

    }
}