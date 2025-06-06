---
external help file:
Module Name: Az.BillingBenefits
online version: https://learn.microsoft.com/powershell/module/az.billingbenefits/invoke-azbillingbenefitssavingsplanpurchasevalidation
schema: 2.0.0
---

# Invoke-AzBillingBenefitsSavingsPlanPurchaseValidation

## SYNOPSIS
Validate savings plan purchase.

## SYNTAX

### ValidateExpanded (Default)
```
Invoke-AzBillingBenefitsSavingsPlanPurchaseValidation [-Benefit <ISavingsPlanOrderAliasModel[]>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaJsonFilePath
```
Invoke-AzBillingBenefitsSavingsPlanPurchaseValidation -JsonFilePath <String> [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaJsonString
```
Invoke-AzBillingBenefitsSavingsPlanPurchaseValidation -JsonString <String> [-DefaultProfile <PSObject>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Validate savings plan purchase.

## EXAMPLES

### Example 1: Validate savings plan purchase(expended).
```powershell
$model = @{
    SkuName = "Compute_Savings_Plan"
    DisplayName = "MockName"
    Term = "P1Y"
    AppliedScopeType = "Shared"
    BillingScopeId = "/subscriptions/eef82110-c91b-4395-9420-fcfcbefc5a47"
    CommitmentGrain = "Hourly"
    CommitmentAmount = 0.01
    CommitmentCurrencyCode = "USD"
}

$models = @($model)

Invoke-AzBillingBenefitsSavingsPlanPurchaseValidation -Benefit $models
```

```output
Valid ReasonCode Reason
----- ---------- ------
True
```

Validate savings plan purchase(expended).

## PARAMETERS

### -Benefit
.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanOrderAliasModel[]
Parameter Sets: ValidateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -JsonFilePath
Path of Json file supplied to the Validate operation

```yaml
Type: System.String
Parameter Sets: ValidateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Validate operation

```yaml
Type: System.String
Parameter Sets: ValidateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanValidateResponse

## NOTES

## RELATED LINKS

