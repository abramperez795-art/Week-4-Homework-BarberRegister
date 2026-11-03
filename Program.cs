using BarberRegister.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BarberRegisterContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("BarberRegisterContext")
        ?? throw new InvalidOperationException(
            "Set ConnectionStrings:BarberRegisterContext before starting the app.")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStatusCodePagesWithReExecute("/Home/Missing");

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();