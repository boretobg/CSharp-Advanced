using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Collection { get; set; }

        public Trainer()
        {

        }
        public Trainer(string name, int badge, List<Pokemon> collection)
        {
            this.Name = name;
            this.Badges = badge;
            this.Collection = collection;
        }
    }
}
