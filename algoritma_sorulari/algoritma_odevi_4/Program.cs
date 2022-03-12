using System;

namespace algoritma_odevi_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Cümle Giriniz ");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelimeler = cumle.Split(" ");
            char[] harfler = cumle.ToCharArray();

            int harfSayisi = 0;

            Console.WriteLine("Verilen Cümlede {0} Kelime Vardır.",kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                 char[] harfdizi = kelimeler[i].ToCharArray();
                harfSayisi += harfdizi.Length;
            }
            System.Console.WriteLine("Verilen Cümlede {0} Harf Vardır.",harfSayisi);
        }
    }
}