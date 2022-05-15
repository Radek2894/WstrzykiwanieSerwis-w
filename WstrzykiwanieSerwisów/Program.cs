using Microsoft.EntityFrameworkCore;
using WstrzykiwanieSerwis�w;
using WstrzykiwanieSerwis�w.Data;
using WstrzykiwanieSerwis�w.Interfaces;
using WstrzykiwanieSerwis�w.Repositories;
using WstrzykiwanieSerwis�w.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddProjectService();

builder.Services.AddDbContext<PeopleContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("EFDemoDB")));



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
