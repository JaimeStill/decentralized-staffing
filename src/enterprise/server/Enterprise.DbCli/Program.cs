using Enterprise.Data;
using Soc.Api.Db;

await DbManager<AppDbContext>
    .Execute(args);