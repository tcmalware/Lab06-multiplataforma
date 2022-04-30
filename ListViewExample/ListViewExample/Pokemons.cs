using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class Pokemons
    {
        public string Tipo { get; set; }
        public string Peso { get; set; }
        public string DisplayName
        {
            get
            {
                return $" tipo:{Tipo}, \n peso :{Peso}";
            }
        }
    }
}