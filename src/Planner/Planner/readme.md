<!-- region Generated -->
# Microsoft.Graph.Planner
This directory contains the PowerShell module for the Planner service.

---
## Status
[![Microsoft.Graph.Planner](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Planner.svg?style=flat-square&label=Microsoft.Graph.Planner "Microsoft.Graph.Planner")](https://www.powershellgallery.com/packages/Microsoft.Graph.Planner/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Planner`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove cmdlets
  - where:
      verb: Update|New|Get
      subject: UserPlanner
      variant: Update1|UpdateExpanded1|UpdateViaIdentity1|UpdateViaIdentityExpanded1|Create|CreateExpanded|CreateViaIdentity|CreateViaIdentityExpanded|Get1|GetViaIdentity1
    remove: true
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
