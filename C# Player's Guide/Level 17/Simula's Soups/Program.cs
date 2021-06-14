using System;

namespace Simula_s_Soups
{
    class Program
    {
        static void Main(string[] args)
        {
            (int type, int ingredient, int seasoning)[] soups = new (int, int, int)[3];
            
            // Add new soups (can't assign values with a foreach which is 'read-only')
            for(int i = 0;i < soups.Length; i++)
            {
                soups[i] = AddSoup();
            }
            // Display soups
            foreach (var i in soups) DisplaySoup(i);
        }

        static (int type, int ingredient, int seasoning) AddSoup()
        {
            (int type, int ingredient, int seasoning) soupParam;

            Console.WriteLine("What type of soup are you preparing?\n1.Soup\n2.Stew\n3.Gumbo");
            soupParam.type = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What ingredient are you putting in this soup?\n1.Mushrooms\n2.Chicken\n3.Carrots\n4.Potatoes");
            soupParam.ingredient = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What kinf of seasoning are you putting on this soup?\n1.Spicy\n2.Salty\n3.Sweet");
            soupParam.seasoning = Convert.ToInt32(Console.ReadLine());

            return soupParam;
        }

        static void DisplaySoup((int type, int ingredient, int seasoning) soup)
        {
            string strType, strIngredient, strSeasoning;
            strType = strIngredient = strSeasoning = "";
            // Type
            switch (soup.type)
            {
                case (int)FoodType.Soup:
                    strType = "Soup";
                    break;
                case (int)FoodType.Stew:
                    strType = "Stew";
                    break;
                case (int)FoodType.Gumbo:
                    strType = "Gumbo";
                    break;
            }

            // Ingredient
            switch (soup.ingredient)
            {
                case (int)Ingredient.Mushrooms:
                    strIngredient = "Mushrooms";
                    break;
                case (int)Ingredient.Chicken:
                    strIngredient = "Chicken";
                    break;
                case (int)Ingredient.Carrots:
                    strIngredient = "Carrots";
                    break;
                case (int)Ingredient.Potatoes:
                    strIngredient = "Potatoes";
                    break;
            }

            // Seasoning
            switch (soup.seasoning)
            {
                case (int)Seasoning.Spicy:
                    strSeasoning = "Spicy";
                    break;
                case (int)Seasoning.Salty:
                    strSeasoning = "Salty";
                    break;
                case (int)Seasoning.Sweet:
                    strSeasoning = "Sweet";
                    break;
            }

            // Display
            Console.WriteLine($"{strSeasoning} {strIngredient} {strType}");
        }

        // Enums
        enum FoodType
        {
            Soup = 1, // makes the list start at 1 instead of 0
            Stew,
            Gumbo
        }
        enum Ingredient
        {
            Mushrooms = 1,
            Chicken,
            Carrots,
            Potatoes
        }
        enum Seasoning
        {
            Spicy = 1,
            Salty,
            Sweet
        }
    }
}
