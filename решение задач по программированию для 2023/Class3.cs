using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace решение_задач_по_программированию_для_2023
{
    internal class Geymurchik
    {

        public void kvadrat()
        {
            int n;
            int t = 1;
            Console.WriteLine("введитее число");
           n = Convert.ToInt32(Console.ReadLine());
   
            for(int i = 1; Math.Pow(i,2) <= n; i++)
            {
                t = i * i;
                Console.Write("{0} ", t);
            }
        }
        public void kub()
        {       
            int n,m;
            Console.WriteLine("введитее число n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введитее число m");
            m = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for(; i < m-1; )
            {
                i += 1;
                Console.Write("{0} ",i*i*i);

            }
        }
        public void xuy()
        {
            int x, z,t=1;
            Console.WriteLine("введитее число на каторую умножит");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("до скольки");
            z = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<x*z; i++)
            {
                i = x * t;
                t++;
                Console.Write("{0}, ",i);
            }
        }

        public void xuy1()
        {
            int x, z;
            Console.WriteLine("введитее число на каторую умножит");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("до скольки");
            z = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= z; i++)
            {               
                Console.Write("{0}, ",x * i);
            }
        }

        public void cisli()
        {
            double y;
            Console.WriteLine("x \ty");
            for (double i = -5; i <= 5; i+=0.5) 
            {
                y = 5-Math.Pow(i,2)/2;
                Console.WriteLine("{0} \t{1} ",i,y);
            }
        }

        public void cisli1()
        {
            double x, y,x1,x2;
            Console.WriteLine("начальный отрезок");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("канечное число");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("шаг");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x \ty");
            for (double i = x; i <= x1; i +=x2)
            {
                y = 5 - Math.Pow(i, 2) / 2;
                Console.WriteLine("{0} \t{1} ", i, y);
            }
        }
    }
}
