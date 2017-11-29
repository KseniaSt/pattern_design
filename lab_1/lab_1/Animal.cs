using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Animal
    {
        public Age Age { get; set; }
        public Food Food { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Age != null)
                sb.Append("Возраст: " + Age.Years + " лет" + "\n");
            if (Food != null)
                sb.Append("Дневная норма питания: " + Food.DayFood + "\n");

            return sb.ToString();
        }
    }
    
}
