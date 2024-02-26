// See https://aka.ms/new-console-template for more information

using MesPremiersTestsAvecEntitiesCodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

ConfigurationBuilder builder=new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");
var config=builder.Build();
string connectionstring=config.GetConnectionString("DefaultContext");

DbContextOptionsBuilder optionsBuilder=new DbContextOptionsBuilder();

optionsBuilder.UseSqlServer(connectionstring);
using(DefaultContext context=new DefaultContext(optionsBuilder.Options))
{
    var query=from droide in context.Droides
              select droide;
    foreach (var item in query.ToList())
    {
        Console.WriteLine(item.Matricule);
    }
}

Console.WriteLine("Hello, World!");
