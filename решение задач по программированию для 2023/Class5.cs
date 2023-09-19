using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace решение_задач_по_программированию_для_2023
{
    internal class Djonson
    {
        struct table
        {
            int A;
            int B;
        }

        string File_DateInput = "Начальная Информация.txt";
        string File_DateOutput = "Решение Джонсона.txt";
        List<table> InputInf = new List<table>();
        List<table> OutputInf = new List<table>();
        public void ReadFile()
        {
            string[] strings = File.ReadAllLines(File_DateInput);
            string[] temp;
            for(int i = 0; i < strings.Length; i++)
            {
                temp = strings[i].Split(' ');
            }

           
        }
    }
}
