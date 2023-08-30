using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    // DB Tabloları ile  proje claslarını ilişkilendirir.
    public class ErpContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Initial Catalog=Erp;Integrated Security=True");
        }

        public DbSet<Cari>? Cariler { get; set; }
     //   public DbSet<Depo>? Depolar { get; set; }
        
    }
}
