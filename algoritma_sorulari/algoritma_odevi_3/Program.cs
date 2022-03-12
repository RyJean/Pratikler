using System;

namespace algoritma_odevi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeDizisi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.",i+1);
                kelimeDizisi[i] = Convert.ToString(Console.ReadLine());
            }

            foreach (var kelime in kelimeDizisi)
            {
                Console.WriteLine(kelime);
            }
            
            Array.Reverse(kelimeDizisi);
            foreach (var kelime in kelimeDizisi)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}