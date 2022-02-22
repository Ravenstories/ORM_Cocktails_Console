using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cocktails_Console
{
    class Cocktail_Drinks
    {
        public int id { get; set; }
        public string drinkName { get; set; }
        public IList<Cocktail_IngredientItem> ingredients { get; set; }
        public string other { get; set; }

        public byte[] picture { get; set; }

    }
}
