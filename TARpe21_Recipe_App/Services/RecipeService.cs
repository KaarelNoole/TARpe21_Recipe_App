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
                TotalTime = " Time to make - 30 min",
                Ingredients = "Chicken\r\n bell pepper\r\n onion\r\n lime juice and spices\r\n plus tortillas and your favorite toppings.",
                Description = "1. Season the chicken. Generously sprinkle the fajita seasoning on both sides of the chicken and use your fingers to press it in.\r\n 2. Cook the chicken. Heat a large skillet over medium heat and lightly coat it with a drizzle of olive oil or avocado oil. Sear the chicken breasts for about 7-8 minutes on each side. Then remove them from the pan and let them rest for a few minutes before slicing into strips.\r\n 2. Saute the bell peppers and onion. While the chicken is cooking, cut the bell peppers and onions into thin slices. Then saute them in the same skillet over medium heat for a few minutes until caramelized. You’re essentially making fajita veggies.\r\n 3. Mix together. Add the chicken back into the skillet, squeeze fresh lime juice on top and stir everything together.\r\n 4. Wrap it up. Serve immediately with tortillas and extra toppings."
,

            },

            new()
            {
                Name = " Lasagne",
                HeroImage="lasagne.jpg",
                TotalTime = " Time to make - 3 hrs 15 mins",
                Ingredients = "2 teaspoons extra virgin olive oil\r\n 1 pound ground beef chuck\r\n 1/2 medium onion, diced (about 3/4 cup)\r\n 1/2 large bell pepper (green, red, or yellow), diced (about 3/4 cup)\r\n 2 cloves garlic, minced\r\n 1 can good-quality tomato sauce\r\n 3 ounces tomato paste (half a 6-ounce can)\r\n 1 (14 ounce) can crushed tomatoes\r\n2 tablespoons chopped fresh oregano, or 2 teaspoons dried oregano\r\n 1/4 cup chopped fresh parsley (preferably flat leaf), packed\r\n 1 tablespoon Italian seasoning\r\n 1 pinch garlic powder and/or garlic salt\r\n 1 tablespoon red or white wine vinegar\r\n 1 tablespoon to 1/4 cup sugar (to taste, optional)\r\n Salt",
                Description = "1. This recipe uses store-bought sauce (make sure you get one you love). There are just three components that make a lasagna great: the pasta, the cheese, and the sauce. Since this recipe starts with a jar of marinara for ease, make sure it’s one that tastes great. My favorite brand is Rao’s, but choose your personal favorite.\r\n 2. The lasagna noodles cook right in the sauce. Since the noodles aren’t pre-boiled, they’ll cook from the heat and steam in the oven. It’s important that they’re completely covered in the sauce so they cook evenly. A dry corner will result in a crunchy, un-cooked corner.\r\n 3. The lasagna can (and should) rest before eating. Like all lasagnas, this one is great made ahead, and actually will be better made a little ahead of eating. Yes it’s tempting to cut into the lasagna right when you pull it from the oven, but let it rest on a cooling rack for at least 15 minutes. This will help firm up all the layers and make it much easier to slice a square. And of course you can make it a day ahead or in the morning then reheat.",
               
            },

            new()
            {
                Name = " Mac & Cheese",
                HeroImage="macandcheese.jpg",
                TotalTime = " Time to make - 30 min",
                Ingredients = "Macaroni\r\n Salted butter\r\n 3 tablespoons all-purpose flour\r\n2 ½ cups milk\r\n 2 cups Cheddar cheese\r\n Parmesan cheese\r\n Salt and ground black pepper to taste",
                Description = "1. Boil the pasta, drain.\r\n 2. Make the cheese sauce by combining a fat (butter), and starch (flour), then whisking in the milk products.\r\n 3. Cook the sauce until it’s nice and thick.\r\n 4. Add in shredded cheeses, stir well.\r\n 5. Combine cheese sauce with cooked pasta.\r\n 6. Transfer half of the mac and cheese to a baking dish, sprinkle with more shredded cheese.\r\n 7. Top with the rest of the mac and cheese, top with more shredded cheese.\r\n 8. Bake and prepare to thoroughly enjoy!",
                Images = new()
               
            },

            new()
            {
                Name = " Pasta",
                HeroImage="pasta.jpg",
                TotalTime = " Time to make -30 min",
                Ingredients = "Pasta\r\n Onion\r\n Garlic\r\n Olive oil\r\n Tomatoes\r\n Oregano\r\n Dried Basil\r\n Pepper\r\n Salt\r\n Tomato paste\r\n Grated Cheese & Parmesan\r\n grated Parmesan\r\n Fresh spinach",
                Description = "1. Heat the oil in a non-stick pan over a medium-low heat. Add the onion along with a generous pinch of salt and fry for 10 mins, or until soft. Add the garlic and chilli, if using, and cook for a further minute.\r\n 2. Stir the tomatoes, anchovies, olives and capers into the onion, bring to a gentle simmer and cook, uncovered, for 15 mins. Season to taste.\r\n 3. Meanwhile, bring a large pan of salted water to the boil. Cook the spaghetti following pack instructions, then drain and toss with the sauce and parsley."

            },

            new()
            {
                Name = " Teriyaki Chicken",
                HeroImage="chickenteriyaki.jpg",
                TotalTime = " Time to make - 15 min",
                Ingredients = " Chicken breasts\r\n Olive oil\r\n Low-sodium soy sauce\r\n Honey\r\n Brown sugar:\r\n Rice vinegar. Even lemon juice can be used in a pinch.\r\n Sesame oil\r\n Ginger",
                Description = "1. Heat oil in a large non-stick skillet or wok.\r\n 2. Add chicken and let cook (giving space between pieces) until slightly browned on bottom then flip chicken pieces over and cook through.\r\n 3. While the chicken is cooking whisk together the teriyaki sauce mixture.\r\n 4. Pour sauce into the skillet once the chicken is just nearly finished cooking through and let the sauce cook and simmer until thickened.\r\n 5. Easy as that! Serve it warm over brown or white rice with steamed veggies.",
              
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
