using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console.DB_Context
{
    class Cocktail_DB_Context : DbContext
    {
        public Cocktail_DB_Context() : base()
        {
            Database.SetInitializer<Cocktail_DB_Drink_Context>(new DropCreateDatabaseAlways<Cocktail_DB_Drink_Context>());
        }
    }
}
