using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        Maker maker = new Maker();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст: ");
            int ageAnimal = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите норму еды (кг/день): ");
            int foodAnimal = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 1 - создать волнистого папугая, 2 - создать крокодила, 3 - создать панду");
            int caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;

            }
            Console.Read();
        }
    }
}
    

