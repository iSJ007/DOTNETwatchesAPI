using watchesASP.Api.Data;
using watchesASP.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("WatchStore");
builder.Services.AddSqlite<watchesASPContext>(connString);

var app = builder.Build();




app.MapWatchesEndpoints();
app.MapMovTypeEndpoints();

await app.MigrateDbAsync();

app.Run();
