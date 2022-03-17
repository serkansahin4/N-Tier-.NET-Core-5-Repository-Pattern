using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class AK47Context:DbContext
    {
        public AK47Context(DbContextOptions<AK47Context> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
