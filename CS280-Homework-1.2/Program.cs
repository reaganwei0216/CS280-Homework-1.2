using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.height = 5.03f;
            pokemon.weight = 80.7f;
            pokemon.Category = "Arrow Quill";
            pokemon.Abilities = "Overgrow";
            pokemon.Gender = "unknown";
            Console.WriteLine("Height:{0}meters, Weight:{1}tons, Category:{2}, Ability:{3}, Gender:{4}", pokemon.height, pokemon.weight, pokemon.Category, pokemon.Category, pokemon.Gender);
        }
    }
}