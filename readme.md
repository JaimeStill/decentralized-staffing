# Decentralized Staffing

[Project](https://github.com/users/JaimeStill/projects/3)

## Setup

The following are required to work with this project:

* [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) - I currently run SQL Server 2019 Express. The connection strings in this project point to a server named `DevSql`:
    * [Enterprise.Api - appsettings.Development.json](./src/enterprise/server/Enterprise.Api/appsettings.Development.json)
    * [Enterprise.DbCli - connections.json](./src/enterprise/server/Enterprise.DbCli/connections.json)
    * [Staffing.Api - appsettings.Development.json](./src/staffing/server/Staffing.Api/appsettings.Development.json)
    * [Staffing.DbCli - connections.json](./src/staffing/server/Staffing.DbCli/connections.json)

Everything you need to execute from the command line is available as a VS Code task. 

Available tasks are:

Task | Description
-----|------------
`<service>-db-drop` | Drop the database for the corresponding service.
`<service>-db-seed` | Seed the database for the corresponding service.
`<service>-db-update` | Apply the latest migrations to database for the corresponding service.
`<service>-server-build` | Build the corresponding service.
`<service>-restore` | Restore dependencies for the corresponding service.
`<service>-run` | Run the corresponding service in watch mode.

You can interface with them in two ways:

**Command Palette**

1. Press <kbd>F1</kbd> and select *Tasks: Run Task*
2. Select the task you would like to run.

**Task Explorer Extension**

Install the [Task Explorer Extension]() and they will be made available form the Explorer menu:

![image](https://user-images.githubusercontent.com/14102723/230668952-b98e14d0-ac5e-4f99-8e8c-699996e9355f.png)

## OmniSharp Configuration

When working with multiple .NET solutions in Visual Studio Code, you can define a solution that references each project across each sub-solution. In this project, that is [**Core.sln**](./src/Core.sln).

Once you have this defined, you can have OmniSharp target the solution by pressing <kbd>F1</kbd>, selecting *OmniSharp: Select Project*, and selecting **Core.sln**.

## Internal NuGet Packages

> Currently, all of the projects use internal references vs. package references to facilitate debugging. This is here as a point of reference to illustrate this capability at a later point.

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
-a---           2/20/2023 10:50 AM           3822 Soc.Enterprise.0.0.1.nupkg
-a---           2/20/2023 10:50 AM           4476 Soc.Staffing.0.0.1.nupkg
```