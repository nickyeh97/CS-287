using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            NationalNo = 2;
            Name = "妙蛙草";

            MaxHp = 60;
            MaxHp = base.MaxHp + random.Next(100, 201);
            CurrentHp = MaxHp;

            Height = 1.2f;
            Weight = 6.9f;
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                height = value;
                height += (float)random.NextDouble(-0.1, 1.5);
            }
        }

        public override float Weight
        {
            get => base.Weight;
            set
            {
                weight = value;
                weight += (float)random.NextDouble(-2.5, 2.6);
            }
        }

        public override string ToString()
        {
            return "進化 " + base.ToString();
        }
    }
}