using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace решение_задач_по_программированию_для_2023
{
    internal class file
    {
        string[] ban;
        string path = "1.txt";
        Kords[] mas;
        Regex Regex = new Regex(@"^(((\-|m{0})(\d+|\d+,\d+)\s){5}(\-|m{0})(\d+|\d+,\d+))$");
        struct Kords
        {
            private double y3;
            private double x1;
            private double y1;
            private double x2;
            private double y2;
            private double x3;

            public double X1 { get => x1; set => x1 = value; }
            public double Y1 { get => y1; set => y1 = value; }
            public double X2 { get => x2; set => x2 = value; }
            public double Y2 { get => y2; set => y2 = value; }
            public double X3 { get => x3; set => x3 = value; }
            public double Y3 { get => y3; set => y3 = value; }
            public void setkords(string[] str )
            {                
                X1 = Convert.ToDouble(str[0]);
                Y1 = Convert.ToDouble(str[1]);
                X2 = Convert.ToDouble(str[2]);
                Y2 = Convert.ToDouble(str[3]);
                X3 = Convert.ToDouble(str[4]);
                Y3 = Convert.ToDouble(str[5]);
            }
        }

        void readfile()
        {    
            ban = new string[0] ;
            mas = new Kords[0] ;
            String[] str = File.ReadAllLines(path);     
            int m = 0,b = 0;
          
            for(int i = 0; i < str.Length; i++)
            {               
                string[] temp = str[i].Split(' ');
                if(Regex.IsMatch(str[i]))
                {
                    Array.Resize(ref mas, mas.Length + 1);
                    mas[m].setkords(temp);
                    m++;
                }
                else 
                {
                    Array.Resize(ref ban,ban.Length+1);
                    ban[b] = str[i];
                    b++;
                }
            }
        }
        void storoni(Kords kords, out double a, out double b,out double c)
        {
            a = Math.Sqrt(Math.Pow(kords.X3 - kords.X2, 2) + Math.Pow(kords.Y3 - kords.Y2, 2));
            b = Math.Sqrt(Math.Pow(kords.X2 - kords.X1, 2) + Math.Pow(kords.Y2 - kords.Y1, 2));
            c = Math.Sqrt(Math.Pow(kords.X1 - kords.X3,2) + Math.Pow(kords.Y1 - kords.Y3,2));
        }
        bool proverka(Kords kords)
        {
            if((kords.X1 - kords.X2)/(kords.X3-kords.X2) == (kords.Y1 - kords.Y2)/(kords.Y3 - kords.Y2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool proverkastoron(double a,double b,double c)
        {
            if(a+b>=c && a+c>=b && c + b >= a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        double perimetr(double a, double b,double c)
        {
            return a + b + c;
        }
        double ploshad(double a, double b, double c)
        {
            double p = perimetr(a, b, c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        void max(double a,double b,double c,out double g, out double k, out double k1)
        {
                if (a>=c && a>=b)
                {
                g = a;
                k = b;
                k1 = c;
                }
                else if(b>=c && b >= a)
                {
                g=b;
                k = c;
                k1 = a;
                }
                else
                {
                g = c;
                k = a;
                k1 = b;
                }
        }
        string type(double a, double b, double c)
        {
            double g, k, k1;
            max(a,b,c,out g,out k,out k1);
            if (g * g > k * k + k1 * k1)
            {
                return "Тупоугольный";
            }
            else if (g * g < k * k + k1 * k1)
            {
                return "Остроугольный";
            }
            else
            {
                return "Прямоугольный";
            }
        }
        void treugolnik(Kords[] kords)
        {
            double a,b,c;
            for(int i = 0; i < kords.Length; i++)
            {
                if (proverka(kords[i]))
                {
                    storoni(kords[i],out a,out b,out c);
                    if (proverkastoron(a, b, c))
                    {
                        Console.WriteLine($"{i + 1}. Образует треугольник, стороны: {string.Format("{0:f3}",a)}; {string.Format("{0:f3}", b)}; {string.Format("{0:f3}", c)} , P = {string.Format("{0:f3}", perimetr(a,b,c))}, S = {string.Format("{0:f3}", ploshad(a, b, c))}, Тип: {type(a,b,c)} ");;
                    } 
                    else
                    {
                        Console.WriteLine($"{i + 1}. НЕобразует треугольник.");
                    }                    
                }
                else
                {
                    Console.WriteLine($"{i+1}. Три вершины лежат на одной прямой.");
                }
            }
        }        
        public void Output_Inf()
        {
            readfile();
            Console.WriteLine("Вершины треугольника считанные из файла:");
            foreach(Kords str in mas)
            {
                Console.WriteLine($"{str.X1} {str.Y1} {str.X2} {str.Y2} {str.X3} {str.Y3}");
            }
            Console.WriteLine("");
            treugolnik(mas);
            Console.WriteLine("");
            Console.WriteLine("Проигнорированные строки считанные из файла:");
            foreach (string str in ban)
            {
                Console.WriteLine(str);
            }
        }


    }
}
