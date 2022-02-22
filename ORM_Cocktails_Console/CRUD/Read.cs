using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Cocktails_Console.DB_Context;


namespace ORM_Cocktails_Console.CRUD
{
    public class Read
    {
        //Shows all drinks in the DB
        public void showAllDrinks()
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectAll = ctx.Drinks.OrderBy(d => d.drinkName).ToList();

                foreach (Cocktail_Drinks drink in selectAll)
                {
                    Console.WriteLine("Name: " + drink.drinkName);
                    if (drink.ingredients != null)
                    {
                        Console.WriteLine("Ingredients: " + string.Join(", ", drink.ingredients.Select(i => i.ingredient.name)));
                    }
                    Console.WriteLine("Other: " + drink.other + "\n");
                }
            }
        }
        // Show one drink 
        public void showOneDrinks(int id)
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectOne = ctx.Drinks.Find(id);
                
                Console.WriteLine("Name: " + selectOne.drinkName);
                Console.WriteLine("Ingredients: " + selectOne.ingredients);
                Console.WriteLine("Other: " + selectOne.other + "\n");
            }
        }

        public void showAllIngredientItems()
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectAll = ctx.IngredientItems.OrderBy(d => d.drink.drinkName).ToList();

                foreach (Cocktail_IngredientItem drink in selectAll)
                {
                    Console.WriteLine("Name: " + drink.drink.drinkName);
                    
                    Console.WriteLine("Ingredients: " + string.Join(", ", drink.ingredient.name));
                    
                    Console.WriteLine("Other: " + drink.drink.other + "\n");
                }
            }
        }
    }
}
