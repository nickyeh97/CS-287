using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.Core
{
    public class Pokemon
    {
        public string Name;
        public int HP;
        public int CurrentHP;
    }

    public class Potion
    {
        public string Name;
        public string Description;
        public int RestoringHP;
        public int Count;
    }
}