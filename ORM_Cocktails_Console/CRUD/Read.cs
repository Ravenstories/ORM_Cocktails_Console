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
                var selectAll = ctx.Drink.OrderBy(d => d.drinkName).ToList();

                foreach (Drink drink in selectAll)
                {
                    Console.WriteLine("Name: " + drink.drinkName);
                    if (drink.ingredientItem != null)
                    {
                        Console.WriteLine("Ingredients: " + string.Join(", ", drink.ingredientItem.Select(i => i.ingredient.name)));
                    }
                    Console.WriteLine("Other: " + drink.other + "\n");
                }
            }
        }
        // Show one drink (Not complete)
        public void showOneDrinks(int id)
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectOne = ctx.Drink.Find(id);
                
                Console.WriteLine("Name: " + selectOne.drinkName);
                Console.WriteLine("Ingredients: " + selectOne.ingredientItem);
                Console.WriteLine("Other: " + selectOne.other + "\n");
            }
        }
        
    }
}
