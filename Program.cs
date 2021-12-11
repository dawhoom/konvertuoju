using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valiutuPavadinimai = { "USD", "PLN", "BYR" };
            decimal[] valiutuKursai = { 1.1312m, 4.6175m, 2, 86m };

            string goOn = "taip";
            while (goOn == "taip")
            {
                Console.WriteLine("Sveiki atvyke i pinigu konvertavimo sistema!");
                Console.WriteLine("I ka noretumete konvertuoti savo eurus:");
                Console.WriteLine("[1] USD, [2] PLN, [3] BYR");
                int ivestis = Convert.ToInt32(Console.ReadLine());
                if (ivestis == 1)
                {
                    KeitimasiUSD(valiutuKursai);

                }
                else if (ivestis == 2)
                {
                    KeitimasiPLN(valiutuKursai);
                }
                else if (ivestis == 3)
                {
                    KeitimasiBYR(valiutuKursai);
                }
                else
                {
                    Console.WriteLine("bloga ivestis");
                }
                Console.WriteLine("Ar norite testi? [taip] [ne]");
                goOn = Console.ReadLine();


            }

            static void KeitimasiUSD(decimal[] valiutuKursai)
            {
                Console.WriteLine("Iveskite suma:");
                decimal ivestis = Convert.ToDecimal(Console.ReadLine());
                decimal rezultatas = valiutuKursai[0] * ivestis;
                Console.WriteLine($"Jums priklauso {rezultatas} USD");
            }

            static void KeitimasiPLN(decimal[] valiutuKursai)
            {
                Console.WriteLine("Iveskite suma:");
                decimal ivestis = Convert.ToDecimal(Console.ReadLine());
                decimal rezultatas = valiutuKursai[1] * ivestis;
                Console.WriteLine($"Jums priklauso {rezultatas} PLN");
            }

            static void KeitimasiBYR(decimal[] valiutuKursai)
            {
                Console.WriteLine("Iveskite suma:");
                decimal ivestis = Convert.ToDecimal(Console.ReadLine());
                decimal rezultatas = valiutuKursai[2] * ivestis;
                Console.WriteLine($"Jums priklauso {rezultatas} BYR");
            }
        }
    }
}
