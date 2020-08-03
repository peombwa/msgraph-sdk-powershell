# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $OpenApiDocOutput = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [string] $ModuleMappingConfigPath,
    [switch] $BetaGraphVersion
)

$ErrorActionPreference = 'Stop'
$LASTEXITCODE = $null
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
# Install Powershell-yaml
Install-Module powershell-yaml -Force

$GraphVersion = "v1.0"
if ($BetaGraphVersion) {
    $GraphVersion = "beta"
}

if ([string]::IsNullOrWhiteSpace($ModuleMappingConfigPath)){
    if ($BetaGraphVersion) {
        $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMappingBeta.jsonc")
    } else {
        $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMappingV1.0.jsonc")
    }
}

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion

# PS Scripts
$DownloadOpenApiDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenApiDoc.ps1" -Resolve

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$ModuleMapping.Keys | ForEach-Object -Begin { $RequestCount = 0 } -End { Write-Host -ForeGroundColor Green "Requests: $RequestCount" } -Process {
    $ModuleName = $_
    $ForceRefresh = $false
    # Check whether ForceRefresh is required, Only required for the First Request.
    if ($RequestCount -eq 0){
        $ForceRefresh = $true
    }
    $ForceRefresh = $false

    try {
        # Download OpenAPI document for module.
        & $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion -ForceRefresh:$ForceRefresh -RequestCount $RequestCount
    }
    catch {
        Write-Error $_.Exception
    }
    $RequestCount++
}


Write-Host -ForegroundColor Green "-------------Done-------------"