using Staffing.Data;
using Microsoft.EntityFrameworkCore;

namespace Staffing.DbCli.Seed;
public static class SeedExtensions
{
    public static async Task Seed(this AppDbContext db)
    {
        Console.WriteLine($"Seeding into {db.Database.GetConnectionString()}");
        await Task.CompletedTask;
    }
}