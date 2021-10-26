using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Это палллилограм?");



            int b = Convert.ToInt32(Console.ReadLine());
            // string output = Convert.ToString(b);
            //  Console.WriteLine(output);
            int[] n = new int[4] { 0, 0, 0, 0 };
            string k = "";


            while (b > 0)
                for (int i = 0; i < 4; i++)
                {


                    n[i] = b % 10;

                    b /= 10;

                }
            string w = "";

            for (int i = n.Length - 1; i >= 0; i--)

            {

                k += n[i];


            }
            for (int i = 0; i < n.Length; i++)

            {

                w += n[i];


            }
            Console.WriteLine($"{w}");

            if (w == k)
            {
                Console.WriteLine($"Да");

            }
            else
            {
                Console.WriteLine($"Нет");
            }


        }
    }
}
