using StudyLounge.Application;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAppliccation();

var app = builder.Build();
app.MapEndPoints();

app.Run();
