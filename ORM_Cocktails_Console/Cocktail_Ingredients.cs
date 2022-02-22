using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console
{
    class Cocktail_Ingredients
    {
        public int id { get; set; }
        public string name { get; set; }

        public IList<Cocktail_IngredientItem> ingredientItems { get; set; }
    }
}
