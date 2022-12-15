using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            while(true)
            {
                Console.WriteLine("Введите число: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if(number < 0)
                {
                    continue;
                }
                else if(number == 0) 
                {
                    break;
                }
                else
                {
                    sum += number;
                }
                
            }
            Console.WriteLine("Сумма введеных положительных чисел: {0}", sum);
        }
    }
}