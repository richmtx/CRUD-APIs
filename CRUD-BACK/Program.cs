using CRUD_BACK.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Agregar servicios al contenedor
builder.Services.AddControllers();

// 🔹 Configurar conexión a MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
    )
);

// 🔹 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔹 Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();