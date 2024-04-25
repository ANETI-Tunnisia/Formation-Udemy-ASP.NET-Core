using jeudontonestleheors.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestleheors.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {


        }

        //public DefaultContext()
        //{
        //}

        #region Properties
        public DbSet<Aventure> Aventures { get; set; }

        public DbSet<Paragraphe> Paragraphes { get; set; }
        #endregion
    }
}
