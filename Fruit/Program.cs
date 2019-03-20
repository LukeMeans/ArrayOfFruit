using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    class Program
    {
        public enum Fruit
        {
            none,
            Pear,
            Apple,
            Orange,
            Kiwi,
            Mango,
            Banana
        }
        static void Main(string[] args)
        {
            //
            // variables
            //
            string userResponse;
            Fruit FavoriteFruit;
            Fruit FruitChoice;

            Fruit[] fruits = new Fruit[6];




            Console.WriteLine("Fruits to choose from:");
            for (int index = 0; index < 6; index++)
            {
                Console.WriteLine($"enter fruit #{index + 1}:");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse,out fruits[index]);
                
            }

            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }
    }
}
