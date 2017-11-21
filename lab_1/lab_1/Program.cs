using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{ 



class Program
    {
       
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите возраст: ");
            string ageAnimal = Console.ReadLine();
            Console.WriteLine("Введите норму еды (кг/день): ");
            string foodAnimal = Console.ReadLine();

            Console.WriteLine("Введите 1 - создать волнистого папугая, 2 - создать крокодила, 3 - создать панду");
            int caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");

                    
                    Maker maker = new Maker();
                    AnimalMaker AnimalMaker = new ParrotAnimalMaker();
                    Animal parrot = maker.Make(AnimalMaker, ageAnimal);
                    Console.WriteLine(parrot.ToString());
                Console.Read();
            
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