---
external help file:
Module Name: Microsoft.Graph.Users.Contacts
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.contacts/update-mgusercontactfolderchildfolder
schema: 2.0.0
---

# Update-MgUserContactFolderChildFolder

## SYNOPSIS
Update the navigation property childFolders in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserContactFolderChildFolder -ContactFolderId <String> -ContactFolderId1 <String> -UserId <String>
 [-ChildFolders <IMicrosoftGraphContactFolder1[]>] [-Contacts <IMicrosoftGraphContact1[]>]
 [-DisplayName <String>] [-Id <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserContactFolderChildFolder -ContactFolderId <String> -ContactFolderId1 <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphContactFolder1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserContactFolderChildFolder -InputObject <IUsersContactsIdentity>
 -BodyParameter <IMicrosoftGraphContactFolder1> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserContactFolderChildFolder -InputObject <IUsersContactsIdentity>
 [-ChildFolders <IMicrosoftGraphContactFolder1[]>] [-Contacts <IMicrosoftGraphContact1[]>]
 [-DisplayName <String>] [-Id <String>]
 [-MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]
 [-ParentFolderId <String>]
 [-SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property childFolders in users

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
contactFolder
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChildFolders
The collection of child folders in the folder.
Navigation property.
Read-only.
Nullable.
To construct, see NOTES section for CHILDFOLDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContactFolderId
key: contactFolder-id of contactFolder

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

### -ContactFolderId1
key: contactFolder-id of contactFolder

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

### -Contacts
The contacts in the folder.
Navigation property.
Read-only.
Nullable.
To construct, see NOTES section for CONTACTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContact1[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The folder's display name.

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
Type: Microsoft.Graph.PowerShell.Models.IUsersContactsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MultiValueExtendedProperties
The collection of multi-value extended properties defined for the contactFolder.
Read-only.
Nullable.
To construct, see NOTES section for MULTIVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMultiValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentFolderId
The ID of the folder's parent folder.

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

### -SingleValueExtendedProperties
The collection of single-value extended properties defined for the contactFolder.
Read-only.
Nullable.
To construct, see NOTES section for SINGLEVALUEEXTENDEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSingleValueLegacyExtendedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContactFolder1

### Microsoft.Graph.PowerShell.Models.IUsersContactsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphContactFolder1>: contactFolder
  - `[Id <String>]`: Read-only.
  - `[ChildFolders <IMicrosoftGraphContactFolder1[]>]`: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Contacts <IMicrosoftGraphContact1[]>]`: The contacts in the folder. Navigation property. Read-only. Nullable.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[AssistantName <String>]`: The name of the contact's assistant.
    - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[BusinessAddressCity <String>]`: The city.
    - `[BusinessAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[BusinessAddressPostalCode <String>]`: The postal code.
    - `[BusinessAddressState <String>]`: The state.
    - `[BusinessAddressStreet <String>]`: The street.
    - `[BusinessHomePage <String>]`: The business home page of the contact.
    - `[BusinessPhones <String[]>]`: The contact's business phone numbers.
    - `[Children <String[]>]`: The names of the contact's children.
    - `[CompanyName <String>]`: The name of the contact's company.
    - `[Department <String>]`: The contact's department.
    - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
    - `[EmailAddresses <IMicrosoftGraphEmailAddress[]>]`: The contact's email addresses.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[FileAs <String>]`: The name the contact is filed under.
    - `[Generation <String>]`: The contact's generation.
    - `[GivenName <String>]`: The contact's given name.
    - `[HomeAddressCity <String>]`: The city.
    - `[HomeAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[HomeAddressPostalCode <String>]`: The postal code.
    - `[HomeAddressState <String>]`: The state.
    - `[HomeAddressStreet <String>]`: The street.
    - `[HomePhones <String[]>]`: The contact's home phone numbers.
    - `[ImAddresses <String[]>]`: The contact's instant messaging (IM) addresses.
    - `[Initials <String>]`: The contact's initials.
    - `[JobTitle <String>]`: The contact’s job title.
    - `[Manager <String>]`: The name of the contact's manager.
    - `[MiddleName <String>]`: The contact's middle name.
    - `[MobilePhone <String>]`: The contact's mobile phone number.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NickName <String>]`: The contact's nickname.
    - `[OfficeLocation <String>]`: The location of the contact's office.
    - `[OtherAddressCity <String>]`: The city.
    - `[OtherAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OtherAddressPostalCode <String>]`: The postal code.
    - `[OtherAddressState <String>]`: The state.
    - `[OtherAddressStreet <String>]`: The street.
    - `[ParentFolderId <String>]`: The ID of the contact's parent folder.
    - `[PersonalNotes <String>]`: The user's notes about the contact.
    - `[PhotoHeight <Int32?>]`: The height of the photo. Read-only.
    - `[PhotoId <String>]`: Read-only.
    - `[PhotoWidth <Int32?>]`: The width of the photo. Read-only.
    - `[Profession <String>]`: The contact's profession.
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
    - `[SpouseName <String>]`: The name of the contact's spouse/partner.
    - `[Surname <String>]`: The contact's surname.
    - `[Title <String>]`: The contact's title.
    - `[YomiCompanyName <String>]`: The phonetic Japanese company name of the contact.
    - `[YomiGivenName <String>]`: The phonetic Japanese given name (first name) of the contact.
    - `[YomiSurname <String>]`: The phonetic Japanese surname (last name)  of the contact.
  - `[DisplayName <String>]`: The folder's display name.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[ParentFolderId <String>]`: The ID of the folder's parent folder.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.

CHILDFOLDERS <IMicrosoftGraphContactFolder1[]>: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ChildFolders <IMicrosoftGraphContactFolder1[]>]`: The collection of child folders in the folder. Navigation property. Read-only. Nullable.
  - `[Contacts <IMicrosoftGraphContact1[]>]`: The contacts in the folder. Navigation property. Read-only. Nullable.
    - `[Categories <String[]>]`: The categories associated with the item
    - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[Id <String>]`: Read-only.
    - `[AssistantName <String>]`: The name of the contact's assistant.
    - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[BusinessAddressCity <String>]`: The city.
    - `[BusinessAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[BusinessAddressPostalCode <String>]`: The postal code.
    - `[BusinessAddressState <String>]`: The state.
    - `[BusinessAddressStreet <String>]`: The street.
    - `[BusinessHomePage <String>]`: The business home page of the contact.
    - `[BusinessPhones <String[]>]`: The contact's business phone numbers.
    - `[Children <String[]>]`: The names of the contact's children.
    - `[CompanyName <String>]`: The name of the contact's company.
    - `[Department <String>]`: The contact's department.
    - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
    - `[EmailAddresses <IMicrosoftGraphEmailAddress[]>]`: The contact's email addresses.
      - `[Address <String>]`: The email address of the person or entity.
      - `[Name <String>]`: The display name of the person or entity.
    - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
    - `[FileAs <String>]`: The name the contact is filed under.
    - `[Generation <String>]`: The contact's generation.
    - `[GivenName <String>]`: The contact's given name.
    - `[HomeAddressCity <String>]`: The city.
    - `[HomeAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[HomeAddressPostalCode <String>]`: The postal code.
    - `[HomeAddressState <String>]`: The state.
    - `[HomeAddressStreet <String>]`: The street.
    - `[HomePhones <String[]>]`: The contact's home phone numbers.
    - `[ImAddresses <String[]>]`: The contact's instant messaging (IM) addresses.
    - `[Initials <String>]`: The contact's initials.
    - `[JobTitle <String>]`: The contact’s job title.
    - `[Manager <String>]`: The name of the contact's manager.
    - `[MiddleName <String>]`: The contact's middle name.
    - `[MobilePhone <String>]`: The contact's mobile phone number.
    - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String[]>]`: A collection of property values.
    - `[NickName <String>]`: The contact's nickname.
    - `[OfficeLocation <String>]`: The location of the contact's office.
    - `[OtherAddressCity <String>]`: The city.
    - `[OtherAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[OtherAddressPostalCode <String>]`: The postal code.
    - `[OtherAddressState <String>]`: The state.
    - `[OtherAddressStreet <String>]`: The street.
    - `[ParentFolderId <String>]`: The ID of the contact's parent folder.
    - `[PersonalNotes <String>]`: The user's notes about the contact.
    - `[PhotoHeight <Int32?>]`: The height of the photo. Read-only.
    - `[PhotoId <String>]`: Read-only.
    - `[PhotoWidth <Int32?>]`: The width of the photo. Read-only.
    - `[Profession <String>]`: The contact's profession.
    - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[Value <String>]`: A property value.
    - `[SpouseName <String>]`: The name of the contact's spouse/partner.
    - `[Surname <String>]`: The contact's surname.
    - `[Title <String>]`: The contact's title.
    - `[YomiCompanyName <String>]`: The phonetic Japanese company name of the contact.
    - `[YomiGivenName <String>]`: The phonetic Japanese given name (first name) of the contact.
    - `[YomiSurname <String>]`: The phonetic Japanese surname (last name)  of the contact.
  - `[DisplayName <String>]`: The folder's display name.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[ParentFolderId <String>]`: The ID of the folder's parent folder.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.

CONTACTS <IMicrosoftGraphContact1[]>: The contacts in the folder. Navigation property. Read-only. Nullable.
  - `[Categories <String[]>]`: The categories associated with the item
  - `[ChangeKey <String>]`: Identifies the version of the item. Every time the item is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Id <String>]`: Read-only.
  - `[AssistantName <String>]`: The name of the contact's assistant.
  - `[Birthday <DateTime?>]`: The contact's birthday. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[BusinessAddressCity <String>]`: The city.
  - `[BusinessAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[BusinessAddressPostalCode <String>]`: The postal code.
  - `[BusinessAddressState <String>]`: The state.
  - `[BusinessAddressStreet <String>]`: The street.
  - `[BusinessHomePage <String>]`: The business home page of the contact.
  - `[BusinessPhones <String[]>]`: The contact's business phone numbers.
  - `[Children <String[]>]`: The names of the contact's children.
  - `[CompanyName <String>]`: The name of the contact's company.
  - `[Department <String>]`: The contact's department.
  - `[DisplayName <String>]`: The contact's display name. You can specify the display name in a create or update operation. Note that later updates to other properties may cause an automatically generated value to overwrite the displayName value you have specified. To preserve a pre-existing value, always include it as displayName in an update operation.
  - `[EmailAddresses <IMicrosoftGraphEmailAddress[]>]`: The contact's email addresses.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[Extensions <IMicrosoftGraphExtension[]>]`: The collection of open extensions defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
  - `[FileAs <String>]`: The name the contact is filed under.
  - `[Generation <String>]`: The contact's generation.
  - `[GivenName <String>]`: The contact's given name.
  - `[HomeAddressCity <String>]`: The city.
  - `[HomeAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[HomeAddressPostalCode <String>]`: The postal code.
  - `[HomeAddressState <String>]`: The state.
  - `[HomeAddressStreet <String>]`: The street.
  - `[HomePhones <String[]>]`: The contact's home phone numbers.
  - `[ImAddresses <String[]>]`: The contact's instant messaging (IM) addresses.
  - `[Initials <String>]`: The contact's initials.
  - `[JobTitle <String>]`: The contact’s job title.
  - `[Manager <String>]`: The name of the contact's manager.
  - `[MiddleName <String>]`: The contact's middle name.
  - `[MobilePhone <String>]`: The contact's mobile phone number.
  - `[MultiValueExtendedProperties <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>]`: The collection of multi-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String[]>]`: A collection of property values.
  - `[NickName <String>]`: The contact's nickname.
  - `[OfficeLocation <String>]`: The location of the contact's office.
  - `[OtherAddressCity <String>]`: The city.
  - `[OtherAddressCountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
  - `[OtherAddressPostalCode <String>]`: The postal code.
  - `[OtherAddressState <String>]`: The state.
  - `[OtherAddressStreet <String>]`: The street.
  - `[ParentFolderId <String>]`: The ID of the contact's parent folder.
  - `[PersonalNotes <String>]`: The user's notes about the contact.
  - `[PhotoHeight <Int32?>]`: The height of the photo. Read-only.
  - `[PhotoId <String>]`: Read-only.
  - `[PhotoWidth <Int32?>]`: The width of the photo. Read-only.
  - `[Profession <String>]`: The contact's profession.
  - `[SingleValueExtendedProperties <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>]`: The collection of single-value extended properties defined for the contact. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Value <String>]`: A property value.
  - `[SpouseName <String>]`: The name of the contact's spouse/partner.
  - `[Surname <String>]`: The contact's surname.
  - `[Title <String>]`: The contact's title.
  - `[YomiCompanyName <String>]`: The phonetic Japanese company name of the contact.
  - `[YomiGivenName <String>]`: The phonetic Japanese given name (first name) of the contact.
  - `[YomiSurname <String>]`: The phonetic Japanese surname (last name)  of the contact.

INPUTOBJECT <IUsersContactsIdentity>: Identity Parameter
  - `[ContactFolderId <String>]`: key: contactFolder-id of contactFolder
  - `[ContactFolderId1 <String>]`: key: contactFolder-id of contactFolder
  - `[ContactId <String>]`: key: contact-id of contact
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

MULTIVALUEEXTENDEDPROPERTIES <IMicrosoftGraphMultiValueLegacyExtendedProperty[]>: The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String[]>]`: A collection of property values.

SINGLEVALUEEXTENDEDPROPERTIES <IMicrosoftGraphSingleValueLegacyExtendedProperty[]>: The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Value <String>]`: A property value.

## RELATED LINKS

