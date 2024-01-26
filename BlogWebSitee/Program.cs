using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_BussinessLayer.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using NETCore.MailKit.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<BlogWebSite_BussinessLayer.Service.IEmailService, EmailManager>();
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(Options =>
{
    Options.Cookie.Name = "BlogWebSite";
    Options.LoginPath = "/Admin/Login/Index";
    Options.AccessDeniedPath = "/Admin/Login/Index";
});

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Blog}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "areas",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});

app.Run();
