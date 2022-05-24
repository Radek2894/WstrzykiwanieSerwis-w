using Microsoft.EntityFrameworkCore;
using WstrzykiwanieSerwis�w;
using WstrzykiwanieSerwis�w.Data;
using WstrzykiwanieSerwis�w.Interfaces;



var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<PeopleContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("Serwisy")));

builder.Services.AddProjectService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();



app.Run();
