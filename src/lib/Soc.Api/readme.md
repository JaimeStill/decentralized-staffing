# Soc.Api

## NuGet Setup

1. Added the following to `Soc.Api.csproj`:

    ```csproj
    <PropertyGroup>
        <PackageId>Soc.Api</PackageId>
        <TargetFramework>net7.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Version>0.0.1</Version>
        <Authors>Jaime Still</Authors>
    </PropertyGroup>
    ```
2. Packed the NuGet package:

    ```bash
    dotnet pack
    ```

3. Added a local package source to host:

    ```bash
    mkdir ~/packages

    dotnet nuget add source ~/packages -n "local packages"
    ```

4. Published package to local package source:

    ```bash
    dotnet nuget push bin/Debug/Soc.Api.0.0.1.nupkg --source ~/packages
    ```

### Project Integration

Add the package to the following projects:

* `{Project}.Api`
* `{Project}.Data`
* `{Project}.DbCli`
* `{Project}.Models`
* `{Project}.Services`

```bash
dotnet add package Soc.Api
```

Replaces the following infrastructure:

* *{Project}.Api/Controllers/Base/\**
* *{Project}.Models/Core/\**
* *{Project}.Models/Entities/Base/\**
* *{Project}.Models/Query/\**
* *{Project}.Models/Validation/\**
* *{Project}.Services/Api/Base/\**
* *{Project}.Services/Exceptions/\**
* *{Project}.Services/Extensions/\**
* *{Project}.Services/Interfaces/\**