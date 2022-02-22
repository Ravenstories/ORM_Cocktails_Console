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
        // Dataset to add drinks to DB for testing purposes. 
        public static void addIngredientsToDB()
        {
            IList<Cocktail_Ingredients> ingredients = new List<Cocktail_Ingredients>()
            {
                new Cocktail_Ingredients() {name = "Lime Juice" },
                new Cocktail_Ingredients() {name = "Triple Sec" },
                new Cocktail_Ingredients() {name = "Tequila" },
                new Cocktail_Ingredients() {name = "Dark Rum" },
                new Cocktail_Ingredients() {name = "Orange Curacao" },
                new Cocktail_Ingredients() {name = "Almond Syrup" },
                new Cocktail_Ingredients() {name = "Vodka" },
                new Cocktail_Ingredients() {name = "Kahlua" },
                new Cocktail_Ingredients() {name = "Fresh Cream" },
                new Cocktail_Ingredients() {name = "Cachaca" },
                new Cocktail_Ingredients() {name = "Orange Juice" },
                new Cocktail_Ingredients() {name = "Tomato Juice" },
                new Cocktail_Ingredients() {name = "Bourbon" },
                new Cocktail_Ingredients() {name = "Water" },
                new Cocktail_Ingredients() {name = "Italian Sweet Vermouth" },
                new Cocktail_Ingredients() {name = "French Dry Vermouth" },
                new Cocktail_Ingredients() {name = "Gin" },
                new Cocktail_Ingredients() {name = "White Rum" },
                new Cocktail_Ingredients() {name = "Pink Grapefruit" },
                new Cocktail_Ingredients() {name = "Cranberry Juice" },
                new Cocktail_Ingredients() {name = "Cointreau" },
                new Cocktail_Ingredients() {name = "Soda" },
                new Cocktail_Ingredients() {name = "Cherry Brandy" },
                new Cocktail_Ingredients() {name = "Lemon Juice" },
                new Cocktail_Ingredients() {name = "Sloe Gin" },
                new Cocktail_Ingredients() {name = "Pineapple Juice" },
                new Cocktail_Ingredients() {name = "Coconut Cream" },
                new Cocktail_Ingredients() {name = "Grapefruit Juice" },
                new Cocktail_Ingredients() {name = "Cola" },
                new Cocktail_Ingredients() {name = "Peach Puree" },
                new Cocktail_Ingredients() {name = "Prosecco" }

            };

            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.Ingredients.AddRange(ingredients);
                ctx.SaveChanges();
            }
        }


        public static void addDrinksToDB()
        {
            List<Cocktail_Ingredients> ingredients = new List<Cocktail_Ingredients>();
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ingredients = ctx.Ingredients.ToList<Cocktail_Ingredients>();
            }
            IList<Cocktail_Drinks> drinks = new List<Cocktail_Drinks>()
            {
                new Cocktail_Drinks()
                {
                    drinkName = "Margarita",
                    
                    other = "Salt rim, Crushed ice, Lime segment.",
                },
                #region
                /*
                new Cocktail_Drinks()
                {
                    drinkName = "Mai Tai",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Lime section, Maracschino cherry, Lime segment.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "White Russian",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Caipirinha",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "5 lime segments, 2tsp caster suger.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Screwdriver",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Bloody Mary",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Ice cubes, Cellery stick, Worcestershire sauce.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Whiskey Sour",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Maracschino cherry, ½ orange slice, 1 tsp brown sugar.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Old Fashioned",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Cube caster sugar, dash Angostura bitters, orange peel, ice.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Manhattan",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Maracschino cherry, dash Angostura bitters.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Martini",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Olive.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Daiquiri",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "1 tsp brown suger.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Cosmopolitan",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Singapore Sling",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Orange Segment, 1 tsp brown suger.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Mojito",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "10 mint leaves, 2 tsp caster sigar, crushed ice, splash soda water.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Mint Julep",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "4 mint leaves, 1 tsp brown sugar, 4 crushed ice cubes.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Tom Collins",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Maracschino cherry, orange slice, 1 tsp brown sugar, 3 ice cubes.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Pina Colada",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Pinapple Segment",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Sea Breeze",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Ice, lime segment.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Cuba Libre",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "Ice.",
                },
                new Cocktail_Drinks()
                {
                    drinkName = "Bellini",
                    ingredients = new List<Cocktail_IngredientItem>(){
                        new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First()},
                        new Cocktail_IngredientItem() { amount = 40, ingredient = ingredients.Where(i => i.name.Equals("Vodka")).First()}

                    },
                    other = "",
                }
                */
                #endregion
            };
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.Drinks.AddRange(drinks);
                ctx.SaveChanges();
            }
        }
        public static void addIngredientsToDrink()
        {
            List<Cocktail_Ingredients> ingredients = new List<Cocktail_Ingredients>();
            List<Cocktail_Drinks> drinks = new List<Cocktail_Drinks>();
            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ingredients = ctx.Ingredients.ToList<Cocktail_Ingredients>();
                drinks = ctx.Drinks.ToList<Cocktail_Drinks>();
            }

            List<Cocktail_IngredientItem> ingredientItem = new List<Cocktail_IngredientItem>()
            {
                 new Cocktail_IngredientItem() { amount = 120, ingredient = ingredients.Where(i => i.name.Equals("Orange Juice")).First(), drink = drinks.Where(i => i.drinkName.Equals("Margarita")).First() },

            };

            using (var ctx = new Cocktail_DB_Drink_Context())
            {
                ctx.IngredientItems.AddRange(ingredientItem);
                ctx.SaveChanges();
            }

        }
    }
}




