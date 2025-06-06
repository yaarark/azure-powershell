
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
update a KPack build.
.Description
update a KPack build.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IBuild
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BUILDSERVICEINPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

INPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

SPRINGINPUTOBJECT <ISpringCloudIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the build service agent pool resource.
  [AppName <String>]: The name of the App resource.
  [BindingName <String>]: The name of the Binding resource.
  [BuildName <String>]: The name of the build resource.
  [BuildResultName <String>]: The name of the build result resource.
  [BuildServiceName <String>]: The name of the build service resource.
  [BuilderName <String>]: The name of the builder resource.
  [BuildpackBindingName <String>]: The name of the Buildpack Binding Name
  [BuildpackName <String>]: The name of the buildpack resource.
  [CertificateName <String>]: The name of the certificate resource.
  [ConfigurationServiceName <String>]: The name of Application Configuration Service.
  [DeploymentName <String>]: The name of the Deployment resource.
  [DomainName <String>]: The name of the custom domain resource.
  [Id <String>]: Resource identity path
  [Location <String>]: the region
  [ResourceGroupName <String>]: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [ServiceName <String>]: The name of the Service resource.
  [ServiceRegistryName <String>]: The name of Service Registry.
  [StackName <String>]: The name of the stack resource.
  [SubscriptionId <String>]: Gets subscription ID which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
.Link
https://learn.microsoft.com/powershell/module/az.springcloud/update-azspringcloudbuildservicebuild
#>
function Update-AzSpringCloudBuildServiceBuild {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IBuild])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentitySpringExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the build service resource.
    ${BuildServiceName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentityBuildServiceExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaIdentitySpringExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the build resource.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [System.String]
    # The name of the Service resource.
    ${ServiceName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Gets subscription ID which uniquely identify the Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityBuildServiceExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${BuildServiceInputObject},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='UpdateViaIdentitySpringExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity]
    # Identity Parameter
    ${SpringInputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # The resource id of agent pool
    ${AgentPoolId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # The resource id of builder to build the source code
    ${BuilderId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IBuildPropertiesEnv]))]
    [System.Collections.Hashtable]
    # The environment variables for this build
    ${Env},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Body')]
    [System.String]
    # The relative path of source code
    ${RelativePath},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        
        $testPlayback = $false
        $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }

        $mapping = @{
            UpdateExpanded = 'Az.SpringCloud.private\Update-AzSpringCloudBuildServiceBuild_UpdateExpanded';
            UpdateViaIdentityBuildServiceExpanded = 'Az.SpringCloud.private\Update-AzSpringCloudBuildServiceBuild_UpdateViaIdentityBuildServiceExpanded';
            UpdateViaIdentityExpanded = 'Az.SpringCloud.private\Update-AzSpringCloudBuildServiceBuild_UpdateViaIdentityExpanded';
            UpdateViaIdentitySpringExpanded = 'Az.SpringCloud.private\Update-AzSpringCloudBuildServiceBuild_UpdateViaIdentitySpringExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        if ($wrappedCmd -eq $null) {
            $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Function)
        }
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
