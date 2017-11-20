using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Color
    {
        public string NameColor { get; set; }
    }

    class Food
    {
        public string DayFood { get; set; }
    }

    class Animal
    {
        public Color Color { get; set; }
        public Food Food { get; set; }
    }

    abstract class AnimalMaker : Maker
    {
        public Animal Animal { get; private set; }
        public void CreateAnimal()
        {
            Animal = new Animal();
        }
        public abstract void SetFood(string s);
        public abstract void SetAge(string n);
    }
}
