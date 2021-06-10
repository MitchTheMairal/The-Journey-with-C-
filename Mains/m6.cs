// C# - Basic Infinite Multi-choice Game | Guess The Ingredient ~ 6/10/21; June 10, 2021

using System;

namespace Guess_The_Ingredient
{
    public class Favorite_2 {
        // public static void Main(string[] args)
        // {
        //     var _Random_ = new Random();

        //     string[] Ingredients = {
        //         "Aurora Bark", "Syvia Bark", "Glitter Fruit", "Mythical Wing",
        //         "Airaial Leaf", "Mithril", "Iron", "Jade", "Ruby", "Stone",
        //         "Seraphrite", "Pixel Shard", "Remolight Shard",
        //         "Runarphic Shard", "Amber", "Amber Shard", "Split Shroom",
        //         "Seashroom", "Gloo Shroom", "Bloodshroom", "Float Shroom",
        //         "Blow Core", "Cloudball", "Rainball", "Hole Bark", "Floader",
        //         "Cloudshroom", "Glimmer Kelp", "Mirthbloom", "Mirth Stem"
        //     };
        //     string Chosen_Ingredient = Ingredients[_Random_.Next(Ingredients.Length)];

        //     string Incorrect_Answer_1 = Ingredients[_Random_.Next(Ingredients.Length)];
        //     string Incorrect_Answer_2 = Ingredients[_Random_.Next(Ingredients.Length)];
        //     string Incorrect_Answer_3 = Ingredients[_Random_.Next(Ingredients.Length)];

        //     int[] Positions = { 1, 2, 3 };
        //     int Correct_Answer_Position = Positions[_Random_.Next(Positions.Length)];

        //     int Incorrect_Count = 0;
        //     int Correct_Count = 0;

        //     // Console.WriteLine(Chosen_Ingredient);

        //     Console.WriteLine("\n------------------------------------------------");
        //     Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //     Console.WriteLine("------------------------------------------------");

        //     Console.WriteLine("A) " + (Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | B) " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | C) " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //     string Chosen_Answer = Console.ReadLine();

        //     /*
        //     Continue the game and add 1 to the correct count if the answer is correct.
        //     This will also reset the incorrect count if you get the ingredient correct.
        //     */
        //     while (Chosen_Ingredient == Chosen_Answer) {
        //         Chosen_Ingredient = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Incorrect_Answer_1 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_2 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_3 = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Correct_Answer_Position = Positions[_Random_.Next(Positions.Length)];

        //         // Console.WriteLine(Chosen_Ingredient);

        //         Console.WriteLine("Correct.");

        //         Console.WriteLine("\n------------------------------------------------");
        //         Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //         Console.WriteLine("------------------------------------------------");

        //         Console.WriteLine("A) " + (Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | B) " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | C) " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //         Chosen_Answer = Console.ReadLine();

        //         Correct_Count++;
        //         Incorrect_Count = 0;
        //     }

        //     /*
        //     Continue and add 1 to the incorrect count if the answer is incorrect.
        //     If the incorrect count is equals to 3, the game will end.
        //     */
        //     while (Chosen_Ingredient != Chosen_Answer)
        //     {
        //         if (Incorrect_Count >= 2) // Incorrect 3 Times
        //         {
        //             Console.WriteLine("\nGame Over. You've answered " + Correct_Count + " questions correctly.");
        //             break;
        //         }

        //         Chosen_Ingredient = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Incorrect_Answer_1 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_2 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_3 = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Correct_Answer_Position = Positions[_Random_.Next(Positions.Length)];

        //         // Console.WriteLine(Chosen_Ingredient);

        //         Console.WriteLine("\n------------------------------------------------");
        //         Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //         Console.WriteLine("------------------------------------------------");

        //         Console.WriteLine("A) " + (Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | B) " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | C) " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //         Chosen_Answer = Console.ReadLine();
        //         Incorrect_Count++;
        //     }
        // }
    }
}