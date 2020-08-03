---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprint
schema: 2.0.0
---

# Update-MgPrint

## SYNOPSIS
Update print

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrint [-Connectors <IMicrosoftGraphPrintConnector[]>] [-Id <String>]
 [-Printers <IMicrosoftGraphPrinter[]>] [-PrinterShares <IMicrosoftGraphPrinterShare[]>]
 [-Reports <IMicrosoftGraphReportRoot[]>] [-Services <IMicrosoftGraphPrintService[]>]
 [-SettingDocumentConversionEnabled] [-Shares <IMicrosoftGraphPrinterShare[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrint -BodyParameter <IMicrosoftGraphPrint> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update print

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

### -BodyParameter
print
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrint
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Connectors
.
To construct, see NOTES section for CONNECTORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector[]
Parameter Sets: UpdateExpanded
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

### -Printers
.
To construct, see NOTES section for PRINTERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrinterShares
.
To construct, see NOTES section for PRINTERSHARES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reports
.
To construct, see NOTES section for REPORTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Services
.
To construct, see NOTES section for SERVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintService[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingDocumentConversionEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Shares
.
To construct, see NOTES section for SHARES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrint

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrint>: print
  - `[Id <String>]`: Read-only.
  - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppVersion <String>]`: 
    - `[DeviceHealthLastConnectionTime <DateTime?>]`: 
    - `[FullyQualifiedDomainName <String>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Name <String>]`: 
    - `[OperatingSystem <String>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
  - `[PrinterShares <IMicrosoftGraphPrinterShare[]>]`: 
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
      - `[BottomMargins <Int32[]>]`: 
      - `[Collation <Boolean?>]`: 
      - `[ColorModes <String[]>]`: 
      - `[ContentTypes <String[]>]`: 
      - `[CopyPerJobEnd <Int64?>]`: 
      - `[CopyPerJobMaximum <Int64?>]`: 
      - `[CopyPerJobMinimum <Int64?>]`: 
      - `[CopyPerJobStart <Int64?>]`: 
      - `[Dpis <Int32[]>]`: 
      - `[DuplexModes <String[]>]`: 
      - `[FeedDirections <String[]>]`: 
      - `[Finishings <String[]>]`: 
      - `[InputBins <String[]>]`: 
      - `[IsColorPrintingSupported <Boolean?>]`: 
      - `[IsPageRangeSupported <Boolean?>]`: 
      - `[LeftMargins <Int32[]>]`: 
      - `[MediaColors <String[]>]`: 
      - `[MediaSizes <String[]>]`: 
      - `[MediaTypes <String[]>]`: 
      - `[MultipageLayouts <String[]>]`: 
      - `[Orientations <String[]>]`: 
      - `[OutputBins <String[]>]`: 
      - `[PagesPerSheet <Int32[]>]`: 
      - `[Qualities <String[]>]`: 
      - `[RightMargins <Int32[]>]`: 
      - `[Scalings <String[]>]`: 
      - `[SupportedColorConfigurations <String[]>]`: 
      - `[SupportedCopyPerJobEnd <Int64?>]`: 
      - `[SupportedCopyPerJobMaximum <Int64?>]`: 
      - `[SupportedCopyPerJobMinimum <Int64?>]`: 
      - `[SupportedCopyPerJobStart <Int64?>]`: 
      - `[SupportedDocumentMimeTypes <String[]>]`: 
      - `[SupportedDuplexConfigurations <String[]>]`: 
      - `[SupportedFinishings <String[]>]`: 
      - `[SupportedMediaColors <String[]>]`: 
      - `[SupportedMediaSizes <String[]>]`: 
      - `[SupportedMediaTypes <String[]>]`: 
      - `[SupportedOrientations <String[]>]`: 
      - `[SupportedOutputBins <String[]>]`: 
      - `[SupportedPagePerSheetEnd <Int64?>]`: 
      - `[SupportedPagePerSheetMaximum <Int64?>]`: 
      - `[SupportedPagePerSheetMinimum <Int64?>]`: 
      - `[SupportedPagePerSheetStart <Int64?>]`: 
      - `[SupportedPresentationDirections <String[]>]`: 
      - `[SupportedPrintQualities <String[]>]`: 
      - `[SupportsFitPdfToPage <Boolean?>]`: 
      - `[TopMargins <Int32[]>]`: 
    - `[DefaultColorMode <String>]`: printColorMode
    - `[DefaultContentType <String>]`: 
    - `[DefaultCopiesPerJob <Int32?>]`: 
    - `[DefaultDocumentMimeType <String>]`: 
    - `[DefaultDpi <Int32?>]`: 
    - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DefaultDuplexMode <String>]`: printDuplexMode
    - `[DefaultFinishings <String[]>]`: 
    - `[DefaultFitPdfToPage <Boolean?>]`: 
    - `[DefaultMediaColor <String>]`: 
    - `[DefaultMediaSize <String>]`: 
    - `[DefaultMediaType <String>]`: printMediaType
    - `[DefaultMultipageLayout <String>]`: printMultipageLayout
    - `[DefaultOrientation <String>]`: printOrientation
    - `[DefaultOutputBin <String>]`: 
    - `[DefaultPagesPerSheet <Int32?>]`: 
    - `[DefaultPdfFitToPage <Boolean?>]`: 
    - `[DefaultPresentationDirection <String>]`: printPresentationDirection
    - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
    - `[DefaultPrintQuality <String>]`: printQuality
    - `[DefaultQuality <String>]`: printQuality
    - `[DefaultScaling <String>]`: printScaling
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
      - `[CreatedById <String>]`: Unique identifier for the identity.
      - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[DocumentConfigurationColorConfiguration <String>]`: printColorConfiguration
        - `[DocumentConfigurationCopies <Int32?>]`: 
        - `[DocumentConfigurationDuplexConfiguration <String>]`: printDuplexConfiguration
        - `[DocumentConfigurationFeedDirection <String>]`: printerFeedDirection
        - `[DocumentConfigurationOrientation <String>]`: printOrientation
        - `[DocumentConfigurationPageRanges <IMicrosoftGraphPrintPageRange[]>]`: 
          - `[EndPage <Int32?>]`: 
          - `[StartPage <Int32?>]`: 
        - `[DocumentConfigurationPrintQuality <String>]`: printQuality
        - `[DocumentConfigurationPrintResolutionInDpi <Int32?>]`: 
        - `[MimeType <String>]`: 
        - `[Name <String>]`: 
        - `[SizeInBytes <Int64?>]`: 
      - `[StatusAcquiredByPrinter <Boolean?>]`: 
      - `[StatusProcessingState <String>]`: printJobProcessingState
      - `[StatusProcessingStateDescription <String>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[StatusProcessingState <String>]`: printerProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
    - `[StatusProcessingStateReasons <String[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
      - `[IPAddress <String>]`: 
      - `[UserPrincipalName <String>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Printer <IMicrosoftGraphPrinter>]`: printer
      - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
      - `[DefaultColorMode <String>]`: printColorMode
      - `[DefaultContentType <String>]`: 
      - `[DefaultCopiesPerJob <Int32?>]`: 
      - `[DefaultDocumentMimeType <String>]`: 
      - `[DefaultDpi <Int32?>]`: 
      - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
      - `[DefaultDuplexMode <String>]`: printDuplexMode
      - `[DefaultFinishings <String[]>]`: 
      - `[DefaultFitPdfToPage <Boolean?>]`: 
      - `[DefaultMediaColor <String>]`: 
      - `[DefaultMediaSize <String>]`: 
      - `[DefaultMediaType <String>]`: printMediaType
      - `[DefaultMultipageLayout <String>]`: printMultipageLayout
      - `[DefaultOrientation <String>]`: printOrientation
      - `[DefaultOutputBin <String>]`: 
      - `[DefaultPagesPerSheet <Int32?>]`: 
      - `[DefaultPdfFitToPage <Boolean?>]`: 
      - `[DefaultPresentationDirection <String>]`: printPresentationDirection
      - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
      - `[DefaultPrintQuality <String>]`: printQuality
      - `[DefaultQuality <String>]`: printQuality
      - `[DefaultScaling <String>]`: printScaling
      - `[IsAcceptingJobs <Boolean?>]`: 
      - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
      - `[LocationAltitudeInMeters <Int32?>]`: 
      - `[LocationBuilding <String>]`: 
      - `[LocationCity <String>]`: 
      - `[LocationCountryOrRegion <String>]`: 
      - `[LocationFloorDescription <String>]`: 
      - `[LocationFloorNumber <Int32?>]`: 
      - `[LocationLatitude <Single?>]`: 
      - `[LocationLongitude <Single?>]`: 
      - `[LocationOrganization <String[]>]`: 
      - `[LocationPostalCode <String>]`: 
      - `[LocationRoomDescription <String>]`: 
      - `[LocationRoomNumber <Int32?>]`: 
      - `[LocationSite <String>]`: 
      - `[LocationStateOrProvince <String>]`: 
      - `[LocationStreetAddress <String>]`: 
      - `[LocationSubdivision <String[]>]`: 
      - `[LocationSubunit <String[]>]`: 
      - `[Manufacturer <String>]`: 
      - `[Model <String>]`: 
      - `[Name <String>]`: 
      - `[StatusProcessingState <String>]`: printerProcessingState
      - `[StatusProcessingStateDescription <String>]`: 
      - `[StatusProcessingStateReasons <String[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AcceptingJobs <Boolean?>]`: 
      - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
      - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
      - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
      - `[IsShared <Boolean?>]`: 
      - `[RegisteredDateTime <DateTime?>]`: 
      - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare
  - `[Printers <IMicrosoftGraphPrinter[]>]`: 
  - `[Reports <IMicrosoftGraphReportRoot[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AggregatedEventDateTime <DateTime?>]`: 
      - `[AppDisplayName <String>]`: 
      - `[AppId <String>]`: 
      - `[SignInCount <Int64?>]`: 
      - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
      - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
      - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
    - `[CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AuthMethods <String[]>]`: 
      - `[IsCapable <Boolean?>]`: 
      - `[IsEnabled <Boolean?>]`: 
      - `[IsMfaRegistered <Boolean?>]`: 
      - `[IsRegistered <Boolean?>]`: 
      - `[UserDisplayName <String>]`: 
      - `[UserPrincipalName <String>]`: 
    - `[DailyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
      - `[CompletedColorJobCount <Int64?>]`: 
      - `[IncompleteJobCount <Int64?>]`: 
      - `[PrinterId <String>]`: 
      - `[UsageDate <DateTime?>]`: 
    - `[DailyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
      - `[CompletedColorJobCount <Int64?>]`: 
      - `[IncompleteJobCount <Int64?>]`: 
      - `[UsageDate <DateTime?>]`: 
      - `[UserPrincipalName <String>]`: 
    - `[MonthlyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]`: 
    - `[MonthlyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>]`: 
    - `[UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AuthMethod <String>]`: usageAuthMethod
      - `[EventDateTime <DateTime?>]`: 
      - `[FailureReason <String>]`: 
      - `[Feature <String>]`: featureType
      - `[IsSuccess <Boolean?>]`: 
      - `[UserDisplayName <String>]`: 
      - `[UserPrincipalName <String>]`: 
  - `[Services <IMicrosoftGraphPrintService[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Endpoints <IMicrosoftGraphPrintServiceEndpoint[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: 
      - `[Uri <String>]`: 
  - `[SettingDocumentConversionEnabled <Boolean?>]`: 
  - `[Shares <IMicrosoftGraphPrinterShare[]>]`: 

CONNECTORS <IMicrosoftGraphPrintConnector[]>: .
  - `[Id <String>]`: Read-only.
  - `[AppVersion <String>]`: 
  - `[DeviceHealthLastConnectionTime <DateTime?>]`: 
  - `[FullyQualifiedDomainName <String>]`: 
  - `[LocationAltitudeInMeters <Int32?>]`: 
  - `[LocationBuilding <String>]`: 
  - `[LocationCity <String>]`: 
  - `[LocationCountryOrRegion <String>]`: 
  - `[LocationFloorDescription <String>]`: 
  - `[LocationFloorNumber <Int32?>]`: 
  - `[LocationLatitude <Single?>]`: 
  - `[LocationLongitude <Single?>]`: 
  - `[LocationOrganization <String[]>]`: 
  - `[LocationPostalCode <String>]`: 
  - `[LocationRoomDescription <String>]`: 
  - `[LocationRoomNumber <Int32?>]`: 
  - `[LocationSite <String>]`: 
  - `[LocationStateOrProvince <String>]`: 
  - `[LocationStreetAddress <String>]`: 
  - `[LocationSubdivision <String[]>]`: 
  - `[LocationSubunit <String[]>]`: 
  - `[Name <String>]`: 
  - `[OperatingSystem <String>]`: 
  - `[RegisteredDateTime <DateTime?>]`: 

PRINTERS <IMicrosoftGraphPrinter[]>: .
  - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[BottomMargins <Int32[]>]`: 
    - `[Collation <Boolean?>]`: 
    - `[ColorModes <String[]>]`: 
    - `[ContentTypes <String[]>]`: 
    - `[CopyPerJobEnd <Int64?>]`: 
    - `[CopyPerJobMaximum <Int64?>]`: 
    - `[CopyPerJobMinimum <Int64?>]`: 
    - `[CopyPerJobStart <Int64?>]`: 
    - `[Dpis <Int32[]>]`: 
    - `[DuplexModes <String[]>]`: 
    - `[FeedDirections <String[]>]`: 
    - `[Finishings <String[]>]`: 
    - `[InputBins <String[]>]`: 
    - `[IsColorPrintingSupported <Boolean?>]`: 
    - `[IsPageRangeSupported <Boolean?>]`: 
    - `[LeftMargins <Int32[]>]`: 
    - `[MediaColors <String[]>]`: 
    - `[MediaSizes <String[]>]`: 
    - `[MediaTypes <String[]>]`: 
    - `[MultipageLayouts <String[]>]`: 
    - `[Orientations <String[]>]`: 
    - `[OutputBins <String[]>]`: 
    - `[PagesPerSheet <Int32[]>]`: 
    - `[Qualities <String[]>]`: 
    - `[RightMargins <Int32[]>]`: 
    - `[Scalings <String[]>]`: 
    - `[SupportedColorConfigurations <String[]>]`: 
    - `[SupportedCopyPerJobEnd <Int64?>]`: 
    - `[SupportedCopyPerJobMaximum <Int64?>]`: 
    - `[SupportedCopyPerJobMinimum <Int64?>]`: 
    - `[SupportedCopyPerJobStart <Int64?>]`: 
    - `[SupportedDocumentMimeTypes <String[]>]`: 
    - `[SupportedDuplexConfigurations <String[]>]`: 
    - `[SupportedFinishings <String[]>]`: 
    - `[SupportedMediaColors <String[]>]`: 
    - `[SupportedMediaSizes <String[]>]`: 
    - `[SupportedMediaTypes <String[]>]`: 
    - `[SupportedOrientations <String[]>]`: 
    - `[SupportedOutputBins <String[]>]`: 
    - `[SupportedPagePerSheetEnd <Int64?>]`: 
    - `[SupportedPagePerSheetMaximum <Int64?>]`: 
    - `[SupportedPagePerSheetMinimum <Int64?>]`: 
    - `[SupportedPagePerSheetStart <Int64?>]`: 
    - `[SupportedPresentationDirections <String[]>]`: 
    - `[SupportedPrintQualities <String[]>]`: 
    - `[SupportsFitPdfToPage <Boolean?>]`: 
    - `[TopMargins <Int32[]>]`: 
  - `[DefaultColorMode <String>]`: printColorMode
  - `[DefaultContentType <String>]`: 
  - `[DefaultCopiesPerJob <Int32?>]`: 
  - `[DefaultDocumentMimeType <String>]`: 
  - `[DefaultDpi <Int32?>]`: 
  - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
  - `[DefaultDuplexMode <String>]`: printDuplexMode
  - `[DefaultFinishings <String[]>]`: 
  - `[DefaultFitPdfToPage <Boolean?>]`: 
  - `[DefaultMediaColor <String>]`: 
  - `[DefaultMediaSize <String>]`: 
  - `[DefaultMediaType <String>]`: printMediaType
  - `[DefaultMultipageLayout <String>]`: printMultipageLayout
  - `[DefaultOrientation <String>]`: printOrientation
  - `[DefaultOutputBin <String>]`: 
  - `[DefaultPagesPerSheet <Int32?>]`: 
  - `[DefaultPdfFitToPage <Boolean?>]`: 
  - `[DefaultPresentationDirection <String>]`: printPresentationDirection
  - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
  - `[DefaultPrintQuality <String>]`: printQuality
  - `[DefaultQuality <String>]`: printQuality
  - `[DefaultScaling <String>]`: printScaling
  - `[IsAcceptingJobs <Boolean?>]`: 
  - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[CreatedById <String>]`: Unique identifier for the identity.
    - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DocumentConfigurationColorConfiguration <String>]`: printColorConfiguration
      - `[DocumentConfigurationCopies <Int32?>]`: 
      - `[DocumentConfigurationDuplexConfiguration <String>]`: printDuplexConfiguration
      - `[DocumentConfigurationFeedDirection <String>]`: printerFeedDirection
      - `[DocumentConfigurationOrientation <String>]`: printOrientation
      - `[DocumentConfigurationPageRanges <IMicrosoftGraphPrintPageRange[]>]`: 
        - `[EndPage <Int32?>]`: 
        - `[StartPage <Int32?>]`: 
      - `[DocumentConfigurationPrintQuality <String>]`: printQuality
      - `[DocumentConfigurationPrintResolutionInDpi <Int32?>]`: 
      - `[MimeType <String>]`: 
      - `[Name <String>]`: 
      - `[SizeInBytes <Int64?>]`: 
    - `[StatusAcquiredByPrinter <Boolean?>]`: 
    - `[StatusProcessingState <String>]`: printJobProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
  - `[LocationAltitudeInMeters <Int32?>]`: 
  - `[LocationBuilding <String>]`: 
  - `[LocationCity <String>]`: 
  - `[LocationCountryOrRegion <String>]`: 
  - `[LocationFloorDescription <String>]`: 
  - `[LocationFloorNumber <Int32?>]`: 
  - `[LocationLatitude <Single?>]`: 
  - `[LocationLongitude <Single?>]`: 
  - `[LocationOrganization <String[]>]`: 
  - `[LocationPostalCode <String>]`: 
  - `[LocationRoomDescription <String>]`: 
  - `[LocationRoomNumber <Int32?>]`: 
  - `[LocationSite <String>]`: 
  - `[LocationStateOrProvince <String>]`: 
  - `[LocationStreetAddress <String>]`: 
  - `[LocationSubdivision <String[]>]`: 
  - `[LocationSubunit <String[]>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[StatusProcessingState <String>]`: printerProcessingState
  - `[StatusProcessingStateDescription <String>]`: 
  - `[StatusProcessingStateReasons <String[]>]`: 
  - `[Id <String>]`: Read-only.
  - `[AcceptingJobs <Boolean?>]`: 
  - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IPAddress <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppVersion <String>]`: 
    - `[DeviceHealthLastConnectionTime <DateTime?>]`: 
    - `[FullyQualifiedDomainName <String>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Name <String>]`: 
    - `[OperatingSystem <String>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
  - `[IsShared <Boolean?>]`: 
  - `[RegisteredDateTime <DateTime?>]`: 
  - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[DefaultColorMode <String>]`: printColorMode
    - `[DefaultContentType <String>]`: 
    - `[DefaultCopiesPerJob <Int32?>]`: 
    - `[DefaultDocumentMimeType <String>]`: 
    - `[DefaultDpi <Int32?>]`: 
    - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DefaultDuplexMode <String>]`: printDuplexMode
    - `[DefaultFinishings <String[]>]`: 
    - `[DefaultFitPdfToPage <Boolean?>]`: 
    - `[DefaultMediaColor <String>]`: 
    - `[DefaultMediaSize <String>]`: 
    - `[DefaultMediaType <String>]`: printMediaType
    - `[DefaultMultipageLayout <String>]`: printMultipageLayout
    - `[DefaultOrientation <String>]`: printOrientation
    - `[DefaultOutputBin <String>]`: 
    - `[DefaultPagesPerSheet <Int32?>]`: 
    - `[DefaultPdfFitToPage <Boolean?>]`: 
    - `[DefaultPresentationDirection <String>]`: printPresentationDirection
    - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
    - `[DefaultPrintQuality <String>]`: printQuality
    - `[DefaultQuality <String>]`: printQuality
    - `[DefaultScaling <String>]`: printScaling
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[StatusProcessingState <String>]`: printerProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
    - `[StatusProcessingStateReasons <String[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Printer <IMicrosoftGraphPrinter>]`: printer

PRINTERSHARES <IMicrosoftGraphPrinterShare[]>: .
  - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[BottomMargins <Int32[]>]`: 
    - `[Collation <Boolean?>]`: 
    - `[ColorModes <String[]>]`: 
    - `[ContentTypes <String[]>]`: 
    - `[CopyPerJobEnd <Int64?>]`: 
    - `[CopyPerJobMaximum <Int64?>]`: 
    - `[CopyPerJobMinimum <Int64?>]`: 
    - `[CopyPerJobStart <Int64?>]`: 
    - `[Dpis <Int32[]>]`: 
    - `[DuplexModes <String[]>]`: 
    - `[FeedDirections <String[]>]`: 
    - `[Finishings <String[]>]`: 
    - `[InputBins <String[]>]`: 
    - `[IsColorPrintingSupported <Boolean?>]`: 
    - `[IsPageRangeSupported <Boolean?>]`: 
    - `[LeftMargins <Int32[]>]`: 
    - `[MediaColors <String[]>]`: 
    - `[MediaSizes <String[]>]`: 
    - `[MediaTypes <String[]>]`: 
    - `[MultipageLayouts <String[]>]`: 
    - `[Orientations <String[]>]`: 
    - `[OutputBins <String[]>]`: 
    - `[PagesPerSheet <Int32[]>]`: 
    - `[Qualities <String[]>]`: 
    - `[RightMargins <Int32[]>]`: 
    - `[Scalings <String[]>]`: 
    - `[SupportedColorConfigurations <String[]>]`: 
    - `[SupportedCopyPerJobEnd <Int64?>]`: 
    - `[SupportedCopyPerJobMaximum <Int64?>]`: 
    - `[SupportedCopyPerJobMinimum <Int64?>]`: 
    - `[SupportedCopyPerJobStart <Int64?>]`: 
    - `[SupportedDocumentMimeTypes <String[]>]`: 
    - `[SupportedDuplexConfigurations <String[]>]`: 
    - `[SupportedFinishings <String[]>]`: 
    - `[SupportedMediaColors <String[]>]`: 
    - `[SupportedMediaSizes <String[]>]`: 
    - `[SupportedMediaTypes <String[]>]`: 
    - `[SupportedOrientations <String[]>]`: 
    - `[SupportedOutputBins <String[]>]`: 
    - `[SupportedPagePerSheetEnd <Int64?>]`: 
    - `[SupportedPagePerSheetMaximum <Int64?>]`: 
    - `[SupportedPagePerSheetMinimum <Int64?>]`: 
    - `[SupportedPagePerSheetStart <Int64?>]`: 
    - `[SupportedPresentationDirections <String[]>]`: 
    - `[SupportedPrintQualities <String[]>]`: 
    - `[SupportsFitPdfToPage <Boolean?>]`: 
    - `[TopMargins <Int32[]>]`: 
  - `[DefaultColorMode <String>]`: printColorMode
  - `[DefaultContentType <String>]`: 
  - `[DefaultCopiesPerJob <Int32?>]`: 
  - `[DefaultDocumentMimeType <String>]`: 
  - `[DefaultDpi <Int32?>]`: 
  - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
  - `[DefaultDuplexMode <String>]`: printDuplexMode
  - `[DefaultFinishings <String[]>]`: 
  - `[DefaultFitPdfToPage <Boolean?>]`: 
  - `[DefaultMediaColor <String>]`: 
  - `[DefaultMediaSize <String>]`: 
  - `[DefaultMediaType <String>]`: printMediaType
  - `[DefaultMultipageLayout <String>]`: printMultipageLayout
  - `[DefaultOrientation <String>]`: printOrientation
  - `[DefaultOutputBin <String>]`: 
  - `[DefaultPagesPerSheet <Int32?>]`: 
  - `[DefaultPdfFitToPage <Boolean?>]`: 
  - `[DefaultPresentationDirection <String>]`: printPresentationDirection
  - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
  - `[DefaultPrintQuality <String>]`: printQuality
  - `[DefaultQuality <String>]`: printQuality
  - `[DefaultScaling <String>]`: printScaling
  - `[IsAcceptingJobs <Boolean?>]`: 
  - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[CreatedById <String>]`: Unique identifier for the identity.
    - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DocumentConfigurationColorConfiguration <String>]`: printColorConfiguration
      - `[DocumentConfigurationCopies <Int32?>]`: 
      - `[DocumentConfigurationDuplexConfiguration <String>]`: printDuplexConfiguration
      - `[DocumentConfigurationFeedDirection <String>]`: printerFeedDirection
      - `[DocumentConfigurationOrientation <String>]`: printOrientation
      - `[DocumentConfigurationPageRanges <IMicrosoftGraphPrintPageRange[]>]`: 
        - `[EndPage <Int32?>]`: 
        - `[StartPage <Int32?>]`: 
      - `[DocumentConfigurationPrintQuality <String>]`: printQuality
      - `[DocumentConfigurationPrintResolutionInDpi <Int32?>]`: 
      - `[MimeType <String>]`: 
      - `[Name <String>]`: 
      - `[SizeInBytes <Int64?>]`: 
    - `[StatusAcquiredByPrinter <Boolean?>]`: 
    - `[StatusProcessingState <String>]`: printJobProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
  - `[LocationAltitudeInMeters <Int32?>]`: 
  - `[LocationBuilding <String>]`: 
  - `[LocationCity <String>]`: 
  - `[LocationCountryOrRegion <String>]`: 
  - `[LocationFloorDescription <String>]`: 
  - `[LocationFloorNumber <Int32?>]`: 
  - `[LocationLatitude <Single?>]`: 
  - `[LocationLongitude <Single?>]`: 
  - `[LocationOrganization <String[]>]`: 
  - `[LocationPostalCode <String>]`: 
  - `[LocationRoomDescription <String>]`: 
  - `[LocationRoomNumber <Int32?>]`: 
  - `[LocationSite <String>]`: 
  - `[LocationStateOrProvince <String>]`: 
  - `[LocationStreetAddress <String>]`: 
  - `[LocationSubdivision <String[]>]`: 
  - `[LocationSubunit <String[]>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[StatusProcessingState <String>]`: printerProcessingState
  - `[StatusProcessingStateDescription <String>]`: 
  - `[StatusProcessingStateReasons <String[]>]`: 
  - `[Id <String>]`: Read-only.
  - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IPAddress <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Printer <IMicrosoftGraphPrinter>]`: printer
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[DefaultColorMode <String>]`: printColorMode
    - `[DefaultContentType <String>]`: 
    - `[DefaultCopiesPerJob <Int32?>]`: 
    - `[DefaultDocumentMimeType <String>]`: 
    - `[DefaultDpi <Int32?>]`: 
    - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DefaultDuplexMode <String>]`: printDuplexMode
    - `[DefaultFinishings <String[]>]`: 
    - `[DefaultFitPdfToPage <Boolean?>]`: 
    - `[DefaultMediaColor <String>]`: 
    - `[DefaultMediaSize <String>]`: 
    - `[DefaultMediaType <String>]`: printMediaType
    - `[DefaultMultipageLayout <String>]`: printMultipageLayout
    - `[DefaultOrientation <String>]`: printOrientation
    - `[DefaultOutputBin <String>]`: 
    - `[DefaultPagesPerSheet <Int32?>]`: 
    - `[DefaultPdfFitToPage <Boolean?>]`: 
    - `[DefaultPresentationDirection <String>]`: printPresentationDirection
    - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
    - `[DefaultPrintQuality <String>]`: printQuality
    - `[DefaultQuality <String>]`: printQuality
    - `[DefaultScaling <String>]`: printScaling
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[StatusProcessingState <String>]`: printerProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
    - `[StatusProcessingStateReasons <String[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AcceptingJobs <Boolean?>]`: 
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppVersion <String>]`: 
      - `[DeviceHealthLastConnectionTime <DateTime?>]`: 
      - `[FullyQualifiedDomainName <String>]`: 
      - `[LocationAltitudeInMeters <Int32?>]`: 
      - `[LocationBuilding <String>]`: 
      - `[LocationCity <String>]`: 
      - `[LocationCountryOrRegion <String>]`: 
      - `[LocationFloorDescription <String>]`: 
      - `[LocationFloorNumber <Int32?>]`: 
      - `[LocationLatitude <Single?>]`: 
      - `[LocationLongitude <Single?>]`: 
      - `[LocationOrganization <String[]>]`: 
      - `[LocationPostalCode <String>]`: 
      - `[LocationRoomDescription <String>]`: 
      - `[LocationRoomNumber <Int32?>]`: 
      - `[LocationSite <String>]`: 
      - `[LocationStateOrProvince <String>]`: 
      - `[LocationStreetAddress <String>]`: 
      - `[LocationSubdivision <String[]>]`: 
      - `[LocationSubunit <String[]>]`: 
      - `[Name <String>]`: 
      - `[OperatingSystem <String>]`: 
      - `[RegisteredDateTime <DateTime?>]`: 
    - `[IsShared <Boolean?>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
    - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare

REPORTS <IMicrosoftGraphReportRoot[]>: .
  - `[Id <String>]`: Read-only.
  - `[ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AggregatedEventDateTime <DateTime?>]`: 
    - `[AppDisplayName <String>]`: 
    - `[AppId <String>]`: 
    - `[SignInCount <Int64?>]`: 
    - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
    - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
    - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
  - `[CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AuthMethods <String[]>]`: 
    - `[IsCapable <Boolean?>]`: 
    - `[IsEnabled <Boolean?>]`: 
    - `[IsMfaRegistered <Boolean?>]`: 
    - `[IsRegistered <Boolean?>]`: 
    - `[UserDisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[DailyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
    - `[CompletedColorJobCount <Int64?>]`: 
    - `[IncompleteJobCount <Int64?>]`: 
    - `[PrinterId <String>]`: 
    - `[UsageDate <DateTime?>]`: 
  - `[DailyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
    - `[CompletedColorJobCount <Int64?>]`: 
    - `[IncompleteJobCount <Int64?>]`: 
    - `[UsageDate <DateTime?>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[MonthlyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]`: 
  - `[MonthlyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>]`: 
  - `[UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AuthMethod <String>]`: usageAuthMethod
    - `[EventDateTime <DateTime?>]`: 
    - `[FailureReason <String>]`: 
    - `[Feature <String>]`: featureType
    - `[IsSuccess <Boolean?>]`: 
    - `[UserDisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 

SERVICES <IMicrosoftGraphPrintService[]>: .
  - `[Id <String>]`: Read-only.
  - `[Endpoints <IMicrosoftGraphPrintServiceEndpoint[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Uri <String>]`: 

SHARES <IMicrosoftGraphPrinterShare[]>: .
  - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[BottomMargins <Int32[]>]`: 
    - `[Collation <Boolean?>]`: 
    - `[ColorModes <String[]>]`: 
    - `[ContentTypes <String[]>]`: 
    - `[CopyPerJobEnd <Int64?>]`: 
    - `[CopyPerJobMaximum <Int64?>]`: 
    - `[CopyPerJobMinimum <Int64?>]`: 
    - `[CopyPerJobStart <Int64?>]`: 
    - `[Dpis <Int32[]>]`: 
    - `[DuplexModes <String[]>]`: 
    - `[FeedDirections <String[]>]`: 
    - `[Finishings <String[]>]`: 
    - `[InputBins <String[]>]`: 
    - `[IsColorPrintingSupported <Boolean?>]`: 
    - `[IsPageRangeSupported <Boolean?>]`: 
    - `[LeftMargins <Int32[]>]`: 
    - `[MediaColors <String[]>]`: 
    - `[MediaSizes <String[]>]`: 
    - `[MediaTypes <String[]>]`: 
    - `[MultipageLayouts <String[]>]`: 
    - `[Orientations <String[]>]`: 
    - `[OutputBins <String[]>]`: 
    - `[PagesPerSheet <Int32[]>]`: 
    - `[Qualities <String[]>]`: 
    - `[RightMargins <Int32[]>]`: 
    - `[Scalings <String[]>]`: 
    - `[SupportedColorConfigurations <String[]>]`: 
    - `[SupportedCopyPerJobEnd <Int64?>]`: 
    - `[SupportedCopyPerJobMaximum <Int64?>]`: 
    - `[SupportedCopyPerJobMinimum <Int64?>]`: 
    - `[SupportedCopyPerJobStart <Int64?>]`: 
    - `[SupportedDocumentMimeTypes <String[]>]`: 
    - `[SupportedDuplexConfigurations <String[]>]`: 
    - `[SupportedFinishings <String[]>]`: 
    - `[SupportedMediaColors <String[]>]`: 
    - `[SupportedMediaSizes <String[]>]`: 
    - `[SupportedMediaTypes <String[]>]`: 
    - `[SupportedOrientations <String[]>]`: 
    - `[SupportedOutputBins <String[]>]`: 
    - `[SupportedPagePerSheetEnd <Int64?>]`: 
    - `[SupportedPagePerSheetMaximum <Int64?>]`: 
    - `[SupportedPagePerSheetMinimum <Int64?>]`: 
    - `[SupportedPagePerSheetStart <Int64?>]`: 
    - `[SupportedPresentationDirections <String[]>]`: 
    - `[SupportedPrintQualities <String[]>]`: 
    - `[SupportsFitPdfToPage <Boolean?>]`: 
    - `[TopMargins <Int32[]>]`: 
  - `[DefaultColorMode <String>]`: printColorMode
  - `[DefaultContentType <String>]`: 
  - `[DefaultCopiesPerJob <Int32?>]`: 
  - `[DefaultDocumentMimeType <String>]`: 
  - `[DefaultDpi <Int32?>]`: 
  - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
  - `[DefaultDuplexMode <String>]`: printDuplexMode
  - `[DefaultFinishings <String[]>]`: 
  - `[DefaultFitPdfToPage <Boolean?>]`: 
  - `[DefaultMediaColor <String>]`: 
  - `[DefaultMediaSize <String>]`: 
  - `[DefaultMediaType <String>]`: printMediaType
  - `[DefaultMultipageLayout <String>]`: printMultipageLayout
  - `[DefaultOrientation <String>]`: printOrientation
  - `[DefaultOutputBin <String>]`: 
  - `[DefaultPagesPerSheet <Int32?>]`: 
  - `[DefaultPdfFitToPage <Boolean?>]`: 
  - `[DefaultPresentationDirection <String>]`: printPresentationDirection
  - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
  - `[DefaultPrintQuality <String>]`: printQuality
  - `[DefaultQuality <String>]`: printQuality
  - `[DefaultScaling <String>]`: printScaling
  - `[IsAcceptingJobs <Boolean?>]`: 
  - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedByDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[CreatedByIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[CreatedById <String>]`: Unique identifier for the identity.
    - `[CreatedByUserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[DocumentConfigurationColorConfiguration <String>]`: printColorConfiguration
      - `[DocumentConfigurationCopies <Int32?>]`: 
      - `[DocumentConfigurationDuplexConfiguration <String>]`: printDuplexConfiguration
      - `[DocumentConfigurationFeedDirection <String>]`: printerFeedDirection
      - `[DocumentConfigurationOrientation <String>]`: printOrientation
      - `[DocumentConfigurationPageRanges <IMicrosoftGraphPrintPageRange[]>]`: 
        - `[EndPage <Int32?>]`: 
        - `[StartPage <Int32?>]`: 
      - `[DocumentConfigurationPrintQuality <String>]`: printQuality
      - `[DocumentConfigurationPrintResolutionInDpi <Int32?>]`: 
      - `[MimeType <String>]`: 
      - `[Name <String>]`: 
      - `[SizeInBytes <Int64?>]`: 
    - `[StatusAcquiredByPrinter <Boolean?>]`: 
    - `[StatusProcessingState <String>]`: printJobProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
  - `[LocationAltitudeInMeters <Int32?>]`: 
  - `[LocationBuilding <String>]`: 
  - `[LocationCity <String>]`: 
  - `[LocationCountryOrRegion <String>]`: 
  - `[LocationFloorDescription <String>]`: 
  - `[LocationFloorNumber <Int32?>]`: 
  - `[LocationLatitude <Single?>]`: 
  - `[LocationLongitude <Single?>]`: 
  - `[LocationOrganization <String[]>]`: 
  - `[LocationPostalCode <String>]`: 
  - `[LocationRoomDescription <String>]`: 
  - `[LocationRoomNumber <Int32?>]`: 
  - `[LocationSite <String>]`: 
  - `[LocationStateOrProvince <String>]`: 
  - `[LocationStreetAddress <String>]`: 
  - `[LocationSubdivision <String[]>]`: 
  - `[LocationSubunit <String[]>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[StatusProcessingState <String>]`: printerProcessingState
  - `[StatusProcessingStateDescription <String>]`: 
  - `[StatusProcessingStateReasons <String[]>]`: 
  - `[Id <String>]`: Read-only.
  - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IPAddress <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Printer <IMicrosoftGraphPrinter>]`: printer
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[DefaultColorMode <String>]`: printColorMode
    - `[DefaultContentType <String>]`: 
    - `[DefaultCopiesPerJob <Int32?>]`: 
    - `[DefaultDocumentMimeType <String>]`: 
    - `[DefaultDpi <Int32?>]`: 
    - `[DefaultDuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DefaultDuplexMode <String>]`: printDuplexMode
    - `[DefaultFinishings <String[]>]`: 
    - `[DefaultFitPdfToPage <Boolean?>]`: 
    - `[DefaultMediaColor <String>]`: 
    - `[DefaultMediaSize <String>]`: 
    - `[DefaultMediaType <String>]`: printMediaType
    - `[DefaultMultipageLayout <String>]`: printMultipageLayout
    - `[DefaultOrientation <String>]`: printOrientation
    - `[DefaultOutputBin <String>]`: 
    - `[DefaultPagesPerSheet <Int32?>]`: 
    - `[DefaultPdfFitToPage <Boolean?>]`: 
    - `[DefaultPresentationDirection <String>]`: printPresentationDirection
    - `[DefaultPrintColorConfiguration <String>]`: printColorConfiguration
    - `[DefaultPrintQuality <String>]`: printQuality
    - `[DefaultQuality <String>]`: printQuality
    - `[DefaultScaling <String>]`: printScaling
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[LocationAltitudeInMeters <Int32?>]`: 
    - `[LocationBuilding <String>]`: 
    - `[LocationCity <String>]`: 
    - `[LocationCountryOrRegion <String>]`: 
    - `[LocationFloorDescription <String>]`: 
    - `[LocationFloorNumber <Int32?>]`: 
    - `[LocationLatitude <Single?>]`: 
    - `[LocationLongitude <Single?>]`: 
    - `[LocationOrganization <String[]>]`: 
    - `[LocationPostalCode <String>]`: 
    - `[LocationRoomDescription <String>]`: 
    - `[LocationRoomNumber <Int32?>]`: 
    - `[LocationSite <String>]`: 
    - `[LocationStateOrProvince <String>]`: 
    - `[LocationStreetAddress <String>]`: 
    - `[LocationSubdivision <String[]>]`: 
    - `[LocationSubunit <String[]>]`: 
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[StatusProcessingState <String>]`: printerProcessingState
    - `[StatusProcessingStateDescription <String>]`: 
    - `[StatusProcessingStateReasons <String[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AcceptingJobs <Boolean?>]`: 
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppVersion <String>]`: 
      - `[DeviceHealthLastConnectionTime <DateTime?>]`: 
      - `[FullyQualifiedDomainName <String>]`: 
      - `[LocationAltitudeInMeters <Int32?>]`: 
      - `[LocationBuilding <String>]`: 
      - `[LocationCity <String>]`: 
      - `[LocationCountryOrRegion <String>]`: 
      - `[LocationFloorDescription <String>]`: 
      - `[LocationFloorNumber <Int32?>]`: 
      - `[LocationLatitude <Single?>]`: 
      - `[LocationLongitude <Single?>]`: 
      - `[LocationOrganization <String[]>]`: 
      - `[LocationPostalCode <String>]`: 
      - `[LocationRoomDescription <String>]`: 
      - `[LocationRoomNumber <Int32?>]`: 
      - `[LocationSite <String>]`: 
      - `[LocationStateOrProvince <String>]`: 
      - `[LocationStreetAddress <String>]`: 
      - `[LocationSubdivision <String[]>]`: 
      - `[LocationSubunit <String[]>]`: 
      - `[Name <String>]`: 
      - `[OperatingSystem <String>]`: 
      - `[RegisteredDateTime <DateTime?>]`: 
    - `[IsShared <Boolean?>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
    - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare

## RELATED LINKS

