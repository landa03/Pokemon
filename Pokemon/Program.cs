using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Program
    {
        private static Dictionary<int, string> dict;
        private static void Add(int keye, string value)
        {
            if (!dict.ContainsKey(keye))
            {
                dict.Add(keye, value)
            }
        }
        static void Main(string[] args)
        {   
            dict = new Dictionary<int, string>();

            Dictionary<int, string> pokemon = new Dictionary<int, string>();

         pokemon.Add(1, "Bulbasaur");
         pokemon.Add(2, "Ivysaur");
         pokemon.Add(3, "Venusaur");
         pokemon.Add(4, "Carmander");
         pokemon.Add(5, "Charmeleon");
         pokemon.Add(7, "Squirtle");
         pokemon.Add(8, "Warturtle");
         pokemon.Add(9, "Blastoise");
         pokemon.Add(10, "Caterpie");

            int pokemoN = pokemon.GetValueOrDefault(1,"Bulbasaur");
            int[] IDs = new int [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int ID in IDs)
            {
                System.Console.WriteLine(ID);
            }
            foreach (string key in pokemon.Keys)
            {
                System.Console.WriteLine(key);
            }
            // estoy intentando que me diga un nombre al darle un numero
            System.Console.WriteLine(pokemon.Values);
        }
    }
    //con esto declaro un nuevo tipo de valor
    // public enum Gender
    // {
    //     Male,
    //     Female
    // }
    //se usa (Gender pokeGender = Gender.Female)
}
//nomas no pude entender como se usa el dictionnary