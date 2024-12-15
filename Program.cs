using EmployeeManagement.Web;
using EmployeeManagement.Web.Pages;
using EmployeeManagement.Web.Services;
using EmployeeManagement.Web.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7041/");
});


builder.Services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
{

    client.BaseAddress = new Uri("https://localhost:7041/");

});

builder.Services.AddHttpClient<IDepartmentService, DepartmentService>(client =>

{

    client.BaseAddress = new Uri("https://localhost:7041/");

});
builder.Services.AddAutoMapper(typeof(EmployeeProfile));
builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();
