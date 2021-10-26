using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Happy number six_digit_number
            string number;
        int number1, number2, N = 0;
            for (int i = 1; i< 999999; i++)// Цикл для поиска счастливых билитов
            {   //6-ти значное число 
                number = String.Format("{0:000000}", i); //String.Format("{0:000000}" - принимает 6-ти значное число

                //1 часть 6-x значных чисел
                number1 = (int) number[0] + (int) number[1] + (int) number[2];

        //2 часть 6-ти значных чисел
        number2 = (int) number[3] + (int) number[4] + (int) number[5];
                if (number1 == number2)
                {
                    N++; //Количества С.Б  
                    Console.WriteLine(number);
                }
}
Console.WriteLine("Количества счатливых билетов: " + N);
Console.ReadLine();


        }

    }
}
