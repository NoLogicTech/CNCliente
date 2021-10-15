using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CNCliente;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE5NTUxQDMxMzkyZTMzMmUzMGF5Q0EwNEVBUS9JRGhLYWZIaHh2OVFDaGQrTW1UQWNiTU1mSEZyQ3krNkk9");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:45001") });

builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();