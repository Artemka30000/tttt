using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace решение_задач_по_программированию_для_2023
{
    internal class Cikl
    {


        public void perevorot()
        {
            int n;
            int k;
            Console.WriteLine("Введите число:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перевёрнутое число: ");
            for (; n != 0;)
            {
                k = n % 10;
                n/=10;
                Console.Write(k);
            }
            Console.WriteLine();
        }
        public void calculator()
        {
            double x, y;
            char c;
            do
            {
                Console.WriteLine("Введите арифметическую операцию(+-/*)");
                c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите число Х");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите число Y");
                y = Convert.ToDouble(Console.ReadLine());
                operation(c, x, y);

                Console.WriteLine();
            }
            while (c != 'e');

        }
        private void operation(char c,double x,double y)
        {
                switch (c)
                {
                    case '-':
                        Console.WriteLine("Получается {0}",x-y);
                        break;
                    case '/':
                        if(y == 0)
                        {
                            Console.WriteLine("На 0 делить нельзя");
                        }
                        else
                        {
                        Console.WriteLine("Получается {0}", x / y);
                        }                      
                        break;
                    case '*':
                        Console.WriteLine("Получается {0}", x * y);
                        break;
                    case '+':
                        Console.WriteLine("Получается {0}", x + y);
                        break;
                    default: 
                        Console.WriteLine("Вы ввели неверный знак");
                        break;
                }
        }
    }
}
