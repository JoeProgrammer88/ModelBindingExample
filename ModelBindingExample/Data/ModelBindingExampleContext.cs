using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelBindingExample.Models;

namespace ModelBindingExample.Data
{
    public class ModelBindingExampleContext : DbContext
    {
        public ModelBindingExampleContext (DbContextOptions<ModelBindingExampleContext> options)
            : base(options)
        {
        }

        public DbSet<ModelBindingExample.Models.Product> Product { get; set; } = default!;
    }
}
