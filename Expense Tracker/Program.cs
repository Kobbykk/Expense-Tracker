using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ExpenseConnection")));


var app = builder.Build();

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSn5Ud0VmWnpbdHdSQw==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdUVkWH9bc3FQQmVUUQ==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZjXn5edXdQQ2RbVUE=;MTI3MzAxMUAzMjMwMmUzNDJlMzBvMDNzbUhvb0NuU09aRU9GdjZQVWZ4VXJza2FQSkI1UTNQNzF4Z2dnVTVNPQ==;MTI3MzAxMkAzMjMwMmUzNDJlMzBKdE0zYUJHUWFxTmFsbDhVMWdKVXZxWCtrSUhtb1pGdjBVZk14M2M1L0dBPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVgWXhfcHFWQ2VaUUVz;MTI3MzAxNEAzMjMwMmUzNDJlMzBYOEdFVDZmNkRUZjRZWkhxYnVJSWs5WWY5TVF3WXdXVmxudDNkQWNWcHJZPQ==;MTI3MzAxNUAzMjMwMmUzNDJlMzBIc2RrNjcwTWtyMyt3WTdZZWtwZ0NJaXVSb3F2TE1OZXpxYXZiQzh6UnpFPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZjXn5edXdQQ2ddUkE=;MTI3MzAxN0AzMjMwMmUzNDJlMzBPc2lQM0dhSC8vZDU1QVFDS3NIdE5KdzVCWnQ2cUJPeWhMYXkzUGZTVHNnPQ==;MTI3MzAxOEAzMjMwMmUzNDJlMzBOTE1oRXF2c2tUYVdYQmdXVDhDd0ZCUEVLeVJhM0hLMGtlOExadE84YnJzPQ==;MTI3MzAxOUAzMjMwMmUzNDJlMzBYOEdFVDZmNkRUZjRZWkhxYnVJSWs5WWY5TVF3WXdXVmxudDNkQWNWcHJZPQ==");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
