# Session Notes

Left off building out the [`Soc.Api`](./src/lib/Soc.Api/) library. Finished building services.

Also generated the [`Enterprise`](./src/enterprise) API to facilitate maintaining fundamental cross-service API data (i.e. - `Organization`, `User`, etc.).

Todo:

- [ ] Build [`Soc.Api.Controllers`](./src/lib/Soc.Api/Controllers/)
- [x] Work out building a NuGet package for `Soc.Api` via. See [Creating and Using a Local NuGet Package](https://spin.atomicobject.com/2021/01/05/local-nuget-package/) as a starting point with the intention of using [`dotnet nuget`](https://learn.microsoft.com/en-us/nuget/reference/dotnet-commands).
- [ ] Integrate `Soc.Api` into `Enterprise` and `Staffing`.
- [ ] Remove `Enterprise` entities from `Staffing`.
- [ ] Finalize `Staffing` and `Enterprise` schemas with initial migrations.
- [ ] Build out services and controllers with `Soc.Api` infrastructure.
- [ ] Build out error handling middleware in `Soc.Api`.