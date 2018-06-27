using Microsoft.EntityFrameworkCore;
using SaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveFood.Data
{
    public class SaveFoodDataContext : DbContext
    {
        public SaveFoodDataContext(DbContextOptions contextOptions)
            :base(contextOptions)
        {

        }

        public DbSet<Resturant> Resturants { get; set; }
    }
}
