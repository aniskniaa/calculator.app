using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulatotr";
			
			Console.WirteLine("Pilih menu Calculator : ");
			Console.WirteLine("1. Penambahan");
			Console.WirteLine("2. Pengurangan");
			Console.WirteLine("3. Perkalian");
			Console.WirteLine("4. Pembagian");
			

            Console.Write("Inputkan Nilai A : ");
            int a = int.Parse(Console.ReadLine()); //cara satu

            Console.Write("Inputkan Nilai B : ");
            int b = Convert.ToInt32(Console.ReadLine()); //cara dua

            Console.WriteLine("\nHasil Pertambahan \t:" + a + " + " + b + " = " + pertambahan(a, b)); //cara satu
            Console.WriteLine("\nHasil Pengurangan \t: {0} - {1} = {2}", a, b, pengurangan(a, b)); //cara dua
            Console.WriteLine("\nHasil perkalian \t: {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("\nHasil Pembagian \t: {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan Sembarang Untuk Keluar");
            Console.ReadKey();
        }
        static int pertambahan(int a, int b)
        {
            return a + b; 
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b )
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}