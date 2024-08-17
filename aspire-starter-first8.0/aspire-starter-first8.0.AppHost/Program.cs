var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.aspire_starter_first8__0_ApiService>("apiservice");

builder.AddProject<Projects.aspire_starter_first8__0_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
