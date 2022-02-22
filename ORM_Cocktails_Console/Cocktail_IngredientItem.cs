using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console
{
    class Cocktail_IngredientItem
    {
        public int id { get; set; }
        public int amount { get; set; }
        public Cocktail_Ingredients ingredient { get; set; }
        public Cocktail_Drinks drink { get; set; }
    }
}
