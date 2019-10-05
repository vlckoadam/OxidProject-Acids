/*
MIT License

Copyright (c) 2019 Adam Vlčko

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WIT
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxidProject_Acids
{
    public class OxidProject
    {
        public static string ElementA = "§";
        public static void Main(string[] args)
        {
            Console.Title = "~ OxidProject ~";
            Console.WriteLine("Zadajte kyselinotvorny prvok");
            ElementA = Console.ReadLine();
            Console.WriteLine();
            for (int i = 1; i <= 8; i++)
            {
                Calc(i);
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static void Calc(int i)
        {
            if (i >= 1 && i <= 8)
            {
                int i1, i2;
                i1 = i % 2 == 0 ? 2 : 1;
                i2 = (i1 + i) / 2;
                Console.WriteLine("{0} : H{1}{2}O{3}", i, i1 != 1? i1+"" : "", ElementA, i2 != 1? i2 + "" : "");
            }
        }
    }
}
