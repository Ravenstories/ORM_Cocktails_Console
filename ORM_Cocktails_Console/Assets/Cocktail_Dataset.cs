using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Cocktails_Console.DB_Context;

namespace ORM_Cocktails_Console.Assets
{
    public class Cocktail_Dataset
    {
        /// Dataset to add drinks to DB for testing purposes.
        ///  

        public static void addIngredientsToDB()
        {
            IList<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient() {name = "Lime Juice" },
                new Ingredient() {name = "Triple Sec" },
                new Ingredient() {name = "Tequila" },
                new Ingredient() {name = "Dark Rum" },
                new Ingredient() {name = "Orange Curacao" },
                new Ingredient() {name = "Almond Syrup" },
                new Ingredient() {name = "Vodka" },
                new Ingredient() {name = "Kahlua" },
                new Ingredient() {name = "Fresh Cream" },
                new Ingredient() {name = "Cachaca" },
                new Ingredient() {name = "Orange Juice" },
                new Ingredient() {name = "Tomato Juice" },
                new Ingredient() {name = "Bourbon" },
                new Ingredient() {name = "Water" },
                new Ingredient() {name = "Italian Sweet Vermouth" },
                new Ingredient() {name = "French Dry Vermouth" },
                new Ingredient() {name = "Gin" },
                new Ingredient() {name = "White Rum" },
                new Ingredient() {name = "Pink Grapefruit" },
                new Ingredient() {name = "Cranberry Juice" },
                new Ingredient() {name = "Cointreau" },
                new Ingredient() {name = "Soda" },
                new Ingredient() {name = "Cherry Brandy" },
                new Ingredient() {name = "Lemon Juice" },
                new Ingredient() {name = "Sloe Gin" },
                new Ingredient() {name = "Pineapple Juice" },
                new Ingredient() {name = "Coconut Cream" },
                new Ingredient() {name = "Grapefruit Juice" },
                new Ingredient() {name = "Cola" },
                new Ingredient() {name = "Peach Puree" },
                new Ingredient() {name = "Prosecco" }

            };

            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.Ingredient.AddRange(ingredients);
                ctx.SaveChanges();
            }
        }


        public static void addDrinksToDB()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ingredients = ctx.Ingredient.ToList<Ingredient>();
            }
            IList<Drink> drinks = new List<Drink>()
            {
                new Drink()
                {
                    drinkName = "Margarita",
                    other = "Salt rim, Crushed ice, Lime segment.",
                },
                
                new Drink()
                {
                    drinkName = "Mai Tai",
                    other = "Lime section, Maracschino cherry, Lime segment.",
                },
                new Drink()
                {
                    drinkName = "White Russian",
                    other = "",
                },
                new Drink()
                {
                    drinkName = "Caipirinha",
                    other = "5 lime segments, 2tsp caster suger.",
                },
                new Drink()
                {
                    drinkName = "Screwdriver",
                    other = "",
                },
                new Drink()
                {
                    drinkName = "Bloody Mary",
                    other = "Ice cubes, Cellery stick, Worcestershire sauce.",
                },
                new Drink()
                {
                    drinkName = "Whiskey Sour",
                    other = "Maracschino cherry, ½ orange slice, 1 tsp brown sugar.",
                },
                new Drink()
                {
                    drinkName = "Old Fashioned",
                    other = "Cube caster sugar, dash Angostura bitters, orange peel, ice.",
                },
                new Drink()
                {
                    drinkName = "Manhattan",
                    other = "Maracschino cherry, dash Angostura bitters.",
                },
                new Drink()
                {
                    drinkName = "Martini",
                    other = "Olive.",
                },
                new Drink()
                {
                    drinkName = "Daiquiri",
                    other = "1 tsp brown suger.",
                },
                new Drink()
                {
                    drinkName = "Cosmopolitan",
                    other = "",
                },
                new Drink()
                {
                    drinkName = "Singapore Sling",
                    other = "Orange Segment, 1 tsp brown suger.",
                },
                new Drink()
                {
                    drinkName = "Mojito",
                    other = "10 mint leaves, 2 tsp caster sigar, crushed ice, splash soda water.",
                },
                new Drink()
                {
                    drinkName = "Mint Julep",
                    other = "4 mint leaves, 1 tsp brown sugar, 4 crushed ice cubes.",
                },
                new Drink()
                {
                    drinkName = "Tom Collins",
                    other = "Maracschino cherry, orange slice, 1 tsp brown sugar, 3 ice cubes.",
                },
                new Drink()
                {
                    drinkName = "Pina Colada",
                    other = "Pinapple Segment",
                },
                new Drink()
                {
                    drinkName = "Sea Breeze",
                    other = "Ice, lime segment.",
                },
                new Drink()
                {
                    drinkName = "Cuba Libre",
                    other = "Ice.",
                },
                new Drink()
                {
                    drinkName = "Bellini",
                    other = "",
                }
                
            };
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.Drink.AddRange(drinks);
                ctx.SaveChanges();
            }
        }
        /*
        public static void addIngredientsToDrink()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Drink> drinks = new List<Drink>();
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ingredients = ctx.Ingredient.ToList<Ingredient>();
                drinks = ctx.Drink.ToList<Drink>();
            }

            List<IngredientItem> ingredientItem = new List<IngredientItem>()
            {
                 new IngredientItem() { amount = 120, 
                     ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First(), 
                     drink = drinks.Where(i => i.drinkName.Equals("Margarita")).First() },

                 new IngredientItem() { amount = 40, 
                     ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First(), 
                     drink = drinks.Where(i => i.drinkName.Equals("Margarita")).First() },

            };

            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.IngredientItem.AddRange(ingredientItem);
                ctx.SaveChanges();
            }

        }
        */
    }
}




