using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{

    class Maker
    {
        public Animal Make(AnimalMaker animalMaker, string a, string b)
        {
            animalMaker.CreateAnimal();
            animalMaker.SetAge(a);
            animalMaker.SetFood(b);
            return animalMaker.Animal;
        }

    }
}
