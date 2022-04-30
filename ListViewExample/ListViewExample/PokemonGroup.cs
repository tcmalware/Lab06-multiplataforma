using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class PokemonGroup : ObservableCollection<Pokemons>
    {
        public string Pokemones { get; set; }

        public PokemonGroup(string pokemones, IEnumerable<Pokemons> source)
            : base(source)
        {
            Pokemones = pokemones;
        }
    }
}