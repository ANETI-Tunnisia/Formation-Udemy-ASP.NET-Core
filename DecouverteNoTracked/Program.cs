// See https://aka.ms/new-console-template for more information
using DecouverteNoTracked;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

ConfigurationBuilder builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionstring = config.GetConnectionString("DefaultContext");

Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder();

optionsBuilder.UseSqlServer(connectionstring);

using var context=new WookieContext(optionsBuilder.Options);
context.wookies.ToList().ForEach(x =>Console.WriteLine(x.Name));
var pp = 1;
//context.wookies.AsNoTracking();
//context.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking;

