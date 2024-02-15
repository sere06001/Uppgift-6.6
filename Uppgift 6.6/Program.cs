using System;
namespace uppgift6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening.");
            string[] mening = Console.ReadLine().Split();
            StorSmåBokstav(mening);
            Console.ReadLine();
        }
        static void StorSmåBokstav(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a[i] = a[i].ToUpper();
                    Console.Write(a[i]);
                }
                else
                {
                    a[i] = a[i].ToLower();
                    Console.Write(a[i]);
                }
                Console.Write(" ");
            }
        }
    }
}