var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MvpSampleProject>("mvpsampleproject");

builder.Build().Run();
