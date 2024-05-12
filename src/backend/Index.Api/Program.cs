using Index.Api.WebApplicationConfigurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfraStructureServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddMediatR();

builder.ConfigureConfigurations();
builder.ConfigureDatabase();
builder.ConfigureLogging();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.ConfigureSwagger();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();