using System;
using System.Net.Http;

namespace ApiClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var whileRunning = true;
            while (whileRunning == true)
            {
                var client = new HttpClient();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("-----Welcome to Dog API Interface!-----");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("View all breeds");
                Console.WriteLine("Random breed");
                Console.WriteLine("Get sub-breed");
                Console.WriteLine("Quit");
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                if (choice == "View all breeds")
                {
                    var getAllDogs = await client.GetStringAsync("https://dog.ceo/api/breeds/list/all");
                    Console.WriteLine($"{getAllDogs}");
                }

                if (choice == "Random breed")
                {
                    var getRandomDog = await client.GetStringAsync("https://dog.ceo/api/breeds/image/random");
                    Console.WriteLine($"{getRandomDog}");
                }
                if (choice == "Get sub-breed")
                {
                    var getSubBreed = await client.GetStringAsync("https://dog.ceo/api/breed/hound/list");
                    Console.WriteLine($"{getSubBreed}");
                }
                if (choice == "Quit")
                {
                    whileRunning = false;
                }
            }
            Console.WriteLine("Have a good day...");
        }
    }
}
