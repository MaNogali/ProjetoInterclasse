using Microsoft.EntityFrameworkCore;
using ProjetoInterclasse.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

// Registra o DbContext com a connection string do appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 30)) // ajuste conforme sua versão do MySQL
    )
);

var app = builder.Build();

// Configurações de pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sistema}/{action=Index}/{id?}");

app.Run();