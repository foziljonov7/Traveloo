using API.Data;
using API.Entities.User;
using API.Services;
using Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("localhost")
    ?? throw new InvalidOperationException("Connection string not found!");

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options
    => options.UseNpgsql(connectionString));

builder.Services.AddDbContext<ApplicationDbContext>(options
    => options.UseNpgsql(connectionString));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
//Services
builder.Services.AddScoped<IHumanService, HumanService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
