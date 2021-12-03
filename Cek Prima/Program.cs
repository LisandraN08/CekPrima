using System;

namespace Cek_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            int Bilangan = Convert.ToInt32(Console.ReadLine());
            int jumlahFaktor = 0;
            for (int i = 1; i <= Bilangan; i++)
            {
                if (Bilangan % i == 0)
                {
                    jumlahFaktor += 1;
                }
            }
        }
    }
}

