param(
    [string]
    [Parameter()]
    $Source = "$env:userprofile\packages\",
    [string]
    [Parameter()]
    $SourceName = "SOC Packages"
)

# clear the local cache
# this is necessary when rebuilding
# the same package version during development
& dotnet nuget locals all --clear

# 
$Lib = ".\src\lib\"
$Packages = @("Soc.Api", "Soc.Contracts", "Soc.Enterprise", "Soc.Staffing")

if (!(Test-Path $Source)) {
    New-Item $Source -ItemType Directory
} else {
    foreach($package in $Packages) {
        if (Test-Path (Join-Path $Source "$package.*.nupkg")) {
            Remove-Item (Join-Path $Source "$package.*.nupkg") -Force -Recurse
        }
    }
}

if (!(& dotnet nuget list source | ? { $_ -like "*$SourceName*" })) {
    & dotnet nuget add source $Source -n $SourceName
}

foreach ($package in $Packages) {
    & dotnet pack (Join-Path $Lib $package) -o $Source
}