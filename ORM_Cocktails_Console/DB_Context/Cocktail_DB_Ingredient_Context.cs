using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console.DB_Context
{
    class Cocktail_DB_Ingredient_Context : DbContext
    {
        public Cocktail_DB_Ingredient_Context() : base()
        {
            Database.SetInitializer<Cocktail_DB_Ingredient_Context>(new DropCreateDatabaseAlways<Cocktail_DB_Ingredient_Context>());
        }

        public DbSet<Cocktail_Drinks> Drinks { get; set; }
        public DbSet<Cocktail_Ingredients> Ingredients { get; set; }
    }
}
