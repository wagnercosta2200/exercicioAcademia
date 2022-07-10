using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Data;
using SistemaCadastro.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (opcions => opcions.UseSqlServer
    (" Data Source = DESKTOP - K02VTBG\\SQLEXPRESS; Server = DESKTOP-K02VTBG\\SQLEXPRESS; Database = SistemaCadastro_db; Trusted_Connection = True; "));

//builder.Services.AddDbContext<IContatoRepositorio, ContatoRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
