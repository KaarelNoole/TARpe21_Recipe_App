using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal static class RecipeService
    {

        private static List<Recipe> recipes = new()
        {
            new()
            {
                Name = " Chicken Fajitas",
                TotalTime = "30 min",
                Ingredients = "All you need is chicken, bell pepper, onion, lime juice and spices, plus tortillas and your favorite toppings. It’s incredibly easy.",
                Description = "Season the chicken. Generously sprinkle the fajita seasoning on both sides of the chicken and use your fingers to press it in.\r\nCook the chicken. Heat a large skillet over medium heat and lightly coat it with a drizzle of olive oil or avocado oil. Sear the chicken breasts for about 7-8 minutes on each side. Then remove them from the pan and let them rest for a few minutes before slicing into strips.\r\nSaute the bell peppers and onion. While the chicken is cooking, cut the bell peppers and onions into thin slices. Then saute them in the same skillet over medium heat for a few minutes until caramelized. You’re essentially making fajita veggies.\r\nMix together. Add the chicken back into the skillet, squeeze fresh lime juice on top and stir everything together.\r\nWrap it up. Serve immediately with tortillas and extra toppings.\r\n"
,
                Images = new()
                {
                    "https://www.wholesomeyum.com/wp-content/uploads/2021/05/wholesomeyum-how-to-make-chicken-fajitas-easy-fajita-recipe-14.jpg"
                }



            },

            new()
            {
                Name = " Lasagne",
                TotalTime = "3 hrs 15 mins",
                Ingredients = "Meat, Onion and garlic, Crushed tomatoes, Sugar, Lasagna noodles, Cheeses (Parmesan, Mozzarella), Egg.",
                Description = "Make the meat sauce.\r\n2. Cook the noodles.\r\n3. Make the ricotta mixture.\r\n4. Layer the lasagna according to the recipe instructions.\r\n5. Cover with foil and bake.\r\n6. Let the lasagna rest before serving.",
                Images = new()
                {
                    "https://www.allrecipes.com/thmb/GpFwGajCiKaKdt_Igr7n6o0ult4=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/worlds-best-lasagna-326144cb84a54159ab08523a704a3f0a.jpeg"
                }



            },

            new()
            {
                Name = " Mac & Cheese",
                TotalTime = "30 min",
                Ingredients = "Macaroni: This homemade mac and cheese starts with a box of uncooked macaroni noodles.\r\n· Butter and flour: You'll need butter and flour to make a roux for the cheese sauce. You'll also need two tablespoons of butter for the topping.\r\n· Milk: Use whole milk for the richest flavor and texture.\r\n· Cheese: This baked mac and cheese recipe calls for Cheddar and Parmesan cheeses.\r\n· Seasonings: Salt and pepper goes into the sauce, while paprika is sprinkled over the topping.\r\n· Bread crumbs: Use store-bought dried bread crumbs or make your own at home.",
                Description = "Boil the pasta, drain.\r\nMake the cheese sauce by combining a fat (butter), and starch (flour), then whisking in the milk products.\r\nCook the sauce until it’s nice and thick.\r\nAdd in shredded cheeses, stir well.\r\nCombine cheese sauce with cooked pasta.\r\nTransfer half of the mac and cheese to a baking dish, sprinkle with more shredded cheese.\r\nTop with the rest of the mac and cheese, top with more shredded cheese.\r\nBake and prepare to thoroughly enjoy!",
                Images = new()
                {
                    "https://joyfoodsunshine.com/wp-content/uploads/2019/04/homemade-mac-and-cheese-recipe-1.jpg"
                }



            },

            new()
            {
                Name = " Pasta",
                TotalTime = "30 min",
                Ingredients = "Penne pasta\r\n Yellow onion\r\n Cloves garlic\r\n Olive oil\r\n Can diced tomatoes\r\n Dried oregano\r\n Dried basil\r\n Crushed red pepper\r\n Salt\r\nfreshly cracked black pepper to taste ($0.03)\r\n Tomato paste\r\n Cream cheese\r\n grated Parmesan\r\n Fresh spinach",
                Description= "Bring a large pot of water to a boil over high heat. Add the pasta and continue to boil until tender (7-10 minutes). Drain the pasta in a colander.\r\nWhile the pasta is cooking, prepare the creamy tomato sauce. Dice the onion and mince the garlic. Add the onion, garlic, and olive oil to a large skillet and sauté over medium heat until the onions are soft and translucent (3-5 minutes).\r\nAdd the diced tomatoes (with juices), oregano, basil, crushed red pepper, salt, and some freshly cracked pepper to the skillet. Stir to combine. Add the tomato paste and a 1/2 cup of water to the skillet and stir until the tomato paste has mixed into the sauce.\r\nTurn the heat down to low. Cut the cream cheese into a few pieces and then add them to the skillet with the tomato sauce. Use a whisk to stir the sauce until the cream cheese has fully melted and the sauce is creamy. Add the Parmesan to the skillet and stir until it is melted into the sauce.\r\nAdd the fresh spinach to the skillet and gently stir it into the sauce until it has wilted (2-3 minutes). Add the pasta and stir until it is well coated in the creamy tomato sauce. Taste and adjust the salt and pepper as needed. Serve warm.",
                Images = new()
                {
                    "https://www.budgetbytes.com/wp-content/uploads/2013/07/Creamy-Tomato-Spinach-Pasta-V2-bowl.jpg"
                }



            },

            new()
            {
                Name = " Teriyaki Chicken",
                TotalTime = "15 min",
                Ingredients = " Chicken breasts\r\n Olive oil\r\n Low-sodium soy sauce\r\n Honey\r\n Brown sugar:\r\n Rice vinegar. Even lemon juice can be used in a pinch.\r\n Sesame oil\r\n Ginger",
                Description = " Heat oil in a large non-stick skillet or wok.\r\n Add chicken and let cook (giving space between pieces) until slightly browned on bottom then flip chicken pieces over and cook through.\r\n While the chicken is cooking whisk together the teriyaki sauce mixture.\r\n Pour sauce into the skillet once the chicken is just nearly finished cooking through and let the sauce cook and simmer until thickened.\r\n Easy as that! Serve it warm over brown or white rice with steamed veggies.",
                Images = new()
                {
                    "https://www.cookingclassy.com/wp-content/uploads/2018/04/teriyaki-chicken-6.jpg"
                }



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
