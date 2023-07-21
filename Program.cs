using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// db access and EFC
using ecocivicom_blazor_clone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BlazorBootstrap;

var builder = WebApplication.CreateBuilder(args);

// See appsettings.json for connection string infos
var connectionString = builder.Configuration.GetConnectionString("EcocivicomDB");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// builder.Services.AddDbContextFactory<EmployeeDataContext>(options => options.UseSqlite(connectionString));
builder.Services.AddDbContextFactory<FormationsCategoriesDataContext>(options => options.UseSqlite(connectionString));
builder.Services.AddBlazorBootstrap();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
