using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex.1
            //int i = 14;
            //while (i <= 123)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Ex.2
            //int i = 0;
            //while (i < 100)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Ex.3
            //Console.Write("Enter numbers (N>0): ");
            //int N = int.Parse(Console.ReadLine());

            //if (N <= 0) {
            //    Console.WriteLine("N should be < 0");
            //    return;
            //}

            //int countNega = 0;
            //int i = 0;

            //while (i < N)
            //{
            //    Console.Write("Enter num: ");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num < 0) { 
            //        countNega++;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Numbers negative: {countNega}");
            //Ex.4
            //int N = 8;
            //double dobutok = 1;
            //double sum = 0;
            //int i = 0;

            //while (i < N)
            //{
            //    Console.Write("Enter num: ");
            //    int num = int.Parse(Console.ReadLine());
            //        dobutok *= num;
            //        sum += num;
            //        i++;
            //}
            //double average = sum / i;

            //Console.WriteLine($"Dobutok: {dobutok }");
            //Console.WriteLine($"Average: {average }");
            //Ex.5
            //int num = 100;
            //do { 
            //    if (num % 2 != 0) 
            //    { 
            //        Console.Write(num + " "); 
            //    }
            //    num--;
            //} 
            //while (num >= 1);

            //Ex.6
            //int N = 5;
            //int i = 0;
            //int dobutok = 1;
            //do
            //{
            //    Console.WriteLine("Enter num: ");
            //    int num = int.Parse(Console.ReadLine());
            //    i++;
            //    dobutok *= num;
            //}
            //while (i <= N);
            //Console.WriteLine(dobutok);

            //Ex.7
            //1 type
            //int sum = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //2 Type
            //int i = 1;
            //double sum = 0;
            //do
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine(i + " ");
            //        sum += i;
            //    }
            //    i++;
            //}
            //while (i < 50);
            //Console.WriteLine($"Sum: {sum}");
            //Ex.8

            //int num = int.Parse(Console.ReadLine());
            //int i = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Ex.9
            //Console.Write("Enter start: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter end: ");
            //int end = int.Parse(Console.ReadLine());
            //int i;
            //Console.WriteLine("Odd:");
            //i = start;
            //while (i <= end)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;

            //}
            //Console.WriteLine("Even:");
            //i = start;
            //while (i <= end)
            //{

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //Console.WriteLine("Multiple of 7:");
            //i = start;
            //while (i <= end)
            //{

            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Ex.10

            //Console.Write("Enter start: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter end: ");
            //int end = int.Parse(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine(start);
            //    start++;
            //    sum += start;
            //} while (start <= end );
            //Console.WriteLine($"Sum: {sum}");

            //Ex.11
            int sum = 0;
            int num;
            do {
                Console.Write("Enter num: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } 
            while (num != 0);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
