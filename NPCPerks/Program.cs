using System;

namespace NPCPerks
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables
            int numNPCs;
            Perks[] npcPerks;

            // Ask for the number of NPCs
            Console.Write("How many NPC? ");
            numNPCs = int.Parse(Console.ReadLine());

            // Create the array of NPC perks
            npcPerks = new Perks[numNPCs];

            // For each NPC, ask for its perks
            for (int i = 0; i < numNPCs; i++)
            {
                // User input
                string input;

                // Stealth?
                Console.Write($"Does NPC {i} has stealth (y/i)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[i] |= Perks.Stealth;
                }

                // Combat?
                Console.Write($"Does NPC {i} has combat (y/i)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[i] |= Perks.Combat;
                }

                // Lockpick?
                Console.Write($"Does NPC {i} has lockpick (y/i)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[i] |= Perks.Lockpick;
                }

                // Luck?
                Console.Write($"Does NPC {i} has luck (y/i)? ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[i] |= Perks.Luck;
                }
            }

            // Show on screen the perks of all NPCs
            // If NPC has Combat & Luck print special message
            foreach (Perks perks in npcPerks)
            {
                Perks special = Perks.Combat | Perks.Luck;
                Console.WriteLine($"NPC has {perks}");
                if ((perks & special) == special)
                {
                    Console.WriteLine("\tYou shall win all fights");
                }
            }
        }
    }
}