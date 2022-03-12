using System;

namespace algoritma_odevi_2
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("2 pozitif sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % m == 0)
                {
                    Console.WriteLine(sayiDizisi[i]+" m Sayısına Tam Bölünmektedir.");
                }

                else if (sayiDizisi[i] == m)
                {
                    Console.WriteLine(sayiDizisi[i]+" m sayısına eşittir.");
                }
            }

        }
    }
}