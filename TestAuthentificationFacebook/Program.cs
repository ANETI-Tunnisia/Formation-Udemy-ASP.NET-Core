using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestAuthentificationFacebook.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TestAuthentificationFacebookContextConnection") ?? throw new InvalidOperationException("Connection string 'TestAuthentificationFacebookContextConnection' not found.");

builder.Services.AddDbContext<TestAuthentificationFacebookContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<TestAuthentificationFacebook.Areas.Identity.Data.TestAuthentificationFacebookUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<TestAuthentificationFacebookContext>();

// Add services to the container.
builder.Services.AddRazorPages();
var pp = builder.Configuration["apis:facebook:id"];
builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = builder.Configuration["apis:facebook:id"];
    options.AppSecret = builder.Configuration["apis:facebook:secret"];

});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
var test = app.Configuration["apis:facebook:id"];
app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
