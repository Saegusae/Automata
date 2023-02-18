using Automata.Application;
using Automata.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
  
  builder.Services.AddControllers();
  builder.Services.AddEndpointsApiExplorer();
  builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
  app.UseSwagger();
  app.UseSwaggerUI();

  app.MapControllers();
  app.Run();
}
