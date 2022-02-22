using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_Cocktails_Console
{
    public class Ingredient
    {
        /*public Ingredient()
        {
            this.ingredientItem = new HashSet<IngredientItem>();
        }*/

        public int id { get; set; }
        public string name { get; set; }

        //[ForeignKey("IngredientItemFK")]
        public int ingredientItemId { get; set; }


    }
}
