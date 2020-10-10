using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            var trainers = new List<Trainer>();
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] cmd = input.Split();
                string trainerName = cmd[0];
                string pokemonName = cmd[1];
                string pokemonElement = cmd[2];
                int pokemonHealth = int.Parse(cmd[3]);


                var pokemonList = new List<Pokemon>();
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                pokemonList.Add(pokemon);
                trainer = new Trainer(trainerName, 0, pokemonList);
                trainers.Add(trainer);

                input = Console.ReadLine();
            }

            ;
        }
    }
}
