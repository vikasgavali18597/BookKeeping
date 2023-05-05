using BookKeeping.Api;
using BookKeeping.DataStore;
using BookKeeping.Repository;
using BookKeeping.Services;
using BookKeeping.Services.Profiles;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



    // Add services to the container.

    builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("BookKeeping");

if (connectionString ==  null)
{
    throw new Exception("BookKeeping connection string is missing ....!");
}

builder.Services.AddDbContext<BookKeepingDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.ServiceCollection(builder.Services);
builder.Services.RepositoryCollection(builder.Services);

builder.Services.AddAutoMapper(typeof(BookKeepingProfile).Assembly);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BookKeepingDbContext>();
    dbContext.Database.Migrate();
    if (dbContext.AccountCategories.Count() <= 0)
    {
        dbContext.AccountCategories.AddRange(builder.Services.GetAccountCategories());
        dbContext.SaveChanges();
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
