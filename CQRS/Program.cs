using ProductAPI.Manuel_CQRS.Handlers.CommandHandlers;
using ProductAPI.Manuel_CQRS.Handlers.QueryHandlers;
using ProductAPI.Models.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

#region --Manuel_CQRS--
builder.Services.AddSingleton<CreateProductCommandHandler>()
                .AddSingleton<DeleteProductCommandHandler>()
                .AddSingleton<GetByIdProductQueryHandler>()
                .AddSingleton<GetAllProductQueryHandler>();
#endregion



#region --MediatR_CQRS--
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));

#endregion


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
