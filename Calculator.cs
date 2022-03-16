using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            // int a = 1; // declarasi variabel a, dengan nilai awal 1;
            // int b = 1; // declarasi variabel b, dengan nilai awal 1;

            Console.WriteLine("PIlihlah Menu Calculator : ");

            Console.WriteLine();

            Console.WriteLine("1. Penambahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian" );

            Console.WriteLine(); // tambhakan baris kosong

            Console.Write("Inputkan nomor menu = ");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if ( var == 1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (var == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (var == 3)
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (var == 4)
            {
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); // proses casting
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, nomor yang Anda pilih tidak tersedia");
            }
            Console.WriteLine(); // tambahkan baris kosong

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
