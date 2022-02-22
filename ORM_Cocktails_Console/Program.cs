using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Cocktails_Console.Assets;
using ORM_Cocktails_Console.CRUD;

namespace ORM_Cocktails_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Read read = new Read();

            // If there has been any changes it will drop and recreate the DB. These functions add data. 
            Cocktail_Dataset.addIngredientsToDB();
            Cocktail_Dataset.addDrinksToDB();
            Cocktail_Dataset.addIngredientsToDrink();

            read.showAllDrinks();

            read.showAllIngredientItems();

            Console.ReadKey();
        }

        
    }
}
