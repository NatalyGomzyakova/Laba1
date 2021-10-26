using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Output(ref string sum, ref string result)
        {
            for (int i = sum.Length - 1; i >= 0; i--)
            {

                result += sum[i];
            }
            Console.WriteLine($"Результат: \n{result}");

        }

        static string MaxAdd0(ref string a1, ref string a2, out int max, out int len)
        {
            len = a1.Length;//создаем строку размера макс
            max = a1.Length - a2.Length;
            Console.WriteLine(max);
            string s = new string('0', max);
            s += a2;
            a2 = s;
            Console.WriteLine("Строка2:");
            Console.WriteLine(a2);
            return a2 + max + len;
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Запуск");
            Console.WriteLine("Число А");
            string s1 = Console.ReadLine();
            Console.WriteLine("Число В");
            string s2 = Console.ReadLine();


            string sum = "";
            string result = "";
            int max = 0;
            int len = 0;
            int ten = 0;
            //string s = new string('0', max);

            Console.WriteLine("Разница в размере");

            if (s1.Length > s2.Length)
            {



                MaxAdd0(ref s1, ref s2, out max, out len);
            }
            else if (s1.Length < s2.Length)
            {

                MaxAdd0(ref s2, ref s1, out max, out len);
            }
            else
            {
                len = s2.Length;

            }
            char[] ar1 = s1.ToCharArray();
            char[] ar2 = s2.ToCharArray();
            string[] MAXS = new string[len];//создаем строку размера макс

            for (int i = len - 1; i >= 0; i--)
            {


                //  Console.WriteLine(Convert.ToString(ar[i])); //1 2 3...
                MAXS[i] = Convert.ToString(ar1[i]);
                int num1 = Convert.ToInt32(MAXS[i]);
                MAXS[i] = Convert.ToString(ar2[i]);
                int num2 = Convert.ToInt32(MAXS[i]);
                if ((num2 + num1 + ten) >= 10)
                {

                    sum += (num2 + num1) + ten - 10;
                    ten = 1;
                }
                else
                {


                    sum += num2 + num1 + ten;
                    ten = 0;
                }
                if (i == 0)
                {
                    if (ten != 0)
                    {
                        sum += ten;
                    }
                    else { }
                }

            }
            Output(ref sum, ref result);
            /*
            Console.WriteLine(Convert.ToChar(n1) + Convert.ToChar(n1));
            int y = Convert.ToInt32(s1[len - 1]);
            Console.WriteLine(y);  */

        }

    }
}
