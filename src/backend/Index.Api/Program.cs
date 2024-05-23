using Index.Api.WebApplicationConfigurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfraStructureServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddMediatR();

builder.ConfigureConfigurations();
builder.ConfigureDatabase();
builder.ConfigureLogging();
builder.ConfigureSwaggerGen();
builder.ConfigureModelExamples();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.ConfigureSwagger();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();