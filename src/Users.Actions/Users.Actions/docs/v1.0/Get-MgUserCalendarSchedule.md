---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/get-mgusercalendarschedule
schema: 2.0.0
---

# Get-MgUserCalendarSchedule

## SYNOPSIS
Invoke action getSchedule

## SYNTAX

### GetExpanded2 (Default)
```
Get-MgUserCalendarSchedule -CalendarId <String> -UserId <String> [-AvailabilityViewInterval <Int32>]
 [-EndTimeDateTime <String>] [-EndTimeZone <String>] [-Schedules <String[]>] [-StartTimeDateTime <String>]
 [-StartTimeZone <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get2
```
Get-MgUserCalendarSchedule -CalendarId <String> -UserId <String>
 -BodyParameter <IPathsQue4OrUsersUserIdCalendarsCalendarIdMicrosoftGraphGetschedulePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity2
```
Get-MgUserCalendarSchedule -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsQue4OrUsersUserIdCalendarsCalendarIdMicrosoftGraphGetschedulePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded2
```
Get-MgUserCalendarSchedule -InputObject <IUsersActionsIdentity> [-AvailabilityViewInterval <Int32>]
 [-EndTimeDateTime <String>] [-EndTimeZone <String>] [-Schedules <String[]>] [-StartTimeDateTime <String>]
 [-StartTimeZone <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action getSchedule

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

### -AvailabilityViewInterval
.

```yaml
Type: System.Int32
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsQue4OrUsersUserIdCalendarsCalendarIdMicrosoftGraphGetschedulePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get2, GetViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CalendarId
key: calendar-id of calendar

```yaml
Type: System.String
Parameter Sets: Get2, GetExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTimeDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
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
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: GetViaIdentity2, GetViaIdentityExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Schedules
.

```yaml
Type: System.String[]
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTimeDateTime
A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).

```yaml
Type: System.String
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartTimeZone
Represents a time zone, for example, 'Pacific Standard Time'.
See below for more possible values.

```yaml
Type: System.String
Parameter Sets: GetExpanded2, GetViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Get2, GetExpanded2
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

### Microsoft.Graph.PowerShell.Models.IPathsQue4OrUsersUserIdCalendarsCalendarIdMicrosoftGraphGetschedulePostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphScheduleInformation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsQue4OrUsersUserIdCalendarsCalendarIdMicrosoftGraphGetschedulePostRequestbodyContentApplicationJsonSchema>: .
  - `[AvailabilityViewInterval <Int32?>]`: 
  - `[EndTimeDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[EndTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.
  - `[Schedules <String[]>]`: 
  - `[StartTimeDateTime <String>]`: A single point of time in a combined date and time representation ({date}T{time}; for example, 2017-08-29T04:00:00.0000000).
  - `[StartTimeZone <String>]`: Represents a time zone, for example, 'Pacific Standard Time'. See below for more possible values.

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: key: appLogCollectionRequest-id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[DeviceEnrollmentConfigurationId <String>]`: key: deviceEnrollmentConfiguration-id of deviceEnrollmentConfiguration
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[MailFolderId <String>]`: key: mailFolder-id of mailFolder
  - `[MailFolderId1 <String>]`: key: mailFolder-id of mailFolder
  - `[ManagedDeviceId <String>]`: key: managedDevice-id of managedDevice
  - `[MessageId <String>]`: key: message-id of message
  - `[MobileAppTroubleshootingEventId <String>]`: key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: outlookTaskFolder-id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: outlookTaskGroup-id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: outlookTask-id of outlookTask
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[UserId <String>]`: key: user-id of user
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: windowsInformationProtectionDeviceRegistration-id of windowsInformationProtectionDeviceRegistration

## RELATED LINKS

