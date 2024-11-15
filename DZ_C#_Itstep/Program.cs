using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C__Itstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex.1
            Console.Write("It`s to win forgiveness ofor being wrong;\nbeing right is what gets you into real trouble\nBjarne Stroustrup\n");
            //Ex.2
            //Console.Write("Enter the five numbers: ");
            //int N = int.Parse(Console.ReadLine());
            //int n1 = N / 10000;
            //int n2 = N / 1000 % 10;
            //int n3 = N / 100 % 10;
            //int n4 = N / 10 % 10;
            //int n5 = N  % 10;
            //int max = n1, min = n1;
            //int sumNum = n1+n2+n3+n4+n5;
            //int productNum = n1*n2*n3*n4*n5;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            
            //if (n1 > max)
            //    max = n1;
            //if (n2 > max)
            //    max = n2;
            //if (n3 > max)
            //    max = n3;
            //if (n4 > max)
            //    max = n4;
            //if (n5 > max)
            //    max = n5;

            //if (n1 < min)
            //    min = n1;
            //if (n2 < min)
            //    min = n2;
            //if (n3 < min)
            //    min = n3;
            //if (n4 > max)
            //    min = n4;
            //if (n5 < min)
            //    min = n5;
            //Console.WriteLine($"Max num: {max}");
            //Console.WriteLine($"Min num: {min}");
            //Console.WriteLine($"Sum of numbers: {sumNum}");
            //Console.WriteLine($"Product of numbers: {productNum}");
            //Ex.3
            Console.Write("Enter the six numbers: ");
            int N = int.Parse(Console.ReadLine());
            int n1 = N / 100000;
            int n2 = N / 10000 % 10;
            int n3 = N / 1000 % 10;
            int n4 = N / 100 % 10;
            int n5 = N / 10 % 10;
            int n6 = N % 10;

            Console.WriteLine($"{n6}{n5}{n4}{n3}{n2}{n1}");
        }
    }
}
