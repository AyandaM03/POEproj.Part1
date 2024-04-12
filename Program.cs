using System;

namespace RecipeApplication
{
    class Recipe
    {
        // Variables to store recipe details
        private string[] ingredients;
        private string[] units;
        private double[] quantities;
        private string[] steps;

        // Constructor for the arrays
        public Recipe()
        {
            ingredients = new string[0];
            units = new string[0];
            quantities = new double[0];
            steps = new string[0];
        }

        // Method to add the ingredients
        public void AddIngredient(string ingredient, string unit, double quantity)
        {
            Array.Resize(ref ingredients, ingredients.Length + 1);
            Array.Resize(ref units, units.Length + 1);
            Array.Resize(ref quantities, quantities.Length + 1);

            int index = ingredients.Length - 1;
            ingredients[index] = ingredient;
            units[index] = unit;
            quantities[index] = quantity;
        }

        // Methods to add steps
        public void AddStep(string step)
        {
            Array.Resize(ref steps, steps.Length + 1);
            steps[steps.Length - 1] = step;
        }

        // Methods to display the recipe
        public void DisplayRecipe(string title)
        {
            Console.WriteLine($"{title}:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        // Method to scale the recipe by a factor
        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }
        }

        // Method to resetthe  quantities to original values
        public void ResetQuantities()
        {
           
        }

        // Method to clear all the data
        public void ClearData()
        {
            ingredients = new string[0];
            units = new string[0];
            quantities = new double[0];
            steps = new string[0];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            // Adding ingredients to the original recipe
            recipe.AddIngredient("Sugar", "teaspoon", 1);
            recipe.AddIngredient("Tomato Sauce", "cup", 2);
            recipe.AddIngredient("Grated Carrot", "cup", 3);
            recipe.AddIngredient("Koo canned baked beans", "can", 3);
            recipe.AddIngredient("Spices of choice", "teaspoon", 4);
            recipe.AddIngredient("Chopped onions and peppers", "cup", 2);

            // Adding steps to the original recipe
            recipe.AddStep("Add oil to a pan and fry the onions and peppers till brown");
            recipe.AddStep("Add grated carrots and season with the sugar and spices you choose");
            recipe.AddStep("Pour the tomato sauce and koo baked beans and let the chakalaka simmer for 15 minutes");

            // Displaying the original recipe
            recipe.DisplayRecipe("Original Recipe");

            // Scaled recipe (0.5-3)
            recipe.ScaleRecipe(0.5);

            // Displaying the scaled recipe
            Console.WriteLine("\nScaled Recipe:");
            recipe.DisplayRecipe("Scaled Recipe");
        }
    }
}

