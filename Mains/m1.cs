// C# if and else statements - 5/31/21; May 31, 2021

using System;

namespace Rune_The_Unknown
{
    public class Program {
        public static void Main(string[] args)
        {
            Console.WriteLine("[ Mitch, Mallo, Luna, Nicky ]");
            Console.Write("Who should i meet up with? ");
            string OC = Console.ReadLine();

            if (OC.ToLower() == "mitch")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Rune: Heya Mitch.\nMitch: Heya! *Smacks*\nRune: A-");
            }
            else if (OC.ToLower() == "mallo")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Rune: Hi Mallo.\nMallo: Hai Rune.\nRune and Mallo: *Does their secret handshake*");
            }
            else if (OC.ToLower() == "luna")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Rune: Hi Luna, now stay away-\nLuna: You've chosen death, Rune.\nRune: *Armanent-Metal hardens* I swear to god, Luna.");
            }
            else if (OC.ToLower() == "nicky")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Rune: Hi Nicky.\nNicky: Sup, now get to the point.\nRune: Let's go beat and cut. *Armanent-Metal leaking*\nNicky: Nice, i'm down. *Grabs katana*");
            }
            else if (OC.ToLower() == "rune")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Rune: Hi self.\n----------[ Silence ]----------");
            }
            else if (OC.ToLower().Contains("idk"))
            {
                Console.WriteLine("Rune: Mk.");
            }
            else
            {
                Console.WriteLine("Rune: Stranger danger mate.");
            }
        }
    }
}