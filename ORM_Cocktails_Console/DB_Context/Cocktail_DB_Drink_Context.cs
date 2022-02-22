using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console.DB_Context
{
    class Cocktail_DB_Drink_Context : DbContext
    {
        /// <summary>
        /// Did not complete this asignment. I would have liked to work more on the context classes.
        /// </summary>
        public Cocktail_DB_Drink_Context() : base()
        {
        }

        public DbSet<Drink> Drink {get; set;}
        public DbSet<Ingredient> Ingredient { get; set; }
        //public DbSet<IngredientItem> IngredientItem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<IngredientItem>().HasKey(ii => new { ii.drinkId, ii.ingredientId });


        }
    }
}
