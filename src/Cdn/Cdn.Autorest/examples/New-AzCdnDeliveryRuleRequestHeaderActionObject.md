### Example 1: Create an in-memory object for AzureCDN DeliveryRuleRequestHeaderAction
```powershell
New-AzCdnDeliveryRuleRequestHeaderActionObject -Name ModifyRequestHeader -ParameterHeaderAction Append -ParameterHeaderName a1 -ParameterValue a1
```

```output
Name
----
ModifyRequestHeader
```

Create an in-memory object for AzureCDN DeliveryRuleRequestHeaderAction