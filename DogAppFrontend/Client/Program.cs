    using DogAppFrontend.Client;
    using Microsoft.AspNetCore.Components.Web;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    var isDevelopment = builder.HostEnvironment.IsDevelopment();

    var baseAddress = isDevelopment ?
        new Uri("https://localhost:7068") :
        new Uri("https://dogappbe.azurewebsites.net");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseAddress });
    builder.Services.AddScoped<DogService>();


    await builder.Build().RunAsync();
