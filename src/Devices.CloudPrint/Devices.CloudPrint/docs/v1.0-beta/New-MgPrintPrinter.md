---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintprinter
schema: 2.0.0
---

# New-MgPrintPrinter

## SYNOPSIS
Create new navigation property to printers for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintPrinter [-AcceptingJobs] [-AllowedGroups <IMicrosoftGraphPrintIdentity[]>]
 [-AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>] [-Capabilities <IMicrosoftGraphPrinterCapabilities>]
 [-Connectors <IMicrosoftGraphPrintConnector[]>] [-DefaultColorMode <String>] [-DefaultContentType <String>]
 [-DefaultCopiesPerJob <Int32>] [-DefaultDocumentMimeType <String>] [-DefaultDpi <Int32>]
 [-DefaultDuplexConfiguration <String>] [-DefaultDuplexMode <String>] [-DefaultFinishings <String[]>]
 [-DefaultFitPdfToPage] [-DefaultMediaColor <String>] [-DefaultMediaSize <String>]
 [-DefaultMediaType <String>] [-DefaultMultipageLayout <String>] [-DefaultOrientation <String>]
 [-DefaultOutputBin <String>] [-DefaultPagesPerSheet <Int32>] [-DefaultPdfFitToPage]
 [-DefaultPresentationDirection <String>] [-DefaultPrintColorConfiguration <String>]
 [-DefaultPrintQuality <String>] [-DefaultQuality <String>] [-DefaultScaling <String>] [-Id <String>]
 [-IsAcceptingJobs] [-IsShared] [-Jobs <IMicrosoftGraphPrintJob[]>] [-LocationAltitudeInMeters <Int32>]
 [-LocationBuilding <String>] [-LocationCity <String>] [-LocationCountryOrRegion <String>]
 [-LocationFloorDescription <String>] [-LocationFloorNumber <Int32>] [-LocationLatitude <Single>]
 [-LocationLongitude <Single>] [-LocationOrganization <String[]>] [-LocationPostalCode <String>]
 [-LocationRoomDescription <String>] [-LocationRoomNumber <Int32>] [-LocationSite <String>]
 [-LocationStateOrProvince <String>] [-LocationStreetAddress <String>] [-LocationSubdivision <String[]>]
 [-LocationSubunit <String[]>] [-Manufacturer <String>] [-Model <String>] [-Name <String>]
 [-RegisteredDateTime <DateTime>] [-Share <IMicrosoftGraphPrinterShare>] [-StatusProcessingState <String>]
 [-StatusProcessingStateDescription <String>] [-StatusProcessingStateReasons <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgPrintPrinter -BodyParameter <IMicrosoftGraphPrinter> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to printers for print

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

### -AcceptingJobs
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedGroups
.
To construct, see NOTES section for ALLOWEDGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintIdentity[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedUsers
.
To construct, see NOTES section for ALLOWEDUSERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUserIdentity[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printer
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Capabilities
printerCapabilities
To construct, see NOTES section for CAPABILITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterCapabilities
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Connectors
.
To construct, see NOTES section for CONNECTORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintConnector[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultColorMode
printColorMode

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultContentType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultCopiesPerJob
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultDocumentMimeType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultDpi
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultDuplexConfiguration
printDuplexConfiguration

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultDuplexMode
printDuplexMode

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultFinishings
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultFitPdfToPage
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultMediaColor
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultMediaSize
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultMediaType
printMediaType

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultMultipageLayout
printMultipageLayout

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultOrientation
printOrientation

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultOutputBin
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPagesPerSheet
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPdfFitToPage
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPresentationDirection
printPresentationDirection

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPrintColorConfiguration
printColorConfiguration

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultPrintQuality
printQuality

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultQuality
printQuality

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultScaling
printScaling

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAcceptingJobs
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsShared
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Jobs
.
To construct, see NOTES section for JOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintJob[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationAltitudeInMeters
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationBuilding
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationCity
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationCountryOrRegion
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationFloorDescription
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationFloorNumber
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationLatitude
.

```yaml
Type: System.Single
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationLongitude
.

```yaml
Type: System.Single
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationOrganization
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationPostalCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationRoomDescription
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationRoomNumber
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationSite
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationStateOrProvince
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationStreetAddress
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationSubdivision
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocationSubunit
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Share
printerShare
To construct, see NOTES section for SHARE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StatusProcessingState
printerProcessingState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StatusProcessingStateDescription
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StatusProcessingStateReasons
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALLOWEDGROUPS <IMicrosoftGraphPrintIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 

ALLOWEDUSERS <IMicrosoftGraphPrintUserIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[IPAddress <String>]`: 
  - `[UserPrincipalName <String>]`: 

BODYPARAMETER <IMicrosoftGraphPrinter>: printer
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

CAPABILITIES <IMicrosoftGraphPrinterCapabilities>: printerCapabilities
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

JOBS <IMicrosoftGraphPrintJob[]>: .
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

SHARE <IMicrosoftGraphPrinterShare>: printerShare
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

