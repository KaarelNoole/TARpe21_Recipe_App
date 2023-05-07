using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TARpe21_Recipe_App.Services
{
    public class RecipeService
    {

        private static List<Recipe> recipes = new()
        {

            new()
            {
                Name = " Chicken Fajitas",
                HeroImage = "chickenfaij.jpg",
                TotalTime = "   30 min",
                Ingredients = "All you need is chicken, bell pepper, onion, lime juice and spices, plus tortillas and your favorite toppings. It’s incredibly easy.",
                Description = ""
,

            },

            new()
            {
                Name = " Lasagne",
                HeroImage="lasagne.jpg",
                TotalTime = "   3 hrs 15 mins",
                Ingredients = "Meat, Onion and garlic, Crushed tomatoes, Sugar, Lasagna noodles, Cheeses (Parmesan, Mozzarella), Egg.",
                Description = "Make the meat sauce.\r\n2. Cook the noodles.\r\n3. Make the ricotta mixture.\r\n4. Layer the lasagna according to the recipe instructions.\r\n5. Cover with foil and bake.\r\n6. Let the lasagna rest before serving.",
               
            },

            new()
            {
                Name = " Mac & Cheese",
                HeroImage="macandcheese.jpg",
                TotalTime = "   30 min",
                Ingredients = "Macaroni: This homemade mac and cheese starts with a box of uncooked macaroni noodles.\r\n· Butter and flour: You'll need butter and flour to make a roux for the cheese sauce. You'll also need two tablespoons of butter for the topping.\r\n· Milk: Use whole milk for the richest flavor and texture.\r\n· Cheese: This baked mac and cheese recipe calls for Cheddar and Parmesan cheeses.\r\n· Seasonings: Salt and pepper goes into the sauce, while paprika is sprinkled over the topping.\r\n· Bread crumbs: Use store-bought dried bread crumbs or make your own at home.",
                Description = "Boil the pasta, drain.\r\nMake the cheese sauce by combining a fat (butter), and starch (flour), then whisking in the milk products.\r\nCook the sauce until it’s nice and thick.\r\nAdd in shredded cheeses, stir well.\r\nCombine cheese sauce with cooked pasta.\r\nTransfer half of the mac and cheese to a baking dish, sprinkle with more shredded cheese.\r\nTop with the rest of the mac and cheese, top with more shredded cheese.\r\nBake and prepare to thoroughly enjoy!",
                Images = new()
               
            },

            new()
            {
                Name = " Pasta",
                HeroImage="pasta.jpg",
                TotalTime = "  30 min",
                Ingredients = "Penne pasta\r\n Yellow onion\r\n Cloves garlic\r\n Olive oil\r\n Can diced tomatoes\r\n Dried oregano\r\n Dried basil\r\n Crushed red pepper\r\n Salt\r\nfreshly cracked black pepper to taste ($0.03)\r\n Tomato paste\r\n Cream cheese\r\n grated Parmesan\r\n Fresh spinach",
                //Description= 
            
            },

            new()
            {
                Name = " Teriyaki Chicken",
                HeroImage="chickenteriyaki.jpg",
                TotalTime = "   15 min",
                Ingredients = " Chicken breasts\r\n Olive oil\r\n Low-sodium soy sauce\r\n Honey\r\n Brown sugar:\r\n Rice vinegar. Even lemon juice can be used in a pinch.\r\n Sesame oil\r\n Ginger",
                Description = " Heat oil in a large non-stick skillet or wok.\r\n Add chicken and let cook (giving space between pieces) until slightly browned on bottom then flip chicken pieces over and cook through.\r\n While the chicken is cooking whisk together the teriyaki sauce mixture.\r\n Pour sauce into the skillet once the chicken is just nearly finished cooking through and let the sauce cook and simmer until thickened.\r\n Easy as that! Serve it warm over brown or white rice with steamed veggies.",
              
            },


        };

        public static List<Recipe> GetAllRecipes()
        {
            return recipes;
        }

        public static Recipe GetRecipe(string recipeName)
        {
            return recipes.Where(_recipe => _recipe.Name == recipeName).FirstOrDefault();
        }

        public static List<Recipe> GetFeaturedRecipes()
        {
            var rnd = new Random();
            var randomizedRecipes = recipes.OrderBy(item => rnd.Next());

            return randomizedRecipes.Take(3).ToList();
        }
    }
}
