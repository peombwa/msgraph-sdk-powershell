---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/update-mgreportusercredentialusagedetail
schema: 2.0.0
---

# Update-MgReportUserCredentialUsageDetail

## SYNOPSIS
Update the navigation property userCredentialUsageDetails in reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgReportUserCredentialUsageDetail -UserCredentialUsageDetailsId <String> [-AuthMethod <String>]
 [-EventDateTime <DateTime>] [-FailureReason <String>] [-Feature <String>] [-Id <String>] [-IsSuccess]
 [-UserDisplayName <String>] [-UserPrincipalName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgReportUserCredentialUsageDetail -UserCredentialUsageDetailsId <String>
 -BodyParameter <IMicrosoftGraphUserCredentialUsageDetails> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgReportUserCredentialUsageDetail -InputObject <IReportsIdentity>
 -BodyParameter <IMicrosoftGraphUserCredentialUsageDetails> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgReportUserCredentialUsageDetail -InputObject <IReportsIdentity> [-AuthMethod <String>]
 [-EventDateTime <DateTime>] [-FailureReason <String>] [-Feature <String>] [-Id <String>] [-IsSuccess]
 [-UserDisplayName <String>] [-UserPrincipalName <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userCredentialUsageDetails in reports

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AuthMethod
usageAuthMethod

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
userCredentialUsageDetails
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserCredentialUsageDetails
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EventDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FailureReason
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Feature
featureType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IReportsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsSuccess
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### -UserCredentialUsageDetailsId
key: userCredentialUsageDetails-id of userCredentialUsageDetails

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserCredentialUsageDetails

### Microsoft.Graph.PowerShell.Models.IReportsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserCredentialUsageDetails>: userCredentialUsageDetails
  - `[Id <String>]`: Read-only.
  - `[AuthMethod <String>]`: usageAuthMethod
  - `[EventDateTime <DateTime?>]`: 
  - `[FailureReason <String>]`: 
  - `[Feature <String>]`: featureType
  - `[IsSuccess <Boolean?>]`: 
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

INPUTOBJECT <IReportsIdentity>: Identity Parameter
  - `[ApplicationSignInDetailedSummaryId <String>]`: key: applicationSignInDetailedSummary-id of applicationSignInDetailedSummary
  - `[CredentialUserRegistrationDetailsId <String>]`: key: credentialUserRegistrationDetails-id of credentialUserRegistrationDetails
  - `[Date <DateTime?>]`: 
  - `[Filter <String>]`: 
  - `[Period <String>]`: 
  - `[PrintUsageSummaryByPrinterId <String>]`: key: PrintUsageSummaryByPrinter-id of PrintUsageSummaryByPrinter
  - `[PrintUsageSummaryByUserId <String>]`: key: PrintUsageSummaryByUser-id of PrintUsageSummaryByUser
  - `[Skip <Int32?>]`: 
  - `[SkipToken <String>]`: 
  - `[Top <Int32?>]`: 
  - `[UserCredentialUsageDetailsId <String>]`: key: userCredentialUsageDetails-id of userCredentialUsageDetails

## RELATED LINKS

