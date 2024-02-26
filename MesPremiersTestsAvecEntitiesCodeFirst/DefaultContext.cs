using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    public class DefaultContext:DbContext
    {
        public DefaultContext(DbContextOptions options):base(options) 
        {
                
        }
        protected DefaultContext()
        {
                
        }
        public DbSet<Droide> Droides { get; set; }
    }
}
