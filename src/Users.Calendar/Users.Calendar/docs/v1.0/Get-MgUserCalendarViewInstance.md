---
external help file:
Module Name: Microsoft.Graph.Users.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.calendar/get-mgusercalendarviewinstance
schema: 2.0.0
---

# Get-MgUserCalendarViewInstance

## SYNOPSIS
Get instances from users

## SYNTAX

### List3 (Default)
```
Get-MgUserCalendarViewInstance -EventId <String> -UserId <String> [-Count] [-ExpandProperty <String[]>]
 [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [<CommonParameters>]
```

### Get3
```
Get-MgUserCalendarViewInstance -EventId <String> -EventId1 <String> -UserId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get4
```
Get-MgUserCalendarViewInstance -CalendarId <String> -EventId <String> -EventId1 <String> -UserId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get5
```
Get-MgUserCalendarViewInstance -EventId <String> -EventId1 <String> -UserId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity3
```
Get-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity4
```
Get-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity5
```
Get-MgUserCalendarViewInstance -InputObject <IUsersCalendarIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### List4
```
Get-MgUserCalendarViewInstance -CalendarId <String> -EventId <String> -UserId <String> [-Count]
 [-ExpandProperty <String[]>] [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>] [-Search <String>]
 [-Skip <Int32>] [-Sort <String[]>] [<CommonParameters>]
```

### List5
```
Get-MgUserCalendarViewInstance -EventId <String> -UserId <String> [-Count] [-ExpandProperty <String[]>]
 [-Filter <String>] [-PageSize <Int32>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get instances from users

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

### -CalendarId
key: calendar-id of calendar

```yaml
Type: System.String
Parameter Sets: Get4, List4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List3, List4, List5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Get3, Get4, Get5, List3, List4, List5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId1
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Get3, Get4, Get5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List3, List4, List5
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
Type: Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity
Parameter Sets: GetViaIdentity3, GetViaIdentity4, GetViaIdentity5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List3, List4, List5
Aliases: Top, Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List3, List4, List5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List3, List4, List5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List3, List4, List5
Aliases: OrderBy

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
Parameter Sets: Get3, Get4, Get5, List3, List4, List5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEvent1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IUsersCalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[CalendarPermissionId <String>]`: key: calendarPermission-id of calendarPermission
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

