using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPetShop.Models;

namespace MyPetShop.Data
{
    public class MyPetShopContext : DbContext
    {
        public MyPetShopContext (DbContextOptions<MyPetShopContext> options)
            : base(options)
        {
        }

        public DbSet<MyPetShop.Models.Dog> Dog { get; set; } = default!;
        public DbSet<MyPetShop.Models.Cat> Cat { get; set; } = default!;
    }
}
