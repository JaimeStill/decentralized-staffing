param(
    [string]
    [Parameter()]
    $Lib = ".\src\lib\",
    [string]
    [Parameter()]
    $Source = "$env:userprofile\packages\",
    [string]
    [Parameter()]
    $SourceName = "SOC Packages"
)

if (!(Test-Path $Source)) {
    New-Item $Source -ItemType Directory
}

if (!(& dotnet nuget list source | ? { $_ -like "*$SourceName*" })) {
    & dotnet nuget add source $Source -n $SourceName
}

Get-ChildItem $Lib -Directory | ForEach-Object {
    if ($_.GetFiles('*.csproj')) {
        & dotnet pack $_ -o $Source
    }
}