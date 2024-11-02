<<<<<<< HEAD
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

=======
>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
=======
// Configura IHttpClientFactory para permitir solicitudes HTTP
builder.Services.AddHttpClient();

// Habilitar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
<<<<<<< HEAD
 
=======
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

<<<<<<< HEAD
=======
// Habilitar CORS
app.UseCors("AllowAllOrigins");

>>>>>>> 8f964237215e8671a95502cd1ed201f6e3fd3de8
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
