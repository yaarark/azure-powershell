---
external help file: Az.Cdn-help.xml
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/Az.Cdn/new-azfrontdoorcdnruleurlrewriteactionobject
schema: 2.0.0
---

# New-AzFrontDoorCdnRuleUrlRewriteActionObject

## SYNOPSIS
Create an in-memory object for UrlRewriteAction.

## SYNTAX

```
New-AzFrontDoorCdnRuleUrlRewriteActionObject -ParameterDestination <String> -ParameterSourcePattern <String>
 -ParameterTypeName <String> [-ParameterPreserveUnmatchedPath <Boolean>]
 [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for UrlRewriteAction.

## EXAMPLES

### Example 1: Create an in-memory object for UrlRewriteAction
```powershell
New-AzFrontDoorCdnRuleUrlRewriteActionObject -Name UrlRewrite -ParameterDestination /b -ParameterSourcePattern /a -ParameterPreserveUnmatchedPath $False
```

```output
Name
----
UrlRewrite
```

Create an in-memory object for UrlRewriteAction

## PARAMETERS

### -ParameterDestination
Define the relative URL to which the above requests will be rewritten by.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterPreserveUnmatchedPath
Whether to preserve unmatched path.
Default value is true.

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterSourcePattern
define a request URI pattern that identifies the type of requests that may be rewritten.
If value is blank, all strings are matched.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParameterTypeName

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Name

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlRewriteAction

## NOTES

## RELATED LINKS
