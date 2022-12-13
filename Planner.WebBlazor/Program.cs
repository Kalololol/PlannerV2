using MediatR;
using Microsoft.EntityFrameworkCore;
using Planner.Api.Infrastructure;
using Planner.Data;
using Planner.WebBlazor;
using Planner.WebBlazor.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();



builder.Services.AddHttpClient<IEmployeeService, EmployeeService>
    (client =>
    {
        client.BaseAddress = new Uri(("https://localhost:7068/"));
    });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7068/") });


builder.Services.AddMediatR(typeof(MediatorConfiguration).Assembly);

builder.Services.AddSingleton(AutoMapperConfig.Initialize());
builder.Services.AddDbContext<ApplicationDbContext>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("PlanowaniePracyConnectionStrings"))
    );
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

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
