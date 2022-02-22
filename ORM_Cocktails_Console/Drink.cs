using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ORM_Cocktails_Console
{
    public class Drink
    {
        public Drink()
        {
            this.ingredientItem = new HashSet<IngredientItem>();
        }


        public int id { get; set; }
        public string drinkName { get; set; }
        public string other { get; set; }

        //[ForeignKey("IngredientItem")]
        public int IngredientItemFK { get; set; }
        public ICollection<IngredientItem> ingredientItem { get; set; }

    }
}
