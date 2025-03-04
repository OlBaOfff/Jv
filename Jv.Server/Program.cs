using Infrastructure.DbCont;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//a DbCont hozzaadtuk a DependencyInjection konténerhez
builder.Services.AddDbContext<DbCont>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JvAppDataBase")));

var app = builder.Build();

//scopen belul lekertuk a DbCont meghivtuk az ensurecreat metodusat
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DbCont>();
    dbContext.Database.EnsureCreated();
    
}

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
