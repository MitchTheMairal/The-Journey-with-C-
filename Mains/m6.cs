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
        //     int Correct_Answer_Count = 0;
        //     int Incorrect_Answer_Count = 0;

        //     // Console.WriteLine(Chosen_Ingredient);

        //     Console.WriteLine("\n" + "------------------------------------------------");
        //     Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //     Console.WriteLine("------------------------------------------------" + "\n");

        //     Console.WriteLine((Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //     Console.WriteLine("------------------------------------------------" + "\n" + "Enter \"Stop\" if you want to end or stop the game." + "\n");

        //     string Chosen_Answer = Console.ReadLine();

        //     /*
        //     Continue the game and add 1 to the correct count if the answer is correct.
        //     This will also reset the incorrect count if you get the ingredient correct.
        //     */
        //     while (Chosen_Ingredient == Chosen_Answer)
        //     {
        //         Correct_Answer_Count++;
        //         switch (Incorrect_Count)
        //         {
        //             case 0:
        //                 Incorrect_Count = 0;
        //                 break;
        //             default:
        //                 Incorrect_Count--;
        //                 break;
        //         }

        //         Chosen_Ingredient = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Incorrect_Answer_1 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_2 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_3 = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Correct_Answer_Position = Positions[_Random_.Next(Positions.Length)];

        //         // Console.WriteLine(Chosen_Ingredient);

        //         Console.WriteLine("\n" + "Correct. The Ingredient is " + Chosen_Ingredient + ".\n" + "You have " + Correct_Answer_Count + " questions answered correctly.");

        //         Console.WriteLine("\n" + "------------------------------------------------");
        //         Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //         Console.WriteLine("------------------------------------------------");

        //         Console.WriteLine((Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //         Chosen_Answer = Console.ReadLine();
        //     }

        //     /*
        //     Continue and add 1 to the incorrect count if the answer is incorrect.
        //     If the incorrect count is equals to 3, the game will end.
        //     */
        //     while (Chosen_Ingredient != Chosen_Answer)
        //     {
        //         // Stop the game if the answer that was left is "Stop"
        //         if (Chosen_Answer == "Stop")
        //         {
        //             Console.WriteLine("Game has been cancelled. You have answered " + Correct_Answer_Count + " questions correctly, and " + Incorrect_Answer_Count + " questions incorrectly.");
        //             break;
        //         }
        //         if (Incorrect_Count == 3) // Incorrect 3 Times
        //         {
        //             Console.WriteLine("\n" + "Game Over. You have answered " + Correct_Answer_Count + " questions correctly, and " + (Incorrect_Answer_Count + 1) + " questions answered incorrectly.");
        //             break;
        //         }

        //         Incorrect_Count++;
        //         Incorrect_Answer_Count++;

        //         Chosen_Ingredient = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Incorrect_Answer_1 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_2 = Ingredients[_Random_.Next(Ingredients.Length)];
        //         Incorrect_Answer_3 = Ingredients[_Random_.Next(Ingredients.Length)];

        //         Correct_Answer_Position = Positions[_Random_.Next(Positions.Length)];

        //         // Console.WriteLine(Chosen_Ingredient);

        //         Console.WriteLine("\n" + "Incorrect. The Ingredient is " + Chosen_Ingredient + ".\n" + "You have " + Incorrect_Answer_Count + " questions answered incorrectly.");

        //         Console.WriteLine("\n" + "------------------------------------------------");
        //         Console.WriteLine("An Ingredient has been chosen, pick your answer.");
        //         Console.WriteLine("------------------------------------------------");

        //         Console.WriteLine((Correct_Answer_Position == 1 ? Chosen_Ingredient : Incorrect_Answer_1) + " | " + (Correct_Answer_Position == 2 ? Chosen_Ingredient : Incorrect_Answer_2) + " | " + (Correct_Answer_Position == 3 ? Chosen_Ingredient : Incorrect_Answer_3) + "\n");

        //         Chosen_Answer = Console.ReadLine();
        //     }
        // }
    }
}