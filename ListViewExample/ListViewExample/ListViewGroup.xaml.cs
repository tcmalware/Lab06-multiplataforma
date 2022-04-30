using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<PokemonGroup> listPokemons = new ObservableCollection<PokemonGroup>();
        public ObservableCollection<PokemonGroup> ListPokemon { get { return listPokemons; } }
        public ListViewGroup()
        {
            InitializeComponent();
            ViewPokemon.ItemsSource = listPokemons;
            listPokemons.Add(new PokemonGroup("Bulbasaur", new[] {
            new Pokemons
            {
                Tipo = "Planta",
                Peso = "6,9 Kg"
            }
            }));
            listPokemons.Add(new PokemonGroup("Charmander", new[] {
            new Pokemons
            {
                Tipo = "Fuego",
                Peso = "8,5 Kg"
            }
            }));
            listPokemons.Add(new PokemonGroup("Squirtle", new[] {
            new Pokemons
            {
                Tipo = "Agua",
                Peso = "9,0 Kg"
            }
            }));
            listPokemons.Add(new PokemonGroup("Pikachu", new[] {
            new Pokemons
            {
                Tipo = "Eléctrico",
                Peso = "6,0 Kg"
            }
            }));
        }
    }
}