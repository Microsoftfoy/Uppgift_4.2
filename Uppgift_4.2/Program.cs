using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            bool continueInput = true;

            while (continueInput)
            {
                Console.WriteLine("Skriv in ett heltal:");
                int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                Console.WriteLine("Vill du skriva in ett till tal? (ja/nej)");
                string response = Console.ReadLine().ToLower();

                if (response != "ja")
                {
                    continueInput = false;
                }
            }

            Console.WriteLine($"Det största talet som du skrev in är: {maxNumber}");

        }

    }
}

