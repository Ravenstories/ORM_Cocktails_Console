using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Cocktails_Console.DB_Context;


namespace ORM_Cocktails_Console.CRUD
{
    class Delete
    {
        //Delete all entries in the drink table
        public void deleteAllDrinks()
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectAll = ctx.Drink.OrderBy(d => d.drinkName).ToList();

                ctx.Drink.RemoveRange(selectAll);
                ctx.SaveChanges();
            }
        }

        public void deleteOneDrinkToDelete(int id)
        {
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                var selectDrinkToDelete = ctx.Drink.Find(id);

                ctx.Drink.Remove(selectDrinkToDelete);
                ctx.SaveChanges();
            }
        }
    }
}
