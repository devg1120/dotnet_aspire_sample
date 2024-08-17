var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.aspire_starter_first2_ApiService>("apiservice");

builder.AddProject<Projects.aspire_starter_first2_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
