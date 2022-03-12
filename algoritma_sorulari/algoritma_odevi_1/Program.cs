using System;

namespace algoritma_odevi_1
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            if(n <= 0){
                Console.WriteLine("Pozitif bir sayı giriniz: ");
            }

            Console.WriteLine("{0} adet pozitif sayı giriniz: ", n);

            for(int i = 0; i < n; i++){
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
	    if(array[i] <= 0){
                    Console.WriteLine("Pozitif bir sayı giriniz: ");
            }

            if(array[i] % 2 == 0){
                    Console.WriteLine("{0} çifttir.", array[i]);
            }
        }
    }
}