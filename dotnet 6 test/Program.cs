using dotnet_6_test;
var build = WebApplication.CreateBuilder(args).RegisterServices().Build();

build.SetupMiddleware();