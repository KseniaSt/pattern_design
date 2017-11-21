using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class ParrotAnimalMaker : AnimalMaker
    {
        public override void SetFood()
        {
            this.Animal.Food = new Food { DayFood = "" };
        }

        public override void SetAge(string a)
        {
            this.Animal.Age = new Age { Years = a};
        }

    }
}
