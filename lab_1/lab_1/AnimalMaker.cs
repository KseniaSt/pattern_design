using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    abstract class AnimalMaker
    {
        public Animal Animal { get; set; }
        public void CreateAnimal()
        {
            Animal = new Animal();
        }
        public abstract void SetFood(string a);
        public abstract void SetAge(string a);
    }
}
