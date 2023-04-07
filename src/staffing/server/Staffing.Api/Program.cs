using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Soc.Api.Graph;
using Soc.Api.Middleware;
using Soc.Api.Services;
using Soc.Enterprise;
using Staffing.Data;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddCors(options =>
        options.AddDefaultPolicy(policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
            policy.WithExposedHeaders(
                "Content-Disposition",
                "Access-Control-Allow-Origin"
            );
        })
    );

builder
    .Services
    .AddDbContext<AppDbContext>(options =>
    {
        options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        options.UseSqlServer(builder.Configuration.GetConnectionString("App"));
    })
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphService();
builder.Services.AddGraphClient<EnterpriseGraph>();
builder.Services.AddAppServices();

var app = builder.Build();
app.UseJsonExceptionHandler();
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseCors();
app.MapControllers();

app.Run();
