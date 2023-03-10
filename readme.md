# Decentralized Staffing

[Project](https://github.com/users/JaimeStill/projects/3)

## Internal NuGet Packages

> The following step must be performed before the projects can be built and run.

Windows Script: [`pack-win.ps1`](./pack-win.ps1)  
Linux Script: [`pack-linux.psq`](./pack-linux.ps1)  

Run the relevant **pack** script above to create the local NuGet source and pack all [`lib`](./src/lib) projects.

Argument | Description | Default
---------|-------------|--------
`-Source` | The location of the NuGet package source | `$env:userprofile\packages` or `~/packages/`
`-SourceName` | The name of the NuGet package source | `SOC Packages`

Ensure the source was created:

``` powershell
dotnet nuget list source
```

**Output Resembles:**

```
Registered Sources:
  1.  nuget.org [Enabled]
      https://api.nuget.org/v3/index.json
  2.  SOC Packages [Enabled]
      C:\Users\{user}\packages\
```

Ensure the NuGet package was added to the source:

``` powershell
# replace with `-Source` argument provided to pack.ps1
ls $env:userprofile\packages
```

**Output Resembles:**

```
Directory: C:\Users\{user}\packages

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a---           2/20/2023 10:49 AM          22431 Soc.Api.0.0.1.nupkg
-a---           2/20/2023 10:49 AM           4101 Soc.Contracts.0.0.1.nupkg
-a---           2/20/2023 10:50 AM           3822 Soc.Enterprise.0.0.1.nupkg
-a---           2/20/2023 10:50 AM           4476 Soc.Staffing.0.0.1.nupkg
```