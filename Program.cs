using Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ISingleton>(new Value());
builder.Services.AddScoped<IScoped, Value>();
builder.Services.AddTransient<ITransient, Value>();

var app = builder.Build();

app.MapGet("/value", (ISingleton valueSingleton,
                    IScoped valueScoped1, IScoped valueScoped2,
                    ITransient valueTransient1, ITransient valueTransient2) =>
{
    return $"Singleton instance: {valueSingleton.ID}\r\n\r\n" +
        $"Scoped instance 1: {valueScoped1.ID}\r\nScoped instance 2: {valueScoped2.ID}\r\n\r\n" +
        $"Transient instance 1: {valueTransient1.ID}\r\nTransient instance 2: {valueTransient2.ID}";
});

app.Run();
