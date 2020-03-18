using System;
using System.Collections.Generic;

namespace Pokedex
{
    public enum Gender
    {
        MALE,
        FEMAEL
    }
    class PokemonInPartey : Pokemon
    {
       //es lo mismo que un poquemon de la poquedex pero con genero
       Gender gender;
       
        public PokemonInPartey(string Name, int ID, Gender gender) : base(Name, ID)
        {
            System.Console.WriteLine("nacio un pokemon");
            
            this.gender = gender;
        }
        
    }
}