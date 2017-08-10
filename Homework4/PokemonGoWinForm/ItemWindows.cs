using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonGo.Core;

namespace PokemonGoWinForm
{
    public partial class ItemsWindow : Form
    {
        public Potion[] Potions;
        public int SelectedPotionIndex = -1;
        public Pokemon[] Pokemons;
        public int SelectedPokemonIndex = -1;

        public ItemsWindow()
        {
            InitializeComponent();

            Potions = new Potion[]
            {
                new Potion()
                {
                    Name = "Potion",
                    Description = "傷藥，可以回復20生命",
                    RestoringHP = 20,
                    Count = 28
                },

                new Potion()
                {
                    Name = "Super Potion",
                    Description = "好傷藥，可以回復50生命",
                    RestoringHP = 50,
                    Count = 34
                },

                new Potion()
                {
                    Name = "Hyper Potion",
                    Description = "超級傷藥，可以回復200生命",
                    RestoringHP = 200,
                    Count = 44
                }
            };

            Pokemons = new Pokemon[]
            {
                new Pokemon()
                {
                    Name = "妙蛙種子",
                    HP = 200,
                    CurrentHP = 30,
                },

                new Pokemon()
                {
                    Name = "妙蛙草",
                    HP = 250,
                    CurrentHP = 230,
                }
            };

            Render();
        }

        private void Render()
        {
            PotionLabel.Text = string.Format("{0},{1}, X{2}"
                , Potions[0].Name
                , Potions[0].Description
                , Potions[0].Count);
            SuperPotionLabel.Text = string.Format("{0},{1}, X{2}"
                , Potions[1].Name
                , Potions[1].Description
                , Potions[1].Count);
            HyperPotionLabel.Text = string.Format("{0},{1}, X{2}"
                , Potions[2].Name
                , Potions[2].Description
                , Potions[2].Count);

            Pokemon1Label.Text = string.Format("{0}, HP{1}/{2}"
                , Pokemons[0].Name
                , Pokemons[0].CurrentHP
                , Pokemons[0].HP);

            Pokemon2Label.Text = string.Format("{0}, HP{1}/{2}"
                , Pokemons[1].Name
                , Pokemons[1].CurrentHP
                , Pokemons[1].HP);
        }

        private void ChangeColor()
        {
            if (SelectedPotionIndex == 0)
            {
                PotionLabel.BackColor = Color.MistyRose;
                SuperPotionLabel.BackColor = Color.Transparent;
                HyperPotionLabel.BackColor = Color.Transparent;
            }
            else if (SelectedPotionIndex == 1)
            {
                PotionLabel.BackColor = Color.Transparent;
                SuperPotionLabel.BackColor = Color.MistyRose;
                HyperPotionLabel.BackColor = Color.Transparent;
            }
            else if (SelectedPotionIndex == 2)
            {
                PotionLabel.BackColor = Color.Transparent;
                SuperPotionLabel.BackColor = Color.Transparent;
                HyperPotionLabel.BackColor = Color.MistyRose;
            }

            if (SelectedPokemonIndex == 0)
            {
                Pokemon1Label.BackColor = Color.MistyRose;
                Pokemon2Label.BackColor = Color.Transparent;
            }
            else if (SelectedPokemonIndex == 1)
            {
                Pokemon1Label.BackColor = Color.Transparent;
                Pokemon2Label.BackColor = Color.MistyRose;
            }
        }

        private void PotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 0;
            ChangeColor();
        }

        private void SuperPotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 1;
            ChangeColor();
        }

        private void HyperPotionLabel_Click(object sender, EventArgs e)
        {
            SelectedPotionIndex = 2;
            ChangeColor();
        }

        private void Pokemon1Label_Click(object sender, EventArgs e)
        {
            SelectedPokemonIndex = 0;
            Console.WriteLine("SelectedPokemonIndex = 0");
            ChangeColor();
        }

        private void Pokemon2Label_Click(object sender, EventArgs e)
        {
            SelectedPokemonIndex = 1;
            Console.WriteLine("SelectedPokemonIndex = 1");
            ChangeColor();
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            if (Pokemons[SelectedPokemonIndex] != null || Potions[SelectedPotionIndex] != null)
            {
                if ((Pokemons[SelectedPokemonIndex].CurrentHP + Potions[SelectedPotionIndex].RestoringHP) <= Pokemons[SelectedPokemonIndex].HP && Potions[SelectedPotionIndex].Count >= 1)
                {
                    Pokemons[SelectedPokemonIndex].CurrentHP
                    += Potions[SelectedPotionIndex].RestoringHP;

                    Potions[SelectedPotionIndex].Count--;
                }
                else if ((Pokemons[SelectedPokemonIndex].CurrentHP + Potions[SelectedPotionIndex].RestoringHP) > Pokemons[SelectedPokemonIndex].HP && Pokemons[SelectedPokemonIndex].CurrentHP < Pokemons[SelectedPokemonIndex].HP && Potions[SelectedPotionIndex].Count >= 1)
                {
                    Pokemons[SelectedPokemonIndex].CurrentHP = Pokemons[SelectedPokemonIndex].HP;

                    Potions[SelectedPotionIndex].Count--;
                }
                else
                    Pokemons[SelectedPokemonIndex].CurrentHP = Pokemons[SelectedPokemonIndex].HP;

                Render();
            }
        }
    }
}