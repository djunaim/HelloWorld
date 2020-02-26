using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!");
            Console.ReadLine();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Cat" };

            foreach (var animal in animals)
            {
                var vowelCount = 0;
                foreach (var currentChar in animal)
                {
                    if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u')
                    {
                        vowelCount += 1;
                    }
                }
                if (vowelCount >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadKey();
                }
            }

            Console.WriteLine($"Please choose one: {args[0]}, {args[1]}, {args[2]}");

            var userEntry = Console.ReadLine();

            if (userEntry == args[0] || userEntry == args[1] || userEntry == args[2])
            {
                Console.WriteLine("you got it");
                Console.ReadLine();
            }
            //if (userEntry != args[0] || userEntry != args[1] || userEntry != args[2])
            else
            {
                Console.WriteLine("try again");
                Console.ReadLine();
            }
        }
    }
}
