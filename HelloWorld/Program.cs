using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Howdy Y'all!");
            //Console.ReadLine();

            //Console.WriteLine("Hi, write your name and press enter");
            //var userName = Console.ReadLine();
            //Console.WriteLine($"Hi, {userName}");
            //Console.ReadLine();

            //Console.WriteLine($"{userName}, what is your favorite color?");
            //var userColor = Console.ReadLine();

            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Cat" };

            //foreach (var animal in animals)
            //{
            //    var vowelCount = 0;
            //    foreach (var currentChar in animal)
            //    {
            //        if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u')
            //        {
            //            vowelCount += 1;
            //        }
            //    }
            //    if (vowelCount >= 2)
            //    {
            //        Console.WriteLine($"Would you like to have a {userColor} {animal}?");
            //        Console.ReadKey();
            //    }
            //}

            //Console.WriteLine($"Please choose one: {args[0]}, {args[1]}, {args[2]}");

            //var userEntry = Console.ReadLine();

            //if (userEntry == args[0] || userEntry == args[1] || userEntry == args[2])
            //{
            //    Console.WriteLine("you got it");
            //    Console.ReadLine();
            //}
            ////if (userEntry != args[0] || userEntry != args[1] || userEntry != args[2])
            //else
            //{
            //    Console.WriteLine("try again");
            //    Console.ReadLine();
            //}

            Console.WriteLine("enter string");
            var userResponse = Console.ReadLine();
            var builder = "";

            for (int i = 0; i < userResponse.Length; i++)
            {
                var position = i + 1;
                for (int k = 0; k < position; k++)
                {
                    builder += userResponse[i];
                }
                builder += "-";            
            }
            char[] charToTrim = { '-' };
            var output = builder.TrimEnd(charToTrim);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
