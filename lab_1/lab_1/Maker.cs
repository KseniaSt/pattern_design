using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Maker
    {
            public Animal Make(AnimalMaker animalMaker, string n, string s)
            {
                animalMaker.SetFood(n);
                animalMaker.SetAge(s);
                return animalMaker.Animal;
            }

    }
}
