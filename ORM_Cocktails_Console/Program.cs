using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Cocktails_Console.Assets;
using ORM_Cocktails_Console.CRUD;
using ORM_Cocktails_Console.DB_Context;

namespace ORM_Cocktails_Console
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (var ctx = new Cocktail_DB_Context())
            {
                //This runs the class where the function to drop and create the db will be run. 
            }

            Read read = new Read();

            // It will drop and recreate the DB. These functions add data. 
            Cocktail_Dataset.addIngredientsToDB();
            Cocktail_Dataset.addDrinksToDB();

            read.showAllDrinks();

            Console.ReadKey();
        }

        
    }
}
