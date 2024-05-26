using Index.Api.Configurations;
using Index.Api.ProgramConfigurations;

var builder = WebApplication.CreateBuilder(args);
builder.ConfigureBuilder();

var app = builder.Build();
app.ConfigureApp();
app.Run();