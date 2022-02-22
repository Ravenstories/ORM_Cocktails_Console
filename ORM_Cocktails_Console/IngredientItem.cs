using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ORM_Cocktails_Console
{
    public class IngredientItem
    {
        public int ingredientId { get; set; }
        public Ingredient ingredient { get; set; }
        
        //[ForeignKey("IngredientItemFK")]
        public int drinkId { get; set; }
        public Drink drink { get; set; }

    }
}
