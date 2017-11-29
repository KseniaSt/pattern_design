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

            Console.WriteLine("Введите 1 - создать волнистого папугая, 2 - создать крокодила, 3 - создать панду");
            int caseSwitch = int.Parse(Console.ReadLine());
            Maker maker = new Maker();

            Console.WriteLine("Введите возраст: ");

            string ageAnimal = Console.ReadLine();
            Console.WriteLine("Введите норму еды (кг/день): ");
            string foodAnimal = Console.ReadLine();

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("\nCоздан волнистый папугай");
                    AnimalMaker AnimalMaker = new ParrotAnimalMaker();
                    Animal parrot = maker.Make(AnimalMaker, ageAnimal, foodAnimal);
                    Console.WriteLine(parrot.ToString());         
                break;
                case 2:
                    Console.WriteLine("\nCоздан крокодил");
                    AnimalMaker AnimalMaker2 = new CrocoAnimalMaker();
                    Animal croco = maker.Make(AnimalMaker2, ageAnimal, foodAnimal);
                    Console.WriteLine(croco.ToString());
                    break;
                case 3:
                    Console.WriteLine("\nCоздана панда");
                    AnimalMaker AnimalMaker3 = new PandaAnimalMaker();
                    Animal panda = maker.Make(AnimalMaker3, ageAnimal, foodAnimal);
                    Console.WriteLine(panda.ToString());
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
          
            Console.Read();
        }
    }
    
}