using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA2_Prep.Model;

namespace CA2_Prep.Model
{
    public class StarfleetContext : DbContext
    {
        public StarfleetContext(DbContextOptions<StarfleetContext> options)
            : base(options)
        {

        }

        public DbSet<Officer> Officers { get; set; }
    }
}
