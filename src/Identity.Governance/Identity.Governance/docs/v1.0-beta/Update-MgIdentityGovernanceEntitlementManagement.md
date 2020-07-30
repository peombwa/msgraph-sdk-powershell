---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgidentitygovernanceentitlementmanagement
schema: 2.0.0
---

# Update-MgIdentityGovernanceEntitlementManagement

## SYNOPSIS
Update the navigation property entitlementManagement in identityGovernance

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgIdentityGovernanceEntitlementManagement
 [-AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]
 [-AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]
 [-AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]
 [-AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]
 [-AccessPackageCatalogs <IMicrosoftGraphAccessPackageCatalog[]>]
 [-AccessPackageResourceRequests <IMicrosoftGraphAccessPackageResourceRequest[]>]
 [-AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]
 [-AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]
 [-AccessPackages <IMicrosoftGraphAccessPackage[]>] [-Id <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgIdentityGovernanceEntitlementManagement -BodyParameter <IMicrosoftGraphEntitlementManagement>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property entitlementManagement in identityGovernance

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

### -AccessPackageAssignmentPolicies
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentPolicy[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentRequests
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentRequest[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignmentResourceRoles
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTRESOURCEROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignmentResourceRole[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageAssignments
.
To construct, see NOTES section for ACCESSPACKAGEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageAssignment[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageCatalogs
.
To construct, see NOTES section for ACCESSPACKAGECATALOGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRequests
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEREQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRequest[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceRoleScopes
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLESCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResources
.
To construct, see NOTES section for ACCESSPACKAGERESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackages
.
To construct, see NOTES section for ACCESSPACKAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackage[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
entitlementManagement
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEntitlementManagement
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEntitlementManagement

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGEASSIGNMENTPOLICIES <IMicrosoftGraphAccessPackageAssignmentPolicy[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceType <String>]`: 
        - `[AccessPackageResourceUrl <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsRootScope <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[RoleOriginId <String>]`: 
        - `[Url <String>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AddedBy <String>]`: 
      - `[AddedOn <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsPendingOnboarding <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[ResourceType <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[CatalogId <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsHidden <Boolean?>]`: 
    - `[IsRoleScopesVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
  - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
  - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
  - `[AccessPackageCatalogCreatedBy <String>]`: 
  - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
  - `[AccessPackageCatalogDescription <String>]`: 
  - `[AccessPackageCatalogDisplayName <String>]`: 
  - `[AccessPackageCatalogId <String>]`: Read-only.
  - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
  - `[AccessPackageCatalogModifiedBy <String>]`: 
  - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageCatalogStatus <String>]`: 
  - `[AccessPackageCatalogType <String>]`: 
  - `[AccessPackageId <String>]`: 
  - `[AccessReviewSettingDurationInDays <Int32?>]`: 
  - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
  - `[AccessReviewSettingRecurrenceType <String>]`: 
  - `[AccessReviewSettingReviewerType <String>]`: 
  - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
    - `[IsBackup <Boolean?>]`: 
  - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
  - `[CanExtend <Boolean?>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[DurationInDays <Int32?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[RequestApprovalSettingApprovalMode <String>]`: 
  - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
    - `[ApprovalStageTimeOutInDays <Int32?>]`: 
    - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
    - `[EscalationTimeInMinutes <Int32?>]`: 
    - `[IsApproverJustificationRequired <Boolean?>]`: 
    - `[IsEscalationEnabled <Boolean?>]`: 
    - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
  - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
  - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
  - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
  - `[RequestorSettingAcceptRequests <Boolean?>]`: 
  - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
  - `[RequestorSettingScopeType <String>]`: 

ACCESSPACKAGEASSIGNMENTREQUESTS <IMicrosoftGraphAccessPackageAssignmentRequest[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[AccessPackageResourceAddedBy <String>]`: 
          - `[AccessPackageResourceAddedOn <DateTime?>]`: 
          - `[AccessPackageResourceDescription <String>]`: 
          - `[AccessPackageResourceDisplayName <String>]`: 
          - `[AccessPackageResourceId <String>]`: Read-only.
          - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
          - `[AccessPackageResourceOriginId <String>]`: 
          - `[AccessPackageResourceOriginSystem <String>]`: 
          - `[AccessPackageResourceType <String>]`: 
          - `[AccessPackageResourceUrl <String>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[IsRootScope <Boolean?>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
          - `[RoleOriginId <String>]`: 
          - `[Url <String>]`: 
        - `[AccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceType <String>]`: 
        - `[AccessPackageResourceUrl <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
      - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AddedBy <String>]`: 
        - `[AddedOn <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsPendingOnboarding <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[ResourceType <String>]`: 
        - `[Url <String>]`: 
      - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[AccessPackageCatalogCreatedBy <String>]`: 
      - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogDescription <String>]`: 
      - `[AccessPackageCatalogDisplayName <String>]`: 
      - `[AccessPackageCatalogId <String>]`: Read-only.
      - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
      - `[AccessPackageCatalogModifiedBy <String>]`: 
      - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogStatus <String>]`: 
      - `[AccessPackageCatalogType <String>]`: 
      - `[AccessPackageId <String>]`: 
      - `[AccessReviewSettingDurationInDays <Int32?>]`: 
      - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
      - `[AccessReviewSettingRecurrenceType <String>]`: 
      - `[AccessReviewSettingReviewerType <String>]`: 
      - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
        - `[IsBackup <Boolean?>]`: 
      - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
      - `[CanExtend <Boolean?>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[DurationInDays <Int32?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[RequestApprovalSettingApprovalMode <String>]`: 
      - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
        - `[ApprovalStageTimeOutInDays <Int32?>]`: 
        - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[EscalationTimeInMinutes <Int32?>]`: 
        - `[IsApproverJustificationRequired <Boolean?>]`: 
        - `[IsEscalationEnabled <Boolean?>]`: 
        - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
      - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
      - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
      - `[RequestorSettingAcceptRequests <Boolean?>]`: 
      - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestorSettingScopeType <String>]`: 
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[CatalogId <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsHidden <Boolean?>]`: 
    - `[IsRoleScopesVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageAssignmentAccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
  - `[AccessPackageAssignmentAccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentAccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
  - `[AccessPackageAssignmentAccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
      - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
      - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
      - `[AccessPackageId <String>]`: 
      - `[AssignmentPolicyId <String>]`: 
      - `[AssignmentState <String>]`: 
      - `[AssignmentStatus <String>]`: 
      - `[CatalogId <String>]`: 
      - `[ExpiredDateTime <DateTime?>]`: 
      - `[IsExtended <Boolean?>]`: 
      - `[MicrosoftGraphEntityId <String>]`: Read-only.
      - `[TargetAltSecId <String>]`: 
      - `[TargetDisplayName <String>]`: 
      - `[TargetEmail <String>]`: 
      - `[TargetId <String>]`: 
      - `[TargetObjectId <String>]`: 
      - `[TargetOnPremisesSecurityIdentifier <String>]`: 
      - `[TargetPrincipalName <String>]`: 
      - `[TargetType <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
    - `[AccessPackageResourceRoleDescription <String>]`: 
    - `[AccessPackageResourceRoleDisplayName <String>]`: 
    - `[AccessPackageResourceRoleId <String>]`: Read-only.
    - `[AccessPackageResourceRoleOriginId <String>]`: 
    - `[AccessPackageResourceRoleOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
    - `[AccessPackageResourceScopeDescription <String>]`: 
    - `[AccessPackageResourceScopeDisplayName <String>]`: 
    - `[AccessPackageResourceScopeId <String>]`: Read-only.
    - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
    - `[AccessPackageResourceScopeOriginId <String>]`: 
    - `[AccessPackageResourceScopeOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
    - `[AccessPackageResourceScopeUrl <String>]`: 
    - `[AccessPackageSubjectAltSecId <String>]`: 
    - `[AccessPackageSubjectDisplayName <String>]`: 
    - `[AccessPackageSubjectEmail <String>]`: 
    - `[AccessPackageSubjectId <String>]`: Read-only.
    - `[AccessPackageSubjectObjectId <String>]`: 
    - `[AccessPackageSubjectOnPremisesSecurityIdentifier <String>]`: 
    - `[AccessPackageSubjectPrincipalName <String>]`: 
    - `[AccessPackageSubjectType <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Status <String>]`: 
  - `[AccessPackageAssignmentAccessPackageId <String>]`: 
  - `[AccessPackageAssignmentCatalogId <String>]`: 
  - `[AccessPackageAssignmentExpiredDateTime <DateTime?>]`: 
  - `[AccessPackageAssignmentId <String>]`: Read-only.
  - `[AccessPackageAssignmentIsExtended <Boolean?>]`: 
  - `[AccessPackageAssignmentPolicyId <String>]`: 
  - `[AccessPackageAssignmentState <String>]`: 
  - `[AccessPackageAssignmentStatus <String>]`: 
  - `[AccessPackageAssignmentTargetId <String>]`: 
  - `[CompletedDate <DateTime?>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[IsValidationOnly <Boolean?>]`: 
  - `[Justification <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[RequestState <String>]`: 
  - `[RequestStatus <String>]`: 
  - `[RequestType <String>]`: 
  - `[RequestorAltSecId <String>]`: 
  - `[RequestorDisplayName <String>]`: 
  - `[RequestorEmail <String>]`: 
  - `[RequestorId <String>]`: Read-only.
  - `[RequestorObjectId <String>]`: 
  - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
  - `[RequestorPrincipalName <String>]`: 
  - `[RequestorType <String>]`: 
  - `[TargetAltSecId <String>]`: 
  - `[TargetDisplayName <String>]`: 
  - `[TargetEmail <String>]`: 
  - `[TargetObjectId <String>]`: 
  - `[TargetOnPremisesSecurityIdentifier <String>]`: 
  - `[TargetPrincipalName <String>]`: 
  - `[TargetType <String>]`: 

ACCESSPACKAGEASSIGNMENTRESOURCEROLES <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[Id <String>]`: Read-only.
      - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
        - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
            - `[Id <String>]`: Read-only.
            - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
            - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
            - `[AccessPackageResourceAddedBy <String>]`: 
            - `[AccessPackageResourceAddedOn <DateTime?>]`: 
            - `[AccessPackageResourceDescription <String>]`: 
            - `[AccessPackageResourceDisplayName <String>]`: 
            - `[AccessPackageResourceId <String>]`: Read-only.
            - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
            - `[AccessPackageResourceOriginId <String>]`: 
            - `[AccessPackageResourceOriginSystem <String>]`: 
            - `[AccessPackageResourceType <String>]`: 
            - `[AccessPackageResourceUrl <String>]`: 
            - `[Description <String>]`: 
            - `[DisplayName <String>]`: 
            - `[IsRootScope <Boolean?>]`: 
            - `[OriginId <String>]`: 
            - `[OriginSystem <String>]`: 
            - `[RoleOriginId <String>]`: 
            - `[Url <String>]`: 
          - `[AccessPackageResourceAddedBy <String>]`: 
          - `[AccessPackageResourceAddedOn <DateTime?>]`: 
          - `[AccessPackageResourceDescription <String>]`: 
          - `[AccessPackageResourceDisplayName <String>]`: 
          - `[AccessPackageResourceId <String>]`: Read-only.
          - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
          - `[AccessPackageResourceOriginId <String>]`: 
          - `[AccessPackageResourceOriginSystem <String>]`: 
          - `[AccessPackageResourceType <String>]`: 
          - `[AccessPackageResourceUrl <String>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
        - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[AddedBy <String>]`: 
          - `[AddedOn <DateTime?>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[IsPendingOnboarding <Boolean?>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
          - `[ResourceType <String>]`: 
          - `[Url <String>]`: 
        - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
        - `[AccessPackageCatalogCreatedBy <String>]`: 
        - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
        - `[AccessPackageCatalogDescription <String>]`: 
        - `[AccessPackageCatalogDisplayName <String>]`: 
        - `[AccessPackageCatalogId <String>]`: Read-only.
        - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
        - `[AccessPackageCatalogModifiedBy <String>]`: 
        - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
        - `[AccessPackageCatalogStatus <String>]`: 
        - `[AccessPackageCatalogType <String>]`: 
        - `[AccessPackageId <String>]`: 
        - `[AccessReviewSettingDurationInDays <Int32?>]`: 
        - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
        - `[AccessReviewSettingRecurrenceType <String>]`: 
        - `[AccessReviewSettingReviewerType <String>]`: 
        - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
          - `[IsBackup <Boolean?>]`: 
        - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
        - `[CanExtend <Boolean?>]`: 
        - `[CreatedBy <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[DurationInDays <Int32?>]`: 
        - `[ExpirationDateTime <DateTime?>]`: 
        - `[ModifiedBy <String>]`: 
        - `[ModifiedDateTime <DateTime?>]`: 
        - `[RequestApprovalSettingApprovalMode <String>]`: 
        - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
          - `[ApprovalStageTimeOutInDays <Int32?>]`: 
          - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
          - `[EscalationTimeInMinutes <Int32?>]`: 
          - `[IsApproverJustificationRequired <Boolean?>]`: 
          - `[IsEscalationEnabled <Boolean?>]`: 
          - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
        - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
        - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
        - `[RequestorSettingAcceptRequests <Boolean?>]`: 
        - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
        - `[RequestorSettingScopeType <String>]`: 
      - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
      - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[AccessPackageCatalogCreatedBy <String>]`: 
      - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogDescription <String>]`: 
      - `[AccessPackageCatalogDisplayName <String>]`: 
      - `[AccessPackageCatalogId <String>]`: Read-only.
      - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
      - `[AccessPackageCatalogModifiedBy <String>]`: 
      - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogStatus <String>]`: 
      - `[AccessPackageCatalogType <String>]`: 
      - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
        - `[AccessPackageResourceRoleDescription <String>]`: 
        - `[AccessPackageResourceRoleDisplayName <String>]`: 
        - `[AccessPackageResourceRoleId <String>]`: Read-only.
        - `[AccessPackageResourceRoleOriginId <String>]`: 
        - `[AccessPackageResourceRoleOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
        - `[AccessPackageResourceScopeDescription <String>]`: 
        - `[AccessPackageResourceScopeDisplayName <String>]`: 
        - `[AccessPackageResourceScopeId <String>]`: Read-only.
        - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
        - `[AccessPackageResourceScopeOriginId <String>]`: 
        - `[AccessPackageResourceScopeOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
        - `[AccessPackageResourceScopeUrl <String>]`: 
        - `[CreatedBy <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[ModifiedBy <String>]`: 
        - `[ModifiedDateTime <DateTime?>]`: 
      - `[CatalogId <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsHidden <Boolean?>]`: 
      - `[IsRoleScopesVisible <Boolean?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageAssignmentAccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageAssignmentAccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
      - `[AccessPackageAssignmentAccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
      - `[AccessPackageAssignmentAccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
      - `[AccessPackageAssignmentAccessPackageId <String>]`: 
      - `[AccessPackageAssignmentCatalogId <String>]`: 
      - `[AccessPackageAssignmentExpiredDateTime <DateTime?>]`: 
      - `[AccessPackageAssignmentId <String>]`: Read-only.
      - `[AccessPackageAssignmentIsExtended <Boolean?>]`: 
      - `[AccessPackageAssignmentPolicyId <String>]`: 
      - `[AccessPackageAssignmentState <String>]`: 
      - `[AccessPackageAssignmentStatus <String>]`: 
      - `[AccessPackageAssignmentTargetId <String>]`: 
      - `[CompletedDate <DateTime?>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[IsValidationOnly <Boolean?>]`: 
      - `[Justification <String>]`: 
      - `[MicrosoftGraphEntityId <String>]`: Read-only.
      - `[RequestState <String>]`: 
      - `[RequestStatus <String>]`: 
      - `[RequestType <String>]`: 
      - `[RequestorAltSecId <String>]`: 
      - `[RequestorDisplayName <String>]`: 
      - `[RequestorEmail <String>]`: 
      - `[RequestorId <String>]`: Read-only.
      - `[RequestorObjectId <String>]`: 
      - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
      - `[RequestorPrincipalName <String>]`: 
      - `[RequestorType <String>]`: 
      - `[TargetAltSecId <String>]`: 
      - `[TargetDisplayName <String>]`: 
      - `[TargetEmail <String>]`: 
      - `[TargetObjectId <String>]`: 
      - `[TargetOnPremisesSecurityIdentifier <String>]`: 
      - `[TargetPrincipalName <String>]`: 
      - `[TargetType <String>]`: 
    - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AssignmentPolicyId <String>]`: 
    - `[AssignmentState <String>]`: 
    - `[AssignmentStatus <String>]`: 
    - `[CatalogId <String>]`: 
    - `[ExpiredDateTime <DateTime?>]`: 
    - `[IsExtended <Boolean?>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[TargetAltSecId <String>]`: 
    - `[TargetDisplayName <String>]`: 
    - `[TargetEmail <String>]`: 
    - `[TargetId <String>]`: 
    - `[TargetObjectId <String>]`: 
    - `[TargetOnPremisesSecurityIdentifier <String>]`: 
    - `[TargetPrincipalName <String>]`: 
    - `[TargetType <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
  - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
  - `[AccessPackageResourceRoleDescription <String>]`: 
  - `[AccessPackageResourceRoleDisplayName <String>]`: 
  - `[AccessPackageResourceRoleId <String>]`: Read-only.
  - `[AccessPackageResourceRoleOriginId <String>]`: 
  - `[AccessPackageResourceRoleOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
  - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
  - `[AccessPackageResourceScopeDescription <String>]`: 
  - `[AccessPackageResourceScopeDisplayName <String>]`: 
  - `[AccessPackageResourceScopeId <String>]`: Read-only.
  - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
  - `[AccessPackageResourceScopeOriginId <String>]`: 
  - `[AccessPackageResourceScopeOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
  - `[AccessPackageResourceScopeUrl <String>]`: 
  - `[AccessPackageSubjectAltSecId <String>]`: 
  - `[AccessPackageSubjectDisplayName <String>]`: 
  - `[AccessPackageSubjectEmail <String>]`: 
  - `[AccessPackageSubjectId <String>]`: Read-only.
  - `[AccessPackageSubjectObjectId <String>]`: 
  - `[AccessPackageSubjectOnPremisesSecurityIdentifier <String>]`: 
  - `[AccessPackageSubjectPrincipalName <String>]`: 
  - `[AccessPackageSubjectType <String>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Status <String>]`: 

ACCESSPACKAGEASSIGNMENTS <IMicrosoftGraphAccessPackageAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[AccessPackageResourceAddedBy <String>]`: 
          - `[AccessPackageResourceAddedOn <DateTime?>]`: 
          - `[AccessPackageResourceDescription <String>]`: 
          - `[AccessPackageResourceDisplayName <String>]`: 
          - `[AccessPackageResourceId <String>]`: Read-only.
          - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
          - `[AccessPackageResourceOriginId <String>]`: 
          - `[AccessPackageResourceOriginSystem <String>]`: 
          - `[AccessPackageResourceType <String>]`: 
          - `[AccessPackageResourceUrl <String>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[IsRootScope <Boolean?>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
          - `[RoleOriginId <String>]`: 
          - `[Url <String>]`: 
        - `[AccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceType <String>]`: 
        - `[AccessPackageResourceUrl <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
      - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AddedBy <String>]`: 
        - `[AddedOn <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsPendingOnboarding <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[ResourceType <String>]`: 
        - `[Url <String>]`: 
      - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[AccessPackageCatalogCreatedBy <String>]`: 
      - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogDescription <String>]`: 
      - `[AccessPackageCatalogDisplayName <String>]`: 
      - `[AccessPackageCatalogId <String>]`: Read-only.
      - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
      - `[AccessPackageCatalogModifiedBy <String>]`: 
      - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogStatus <String>]`: 
      - `[AccessPackageCatalogType <String>]`: 
      - `[AccessPackageId <String>]`: 
      - `[AccessReviewSettingDurationInDays <Int32?>]`: 
      - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
      - `[AccessReviewSettingRecurrenceType <String>]`: 
      - `[AccessReviewSettingReviewerType <String>]`: 
      - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
        - `[IsBackup <Boolean?>]`: 
      - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
      - `[CanExtend <Boolean?>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[DurationInDays <Int32?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[RequestApprovalSettingApprovalMode <String>]`: 
      - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
        - `[ApprovalStageTimeOutInDays <Int32?>]`: 
        - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[EscalationTimeInMinutes <Int32?>]`: 
        - `[IsApproverJustificationRequired <Boolean?>]`: 
        - `[IsEscalationEnabled <Boolean?>]`: 
        - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
      - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
      - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
      - `[RequestorSettingAcceptRequests <Boolean?>]`: 
      - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestorSettingScopeType <String>]`: 
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[CatalogId <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsHidden <Boolean?>]`: 
    - `[IsRoleScopesVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignmentAccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignmentAccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[AccessPackageAssignmentAccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[AccessPackageAssignmentAccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[AccessPackageSubjectAltSecId <String>]`: 
      - `[AccessPackageSubjectDisplayName <String>]`: 
      - `[AccessPackageSubjectEmail <String>]`: 
      - `[AccessPackageSubjectId <String>]`: Read-only.
      - `[AccessPackageSubjectObjectId <String>]`: 
      - `[AccessPackageSubjectOnPremisesSecurityIdentifier <String>]`: 
      - `[AccessPackageSubjectPrincipalName <String>]`: 
      - `[AccessPackageSubjectType <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Status <String>]`: 
    - `[AccessPackageAssignmentAccessPackageId <String>]`: 
    - `[AccessPackageAssignmentCatalogId <String>]`: 
    - `[AccessPackageAssignmentExpiredDateTime <DateTime?>]`: 
    - `[AccessPackageAssignmentId <String>]`: Read-only.
    - `[AccessPackageAssignmentIsExtended <Boolean?>]`: 
    - `[AccessPackageAssignmentPolicyId <String>]`: 
    - `[AccessPackageAssignmentState <String>]`: 
    - `[AccessPackageAssignmentStatus <String>]`: 
    - `[AccessPackageAssignmentTargetId <String>]`: 
    - `[CompletedDate <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsValidationOnly <Boolean?>]`: 
    - `[Justification <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[RequestState <String>]`: 
    - `[RequestStatus <String>]`: 
    - `[RequestType <String>]`: 
    - `[RequestorAltSecId <String>]`: 
    - `[RequestorDisplayName <String>]`: 
    - `[RequestorEmail <String>]`: 
    - `[RequestorId <String>]`: Read-only.
    - `[RequestorObjectId <String>]`: 
    - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
    - `[RequestorPrincipalName <String>]`: 
    - `[RequestorType <String>]`: 
    - `[TargetAltSecId <String>]`: 
    - `[TargetDisplayName <String>]`: 
    - `[TargetEmail <String>]`: 
    - `[TargetObjectId <String>]`: 
    - `[TargetOnPremisesSecurityIdentifier <String>]`: 
    - `[TargetPrincipalName <String>]`: 
    - `[TargetType <String>]`: 
  - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
  - `[AccessPackageId <String>]`: 
  - `[AssignmentPolicyId <String>]`: 
  - `[AssignmentState <String>]`: 
  - `[AssignmentStatus <String>]`: 
  - `[CatalogId <String>]`: 
  - `[ExpiredDateTime <DateTime?>]`: 
  - `[IsExtended <Boolean?>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[TargetAltSecId <String>]`: 
  - `[TargetDisplayName <String>]`: 
  - `[TargetEmail <String>]`: 
  - `[TargetId <String>]`: 
  - `[TargetObjectId <String>]`: 
  - `[TargetOnPremisesSecurityIdentifier <String>]`: 
  - `[TargetPrincipalName <String>]`: 
  - `[TargetType <String>]`: 

ACCESSPACKAGECATALOGS <IMicrosoftGraphAccessPackageCatalog[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[RoleOriginId <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceType <String>]`: 
    - `[AccessPackageResourceUrl <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AddedBy <String>]`: 
    - `[AddedOn <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsPendingOnboarding <Boolean?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Url <String>]`: 
  - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
      - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[AccessPackageCatalogCreatedBy <String>]`: 
      - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogDescription <String>]`: 
      - `[AccessPackageCatalogDisplayName <String>]`: 
      - `[AccessPackageCatalogId <String>]`: Read-only.
      - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
      - `[AccessPackageCatalogModifiedBy <String>]`: 
      - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogStatus <String>]`: 
      - `[AccessPackageCatalogType <String>]`: 
      - `[AccessPackageId <String>]`: 
      - `[AccessReviewSettingDurationInDays <Int32?>]`: 
      - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
      - `[AccessReviewSettingRecurrenceType <String>]`: 
      - `[AccessReviewSettingReviewerType <String>]`: 
      - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
        - `[IsBackup <Boolean?>]`: 
      - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
      - `[CanExtend <Boolean?>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[DurationInDays <Int32?>]`: 
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[RequestApprovalSettingApprovalMode <String>]`: 
      - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
        - `[ApprovalStageTimeOutInDays <Int32?>]`: 
        - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
        - `[EscalationTimeInMinutes <Int32?>]`: 
        - `[IsApproverJustificationRequired <Boolean?>]`: 
        - `[IsEscalationEnabled <Boolean?>]`: 
        - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
      - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
      - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
      - `[RequestorSettingAcceptRequests <Boolean?>]`: 
      - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
      - `[RequestorSettingScopeType <String>]`: 
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[CatalogId <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsHidden <Boolean?>]`: 
    - `[IsRoleScopesVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[CatalogStatus <String>]`: 
  - `[CatalogType <String>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsExternallyVisible <Boolean?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

ACCESSPACKAGERESOURCEREQUESTS <IMicrosoftGraphAccessPackageResourceRequest[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[RoleOriginId <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceType <String>]`: 
    - `[AccessPackageResourceUrl <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResourceAddedBy <String>]`: 
  - `[AccessPackageResourceAddedOn <DateTime?>]`: 
  - `[AccessPackageResourceDescription <String>]`: 
  - `[AccessPackageResourceDisplayName <String>]`: 
  - `[AccessPackageResourceId <String>]`: Read-only.
  - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
  - `[AccessPackageResourceOriginId <String>]`: 
  - `[AccessPackageResourceOriginSystem <String>]`: 
  - `[AccessPackageResourceType <String>]`: 
  - `[AccessPackageResourceUrl <String>]`: 
  - `[CatalogId <String>]`: 
  - `[ExecuteImmediately <Boolean?>]`: 
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[IsValidationOnly <Boolean?>]`: 
  - `[Justification <String>]`: 
  - `[RequestState <String>]`: 
  - `[RequestStatus <String>]`: 
  - `[RequestType <String>]`: 
  - `[RequestorAltSecId <String>]`: 
  - `[RequestorDisplayName <String>]`: 
  - `[RequestorEmail <String>]`: 
  - `[RequestorId <String>]`: Read-only.
  - `[RequestorObjectId <String>]`: 
  - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
  - `[RequestorPrincipalName <String>]`: 
  - `[RequestorType <String>]`: 

ACCESSPACKAGERESOURCEROLESCOPES <IMicrosoftGraphAccessPackageResourceRoleScope[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[RoleOriginId <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceType <String>]`: 
    - `[AccessPackageResourceUrl <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
  - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
  - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
  - `[AccessPackageResourceRoleDescription <String>]`: 
  - `[AccessPackageResourceRoleDisplayName <String>]`: 
  - `[AccessPackageResourceRoleId <String>]`: Read-only.
  - `[AccessPackageResourceRoleOriginId <String>]`: 
  - `[AccessPackageResourceRoleOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
  - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
  - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
  - `[AccessPackageResourceScopeDescription <String>]`: 
  - `[AccessPackageResourceScopeDisplayName <String>]`: 
  - `[AccessPackageResourceScopeId <String>]`: Read-only.
  - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
  - `[AccessPackageResourceScopeOriginId <String>]`: 
  - `[AccessPackageResourceScopeOriginSystem <String>]`: 
  - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
  - `[AccessPackageResourceScopeUrl <String>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

ACCESSPACKAGERESOURCES <IMicrosoftGraphAccessPackageResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[RoleOriginId <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceType <String>]`: 
    - `[AccessPackageResourceUrl <String>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AddedBy <String>]`: 
  - `[AddedOn <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsPendingOnboarding <Boolean?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[ResourceType <String>]`: 
  - `[Url <String>]`: 

ACCESSPACKAGES <IMicrosoftGraphAccessPackage[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceType <String>]`: 
        - `[AccessPackageResourceUrl <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsRootScope <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[RoleOriginId <String>]`: 
        - `[Url <String>]`: 
      - `[AccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceType <String>]`: 
      - `[AccessPackageResourceUrl <String>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AddedBy <String>]`: 
      - `[AddedOn <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsPendingOnboarding <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[ResourceType <String>]`: 
      - `[Url <String>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AccessReviewSettingDurationInDays <Int32?>]`: 
    - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
    - `[AccessReviewSettingRecurrenceType <String>]`: 
    - `[AccessReviewSettingReviewerType <String>]`: 
    - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
      - `[IsBackup <Boolean?>]`: 
    - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
    - `[CanExtend <Boolean?>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[DurationInDays <Int32?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[RequestApprovalSettingApprovalMode <String>]`: 
    - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
      - `[ApprovalStageTimeOutInDays <Int32?>]`: 
      - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[EscalationTimeInMinutes <Int32?>]`: 
      - `[IsApproverJustificationRequired <Boolean?>]`: 
      - `[IsEscalationEnabled <Boolean?>]`: 
      - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
    - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
    - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
    - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
    - `[RequestorSettingAcceptRequests <Boolean?>]`: 
    - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
    - `[RequestorSettingScopeType <String>]`: 
  - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
  - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
  - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
  - `[AccessPackageCatalogCreatedBy <String>]`: 
  - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
  - `[AccessPackageCatalogDescription <String>]`: 
  - `[AccessPackageCatalogDisplayName <String>]`: 
  - `[AccessPackageCatalogId <String>]`: Read-only.
  - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
  - `[AccessPackageCatalogModifiedBy <String>]`: 
  - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageCatalogStatus <String>]`: 
  - `[AccessPackageCatalogType <String>]`: 
  - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
    - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
    - `[AccessPackageResourceRoleDescription <String>]`: 
    - `[AccessPackageResourceRoleDisplayName <String>]`: 
    - `[AccessPackageResourceRoleId <String>]`: Read-only.
    - `[AccessPackageResourceRoleOriginId <String>]`: 
    - `[AccessPackageResourceRoleOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
    - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
    - `[AccessPackageResourceScopeDescription <String>]`: 
    - `[AccessPackageResourceScopeDisplayName <String>]`: 
    - `[AccessPackageResourceScopeId <String>]`: Read-only.
    - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
    - `[AccessPackageResourceScopeOriginId <String>]`: 
    - `[AccessPackageResourceScopeOriginSystem <String>]`: 
    - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
    - `[AccessPackageResourceScopeUrl <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[CatalogId <String>]`: 
  - `[CreatedBy <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsHidden <Boolean?>]`: 
  - `[IsRoleScopesVisible <Boolean?>]`: 
  - `[ModifiedBy <String>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 

BODYPARAMETER <IMicrosoftGraphEntitlementManagement>: entitlementManagement
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[Id <String>]`: Read-only.
      - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: 
      - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
          - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
          - `[AccessPackageResourceAddedBy <String>]`: 
          - `[AccessPackageResourceAddedOn <DateTime?>]`: 
          - `[AccessPackageResourceDescription <String>]`: 
          - `[AccessPackageResourceDisplayName <String>]`: 
          - `[AccessPackageResourceId <String>]`: Read-only.
          - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
          - `[AccessPackageResourceOriginId <String>]`: 
          - `[AccessPackageResourceOriginSystem <String>]`: 
          - `[AccessPackageResourceType <String>]`: 
          - `[AccessPackageResourceUrl <String>]`: 
          - `[Description <String>]`: 
          - `[DisplayName <String>]`: 
          - `[IsRootScope <Boolean?>]`: 
          - `[OriginId <String>]`: 
          - `[OriginSystem <String>]`: 
          - `[RoleOriginId <String>]`: 
          - `[Url <String>]`: 
        - `[AccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceType <String>]`: 
        - `[AccessPackageResourceUrl <String>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
      - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AddedBy <String>]`: 
        - `[AddedOn <DateTime?>]`: 
        - `[Description <String>]`: 
        - `[DisplayName <String>]`: 
        - `[IsPendingOnboarding <Boolean?>]`: 
        - `[OriginId <String>]`: 
        - `[OriginSystem <String>]`: 
        - `[ResourceType <String>]`: 
        - `[Url <String>]`: 
      - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
      - `[AccessPackageCatalogCreatedBy <String>]`: 
      - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogDescription <String>]`: 
      - `[AccessPackageCatalogDisplayName <String>]`: 
      - `[AccessPackageCatalogId <String>]`: Read-only.
      - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
      - `[AccessPackageCatalogModifiedBy <String>]`: 
      - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
      - `[AccessPackageCatalogStatus <String>]`: 
      - `[AccessPackageCatalogType <String>]`: 
      - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
        - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
        - `[AccessPackageResourceRoleDescription <String>]`: 
        - `[AccessPackageResourceRoleDisplayName <String>]`: 
        - `[AccessPackageResourceRoleId <String>]`: Read-only.
        - `[AccessPackageResourceRoleOriginId <String>]`: 
        - `[AccessPackageResourceRoleOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
        - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
        - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
        - `[AccessPackageResourceScopeDescription <String>]`: 
        - `[AccessPackageResourceScopeDisplayName <String>]`: 
        - `[AccessPackageResourceScopeId <String>]`: Read-only.
        - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
        - `[AccessPackageResourceScopeOriginId <String>]`: 
        - `[AccessPackageResourceScopeOriginSystem <String>]`: 
        - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
        - `[AccessPackageResourceScopeUrl <String>]`: 
        - `[CreatedBy <String>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[ModifiedBy <String>]`: 
        - `[ModifiedDateTime <DateTime?>]`: 
      - `[CatalogId <String>]`: 
      - `[CreatedBy <String>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsHidden <Boolean?>]`: 
      - `[IsRoleScopesVisible <Boolean?>]`: 
      - `[ModifiedBy <String>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageCatalogAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageCatalogAccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[AccessPackageCatalogAccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[AccessPackageCatalogCreatedBy <String>]`: 
    - `[AccessPackageCatalogCreatedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogDescription <String>]`: 
    - `[AccessPackageCatalogDisplayName <String>]`: 
    - `[AccessPackageCatalogId <String>]`: Read-only.
    - `[AccessPackageCatalogIsExternallyVisible <Boolean?>]`: 
    - `[AccessPackageCatalogModifiedBy <String>]`: 
    - `[AccessPackageCatalogModifiedDateTime <DateTime?>]`: 
    - `[AccessPackageCatalogStatus <String>]`: 
    - `[AccessPackageCatalogType <String>]`: 
    - `[AccessPackageId <String>]`: 
    - `[AccessReviewSettingDurationInDays <Int32?>]`: 
    - `[AccessReviewSettingIsEnabled <Boolean?>]`: 
    - `[AccessReviewSettingRecurrenceType <String>]`: 
    - `[AccessReviewSettingReviewerType <String>]`: 
    - `[AccessReviewSettingReviewers <IMicrosoftGraphUserSet[]>]`: 
      - `[IsBackup <Boolean?>]`: 
    - `[AccessReviewSettingStartDateTime <DateTime?>]`: 
    - `[CanExtend <Boolean?>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[DurationInDays <Int32?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[RequestApprovalSettingApprovalMode <String>]`: 
    - `[RequestApprovalSettingApprovalStages <IMicrosoftGraphApprovalStage[]>]`: 
      - `[ApprovalStageTimeOutInDays <Int32?>]`: 
      - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: 
      - `[EscalationTimeInMinutes <Int32?>]`: 
      - `[IsApproverJustificationRequired <Boolean?>]`: 
      - `[IsEscalationEnabled <Boolean?>]`: 
      - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: 
    - `[RequestApprovalSettingIsApprovalRequired <Boolean?>]`: 
    - `[RequestApprovalSettingIsApprovalRequiredForExtension <Boolean?>]`: 
    - `[RequestApprovalSettingIsRequestorJustificationRequired <Boolean?>]`: 
    - `[RequestorSettingAcceptRequests <Boolean?>]`: 
    - `[RequestorSettingAllowedRequestors <IMicrosoftGraphUserSet[]>]`: 
    - `[RequestorSettingScopeType <String>]`: 
  - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignmentAccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageAssignmentAccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
    - `[AccessPackageAssignmentAccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
    - `[AccessPackageAssignmentAccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
        - `[AccessPackageAssignmentPolicy <IMicrosoftGraphAccessPackageAssignmentPolicy>]`: accessPackageAssignmentPolicy
        - `[AccessPackageAssignmentRequests <IMicrosoftGraphAccessPackageAssignmentRequest[]>]`: 
        - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
        - `[AccessPackageId <String>]`: 
        - `[AssignmentPolicyId <String>]`: 
        - `[AssignmentState <String>]`: 
        - `[AssignmentStatus <String>]`: 
        - `[CatalogId <String>]`: 
        - `[ExpiredDateTime <DateTime?>]`: 
        - `[IsExtended <Boolean?>]`: 
        - `[MicrosoftGraphEntityId <String>]`: Read-only.
        - `[TargetAltSecId <String>]`: 
        - `[TargetDisplayName <String>]`: 
        - `[TargetEmail <String>]`: 
        - `[TargetId <String>]`: 
        - `[TargetObjectId <String>]`: 
        - `[TargetOnPremisesSecurityIdentifier <String>]`: 
        - `[TargetPrincipalName <String>]`: 
        - `[TargetType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceRoleAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceRoleAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceRoleDescription <String>]`: 
      - `[AccessPackageResourceRoleDisplayName <String>]`: 
      - `[AccessPackageResourceRoleId <String>]`: Read-only.
      - `[AccessPackageResourceRoleOriginId <String>]`: 
      - `[AccessPackageResourceRoleOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedBy <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceAddedOn <DateTime?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDescription <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceDisplayName <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceId <String>]`: Read-only.
      - `[AccessPackageResourceScopeAccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginId <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceResourceType <String>]`: 
      - `[AccessPackageResourceScopeAccessPackageResourceUrl <String>]`: 
      - `[AccessPackageResourceScopeDescription <String>]`: 
      - `[AccessPackageResourceScopeDisplayName <String>]`: 
      - `[AccessPackageResourceScopeId <String>]`: Read-only.
      - `[AccessPackageResourceScopeIsRootScope <Boolean?>]`: 
      - `[AccessPackageResourceScopeOriginId <String>]`: 
      - `[AccessPackageResourceScopeOriginSystem <String>]`: 
      - `[AccessPackageResourceScopeRoleOriginId <String>]`: 
      - `[AccessPackageResourceScopeUrl <String>]`: 
      - `[AccessPackageSubjectAltSecId <String>]`: 
      - `[AccessPackageSubjectDisplayName <String>]`: 
      - `[AccessPackageSubjectEmail <String>]`: 
      - `[AccessPackageSubjectId <String>]`: Read-only.
      - `[AccessPackageSubjectObjectId <String>]`: 
      - `[AccessPackageSubjectOnPremisesSecurityIdentifier <String>]`: 
      - `[AccessPackageSubjectPrincipalName <String>]`: 
      - `[AccessPackageSubjectType <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Status <String>]`: 
    - `[AccessPackageAssignmentAccessPackageId <String>]`: 
    - `[AccessPackageAssignmentCatalogId <String>]`: 
    - `[AccessPackageAssignmentExpiredDateTime <DateTime?>]`: 
    - `[AccessPackageAssignmentId <String>]`: Read-only.
    - `[AccessPackageAssignmentIsExtended <Boolean?>]`: 
    - `[AccessPackageAssignmentPolicyId <String>]`: 
    - `[AccessPackageAssignmentState <String>]`: 
    - `[AccessPackageAssignmentStatus <String>]`: 
    - `[AccessPackageAssignmentTargetId <String>]`: 
    - `[CompletedDate <DateTime?>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsValidationOnly <Boolean?>]`: 
    - `[Justification <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[RequestState <String>]`: 
    - `[RequestStatus <String>]`: 
    - `[RequestType <String>]`: 
    - `[RequestorAltSecId <String>]`: 
    - `[RequestorDisplayName <String>]`: 
    - `[RequestorEmail <String>]`: 
    - `[RequestorId <String>]`: Read-only.
    - `[RequestorObjectId <String>]`: 
    - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
    - `[RequestorPrincipalName <String>]`: 
    - `[RequestorType <String>]`: 
    - `[TargetAltSecId <String>]`: 
    - `[TargetDisplayName <String>]`: 
    - `[TargetEmail <String>]`: 
    - `[TargetObjectId <String>]`: 
    - `[TargetOnPremisesSecurityIdentifier <String>]`: 
    - `[TargetPrincipalName <String>]`: 
    - `[TargetType <String>]`: 
  - `[AccessPackageAssignmentResourceRoles <IMicrosoftGraphAccessPackageAssignmentResourceRole[]>]`: 
  - `[AccessPackageAssignments <IMicrosoftGraphAccessPackageAssignment[]>]`: 
  - `[AccessPackageCatalogs <IMicrosoftGraphAccessPackageCatalog[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: 
    - `[CatalogStatus <String>]`: 
    - `[CatalogType <String>]`: 
    - `[CreatedBy <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsExternallyVisible <Boolean?>]`: 
    - `[ModifiedBy <String>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
  - `[AccessPackageResourceRequests <IMicrosoftGraphAccessPackageResourceRequest[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceAccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[AccessPackageResourceAccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[AccessPackageResourceAddedBy <String>]`: 
    - `[AccessPackageResourceAddedOn <DateTime?>]`: 
    - `[AccessPackageResourceDescription <String>]`: 
    - `[AccessPackageResourceDisplayName <String>]`: 
    - `[AccessPackageResourceId <String>]`: Read-only.
    - `[AccessPackageResourceIsPendingOnboarding <Boolean?>]`: 
    - `[AccessPackageResourceOriginId <String>]`: 
    - `[AccessPackageResourceOriginSystem <String>]`: 
    - `[AccessPackageResourceType <String>]`: 
    - `[AccessPackageResourceUrl <String>]`: 
    - `[CatalogId <String>]`: 
    - `[ExecuteImmediately <Boolean?>]`: 
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsValidationOnly <Boolean?>]`: 
    - `[Justification <String>]`: 
    - `[RequestState <String>]`: 
    - `[RequestStatus <String>]`: 
    - `[RequestType <String>]`: 
    - `[RequestorAltSecId <String>]`: 
    - `[RequestorDisplayName <String>]`: 
    - `[RequestorEmail <String>]`: 
    - `[RequestorId <String>]`: Read-only.
    - `[RequestorObjectId <String>]`: 
    - `[RequestorOnPremisesSecurityIdentifier <String>]`: 
    - `[RequestorPrincipalName <String>]`: 
    - `[RequestorType <String>]`: 
  - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: 
  - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: 
  - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: 

## RELATED LINKS

