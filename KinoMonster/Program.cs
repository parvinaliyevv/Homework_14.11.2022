var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("custom",
    pattern: "{controller}",
    defaults: new { action = "Index" }
);

app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

app.Run();
