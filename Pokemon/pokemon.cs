  
using System;
using System.Collections.Generic;

namespace Pokedex
{
    public
    class Pokemon
    {
        protected string Name;

        protected int ID;
        //hacer una lista de pokemon con genero (no confindir a pokemon sin genero)


        public Pokemon(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }

    }
}