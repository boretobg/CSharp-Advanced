using System;
using System.Collections;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var effect = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var casing = Console.ReadLine().Split(", ").Select(int.Parse).ToList();


            int daturaBomb = 0;
            int cherryBomb = 0;
            int smokeBomb = 0;
            bool hasFilled = false;

            while (effect.Count != 0 && casing.Count != 0)
            {
                if (daturaBomb >= 3 && cherryBomb >= 3 && smokeBomb >= 3)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    hasFilled = true;
                    break;
                }

                if (effect[0] + casing[casing.Count - 1] == 40)
                {
                    daturaBomb++;
                }
                else if (effect[0] + casing[casing.Count - 1] == 60)
                {
                    cherryBomb++;
                }
                else if (effect[0] + casing[casing.Count - 1] == 120)
                {
                    smokeBomb++;
                }
                else
                {
                    if (casing[casing.Count - 1] <= 0)
                    {
                        casing.RemoveAt(casing.Count - 1);
                    }
                    else
                    {
                        casing[casing.Count - 1] -= 5;
                    }
                    continue;
                }
                effect.RemoveAt(0);
                casing.RemoveAt(casing.Count - 1);
            }

            if (!hasFilled)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }


            if (effect.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            
            if (casing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            Console.WriteLine($"Cherry Bombs: {cherryBomb}\nDatura Bombs: {daturaBomb}\nSmoke Decoy Bombs: {smokeBomb}");
        }
    }
}
