
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create the agent pool in the provisioned cluster
.Description
Create the agent pool in the provisioned cluster
.Example
New-AzAksArcNodepool -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Name azps_test_nodepool_example
.Example
New-AzAksArcNodepool -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Name azps_test_nodepool_example -Count 3

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPool
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IAksArcIdentity>: Identity Parameter
  [AgentPoolName <String>]: Parameter for the name of the agent pool in the provisioned cluster.
  [ConnectedClusterResourceUri <String>]: The fully qualified Azure Resource Manager identifier of the connected cluster resource.
  [CustomLocationResourceUri <String>]: The fully qualified Azure Resource Manager identifier of the custom location resource.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [VirtualNetworkName <String>]: Parameter for the name of the virtual network
.Link
https://learn.microsoft.com/powershell/module/az.aksarc/new-azaksarcnodepool
#>
function New-AzAksArcNodepool {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPool])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # The name of the Kubernetes cluster on which get is called.
    ${ClusterName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [System.String]
    # Parameter for the name of the agent pool in the provisioned cluster.
    ${Name},

    [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAksArcIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.Int32]
    # Number of nodes in the agent pool.
    # The default value is 1.
    ${Count},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='AutoScaling', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to enable auto-scaler.
    # Default value is false
    ${EnableAutoScaling},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='AutoScaling', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.Int32]
    # The minimum number of nodes for auto-scaling
    ${MinCount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Parameter(ParameterSetName='AutoScaling', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.Int32]
    # The maximum number of nodes for auto-scaling
    ${MaxCount},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.Int32]
    # The maximum number of pods that can run on a node.
    ${MaxPod},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPoolProfileNodeLabels]))]
    [System.Collections.Hashtable]
    # The node labels to be persisted across all nodes in agent pool.
    ${NodeLabel},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String[]]
    # Taints added to new nodes during node pool create and scale.
    # For example, key=value:NoSchedule.
    ${NodeTaint},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("CBLMariner", "Windows2019", "Windows2022")]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String]
    # Specifies the OS SKU used by the agent pool.
    # The default is CBLMariner if OSType is Linux.
    # The default is Windows2019 when OSType is Windows.
    ${OSSku},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("Windows", "Linux")]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String]
    # The particular KubernetesVersion Image OS Type (Linux, Windows)
    ${OSType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IAgentPoolTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String]
    # The VM sku size of the agent pool node VMs.
    ${VMSize},

    [Parameter(ParameterSetName='CreateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Create operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='CreateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Body')]
    [System.String]
    # Json string supplied to the Create operation
    ${JsonString},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    $Scope = GetConnectedClusterResourceURI -SubscriptionId $SubscriptionId -ResourceGroupName $ResourceGroupName -ClusterName $ClusterName
    $null = $PSBoundParameters.Remove("SubscriptionId")
    $null = $PSBoundParameters.Remove("ResourceGroupName")
    $null = $PSBoundParameters.Remove("ClusterName")
    $null = $PSBoundParameters.Add("ConnectedClusterResourceUri", $Scope)

    $ProvisionedClusterConfig = Get-AzAksArcCluster -SubscriptionId $SubscriptionId -ResourceGroupName $ResourceGroupName -ClusterName $ClusterName

    if ($ProvisionedClusterConfig.ProvisioningState -ne "Succeeded") {
      throw "Provisioned Cluster is not in succeeded state."
    }

    if ($PSBoundParameters.ContainsKey('VMSize')) {
      $VMList = Get-AzAksArcVMSku -CustomLocationName $ProvisionedClusterConfig.ExtendedLocationName -ResourceGroupName $ResourceGroupName -SubscriptionId $SubscriptionId
      foreach ($sku in $VMList.Value) {
        if ($VMSize -eq $sku.Name) {
          $FoundSku = $true
          continue
        }
      }

      if (!$FoundSku) {
        throw "VMSize is not valid."
      } 
    }

    Az.AksArc.internal\New-AzAksArcNodepool @PSBoundParameters
}
}
