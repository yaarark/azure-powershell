---
external help file: Az.NetworkSecurityPerimeter.psm1-help.xml
Module Name: Az.Network
online version: https://learn.microsoft.com/powershell/module/az.network/update-aznetworksecurityperimeterassociation
schema: 2.0.0
---

# Update-AzNetworkSecurityPerimeterAssociation

## SYNOPSIS
Updates an association

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzNetworkSecurityPerimeterAssociation -ResourceGroupName <String> -Name <String>
 -SecurityPerimeterName <String> [-SubscriptionId <String>] [-AccessMode <String>]
 [-PrivateLinkResourceId <String>] [-ProfileId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzNetworkSecurityPerimeterAssociation -InputObject <INetworkSecurityPerimeterIdentity>
 [-AccessMode <String>] [-PrivateLinkResourceId <String>] [-ProfileId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates an association.

## EXAMPLES

### Example 1: Update NetworkSecurityPerimeter Association
```powershell
Update-AzNetworkSecurityPerimeterAssociation -Name association-test-1 -SecurityPerimeterName nsp-test-1 -ResourceGroupName rg-test-1 -AccessMode Enforced
```

```output
AccessMode                   : Enforced
HasProvisioningIssue         : no
Id                           : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-1/providers
                                /Microsoft.Network/networkSecurityPerimeters/nsp-test-1/resourceAssociations/association-test-1
Name                         : association-test-1
PrivateLinkResourceId        : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-2/providers
                                /Microsoft.Sql/servers/sql-server-test-1
ProfileId                    : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-1/providers
                                /Microsoft.Network/networkSecurityPerimeters/nsp-test-1/profiles/profile-test-1
ProvisioningState            : Succeeded
ResourceGroupName            : rg-test-1
SystemDataCreatedAt          :
SystemDataCreatedBy          :
SystemDataCreatedByType      :
SystemDataLastModifiedAt     :
SystemDataLastModifiedBy     :
SystemDataLastModifiedByType :
Type                         : Microsoft.Network/networkSecurityPerimeters/resourceAssociations
```

Updates a NetworkSecurityPerimeterAccessAssociation

### Example 2: Update NetworkSecurityPerimeter Association by Identity (using pipe)
```powershell
$GETObj = Get-AzNetworkSecurityPerimeterAssociation -Name association-test-1 -SecurityPerimeterName nsp-test-1 -ResourceGroupName rg-test-1
Update-AzNetworkSecurityPerimeterAssociation -InputObject $GETObj -AccessMode Learning
```

```output
AccessMode                   : Learning
HasProvisioningIssue         : no
Id                           : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-1/providers
                                /Microsoft.Network/networkSecurityPerimeters/nsp-test-1/resourceAssociations/association-test-1
Name                         : association-test-1
PrivateLinkResourceId        : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-2/providers
                                /Microsoft.Sql/servers/sql-server-test-1
ProfileId                    : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg-test-1/providers
                                /Microsoft.Network/networkSecurityPerimeters/nsp-test-1/profiles/profile-test-1
ProvisioningState            : Succeeded
ResourceGroupName            : rg-test-1
SystemDataCreatedAt          :
SystemDataCreatedBy          :
SystemDataCreatedByType      :
SystemDataLastModifiedAt     :
SystemDataLastModifiedBy     :
SystemDataLastModifiedByType :
Type                         : Microsoft.Network/networkSecurityPerimeters/resourceAssociations
```

Update NetworkSecurityPerimeter Association by Identity (using pipe)

## PARAMETERS

### -AccessMode
Access Mode

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity parameter.
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the association.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases: AssociationName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivateLinkResourceId
Private link resource id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileId
Network security perimeter profile id

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecurityPerimeterName
The name of the network security perimeter

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases: NetworkSecurityPerimeterName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INetworkSecurityPerimeterIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.NetworkSecurityPerimeter.Models.INspAssociation

## NOTES

## RELATED LINKS
