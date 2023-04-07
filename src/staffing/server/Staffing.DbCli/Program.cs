using Soc.Api.Db;
using Staffing.Data;

await DbManager<AppDbContext>
    .Execute(args);