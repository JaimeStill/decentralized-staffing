param(
    [string]
    [Parameter()]
    $Source = "$env:userprofile\packages\",
    [string]
    [Parameter()]
    $SourceName = "SOC Packages"
)

$Lib = ".\src\lib\"

# packages to pack
$Packages = @("Soc.Api", "Soc.Contracts", "Soc.Enterprise", "Soc.Staffing")

# projects to restore
$Projects = @(".\src\enterprise\server", ".\src\staffing\server");

# clear the local cache
# this is necessary when rebuilding
# the same package version during development
& dotnet nuget locals all --clear

# if the source path doesn't exist, create it
# otherwise, remove all listed packages
if (!(Test-Path $Source)) {
    New-Item $Source -ItemType Directory
} else {
    foreach($package in $Packages) {
        if (Test-Path (Join-Path $Source "$package.*.nupkg")) {
            Remove-Item (Join-Path $Source "$package.*.nupkg") -Force -Recurse
        }
    }
}

# Add the NuGet source if it doesn't exist
if (!(& dotnet nuget list source | Where-Object { $_ -like "*$SourceName*" })) {
    & dotnet nuget add source $Source -n $SourceName
}

# pack all listed packages
foreach ($package in $Packages) {
    & dotnet pack (Join-Path $Lib $package) -o $Source
}

# force restore all listed projects
foreach ($project in $Projects) {
    & dotnet restore $project -f
}