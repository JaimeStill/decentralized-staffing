param(
    [string]
    [Parameter()]
    $Source = "$env:userprofile\packages\",
    [string]
    [Parameter()]
    $SourceName = "SOC Packages"
)

$Lib = ".\src\lib"
$Location = (Get-Location).Path

if (!(Test-Path $Source)) {
    New-Item $Source -ItemType Directory
}

if (!(& dotnet nuget list source | ? { $_ -like "*$SourceName*" })) {
    & dotnet nuget add source $Source -n $SourceName
}

Set-Location $Lib

& dotnet pack Soc.Api -o $Source
& dotnet pack Soc.Contracts -o $Source
& dotnet pack Soc.Enterprise -o $Source
& dotnet pack Soc.Staffing -o $Source

Set-Location $Location