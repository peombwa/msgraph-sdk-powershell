$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgMuteCommunicationCallParticipant.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-MgMuteCommunicationCallParticipant' {
    It 'MuteExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Mute2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MuteViaIdentityExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MuteViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
