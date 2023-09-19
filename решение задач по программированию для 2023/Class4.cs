using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace решение_задач_по_программированию_для_2023
{
    internal class raspred
    {
        public void Severozapad()
        {
            try
            {

            int kolA, kolB,result=0; 
            Console.WriteLine("Введите количество A");
            kolA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество B");
            kolB = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[kolA];
            int[] B = new int[kolB];
            int[,] cena = new int[kolA, kolB];  
            int[,] raspr = new int[kolB, kolA];
            VxodInf(A, B, cena);
            VxodTable(A, B, cena);
            reshenie(A, B, cena, raspr,ref result);
            OutputInf(A,B,cena,raspr,result);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Произошла ошибка!!!\nВозможно вы ввели неверное значение попробуйте снова.");
                Severozapad();
            }
        }
        int sum(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum+=A[i];
            }
            return sum;
        }
        void VxodInf(int[] A, int[] B, int[,] cena)
        {
            try
            {

            do
            {
                for(int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"Введите A{i+1}");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
                for(int i = 0; i < B.Length; i++)
                {
                    Console.WriteLine($"Введите B{i + 1}");
                    B[i] = Convert.ToInt32(Console.ReadLine());
                }
                if(sum(A) !=sum(B))
                {
                    Console.Clear();
                    Console.WriteLine("Суммы не совпадают!!!\nВведите значения снова.");
                }
                else
                {
                    break;
                }

            } while (true);

            for(int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < B.Length; j++)
                {
                    Console.WriteLine($"Введите Цену для [A{i+1},B{j+1}]");
                    cena[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Кажется вы ввели неверное значение попробуйте снова.");
                VxodInf(A,B,cena);
            }         
        }
        void VxodTable(int[] A, int[] B, int[,] cena)
        {
            Console.Clear();
            Console.WriteLine("Исходная таблица\n");
            Console.Write("Ai\\Bi");
            for(int i = 0; i < B.Length; i++)
            {
                Console.Write($"\tB{i+1}({B[i]})");
            }
                Console.WriteLine("\n");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write($"A{i + 1}({A[i]})");
                for(int j =0; j < B.Length; j++)
                {
                    Console.Write("\t"+cena[i,j]);
                }
                Console.WriteLine("");
            }
        }
        int min(int a,int b)
        {
            if(a >= b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        void reshenie(int[] A, int[] B, int[,] cena, int[,] raspr,ref int result)
        {
            int i = 0,j = 0,minimum;
            while (sum(A) != 0)
            {
                minimum = min(A[i], B[j]);
                raspr[i,j] = minimum;
                result += cena[i, j] * minimum;
                A[i] -= minimum;
                B[j] -= minimum;
                if (A[i] == 0)
                {
                    i++;
                }
                if (B[j] == 0)
                {
                    j++;
                }
            }
        }
        void OutputInf(int[] A, int[] B, int[,] cena,int[,] raspred,int result)
        {
            Console.WriteLine("\nИтоговая таблица\n");
            Console.Write("Ai\\Bi");
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"\tB{i + 1}({B[i]})");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A{i + 1}({A[i]})");
                for (int j = 0; j < B.Length; j++)
                {
                    Console.Write("\t" + cena[i, j]);
                    if(raspred[i,j] != 0)
                    {
                        Console.Write($"/{raspred[i, j]}");
                    }

                }
                Console.WriteLine("");
            }
                Console.WriteLine($"Итоговый результат = {result} У.Д.Е.");
        }

        public void MinElements()
        {
            try
            {

                int kolA, kolB, result = 0;
                Console.WriteLine("Введите количество A");
                kolA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество B");
                kolB = Convert.ToInt32(Console.ReadLine());
                int[] A = new int[kolA];
                int[] B = new int[kolB];
                int[,] cena = new int[kolA, kolB];
                int[,] raspr = new int[kolB, kolA];
                VxodInf(A, B, cena);
                VxodTable(A, B, cena);
                MinReshenie(A, B, cena, raspr, ref result);
                OutputInf(A, B, cena, raspr, result);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Произошла ошибка!!!\nВозможно вы ввели неверное значение попробуйте снова.");
                Severozapad();
            }
        }
        void MinReshenie(int[] A, int[] B, int[,] cena, int[,] raspr, ref int result)
        {
            int Indi =0, Indj=0, minimum,MinCena;
            while (sum(A) != 0)
            {
                MinCena = 999999;
                for (int i = 0; i < A.Length; i++)
                {
                    for(int j = 0; j < B.Length; j++)
                    {
                        if(cena[i, j] < MinCena && A[i] !=0 && B[j] != 0)
                        {
                            MinCena = cena[i, j];
                            Indi = i;
                            Indj = j;
                        }
                    }
                }
                minimum = min(A[Indi], B[Indj]);
                raspr[Indi, Indj] = minimum;
                result += cena[Indi, Indj] * minimum;
                A[Indi] -= minimum;
                B[Indj] -= minimum;

            }
        }


    }
}
