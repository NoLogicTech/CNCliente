using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CNCliente;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDk1OTI0QDMxMzkyZTMyMmUzMEIvMGRKbHBqb0hONmhjMnlzVEc2ODZaVTYzcG9CdU9STGR2MDZEMkZ5Um89");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:45000") });

builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();