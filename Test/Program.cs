using System;

namespace Test {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Adjon meg két egész számot:");

            while (!int.TryParse(Console.ReadLine(), out int egesz)) {
                Console.WriteLine("Adjon meg egy egész számot:");
            }

            while (!int.TryParse(Console.ReadLine(), out int egesz2)) {
                Console.WriteLine("Adjon meg egy egész számot:");
            }

            Console.ReadKey();
        }
    }
}
