using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int b = Convert.ToInt32(Console.ReadLine());
            string output = Convert.ToString(b, 2);
            Console.WriteLine(output);
            int n = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == '1')
                {
                    n++;
                }
            }
            Console.WriteLine(n);
        }
    }
}
