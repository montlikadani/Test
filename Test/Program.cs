using System;

namespace Test {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Adjon meg két egész számot:");

            int egesz, egesz2;

            while (!int.TryParse(Console.ReadLine(), out egesz)) {
                Console.WriteLine("Adjon meg egy egész számot:");
            }

            while (!int.TryParse(Console.ReadLine(), out egesz2)) {
                Console.WriteLine("Adjon meg egy egész számot:");
            }

            if (egesz > egesz2) {
                Console.WriteLine("A nagyobb szám: " + egesz);
            } else if (egesz2 > egesz) {
                Console.WriteLine("A nagyobb szám: " + egesz2);
            }

            Console.ReadKey();
        }
    }
}
