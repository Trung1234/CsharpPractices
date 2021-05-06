using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Hay nhap vao  so n: ");
            while (true)
            {
                string input = Console.ReadLine();
                if(Int32.TryParse(input, out n))
                {
                    if (n <= 1)
                    {
                        Console.WriteLine("Hay nhap vao 1 so lon hon 1");
                        continue;
                    }
                    else
                    {                       
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap vao 1 so");
                    continue;
                }
            }
            //int[] array = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("phan tu thu "+(i+1));
            //    array[i] = Int32.Parse(Console.ReadLine());
            //}
            Console.WriteLine("Day so tu 1 den n :");
            InDaySo(n);
            Console.WriteLine("So le tu 1 den n :");
            InSoLe(n);
            Console.WriteLine("So chan tu 1 den n :");
            InSoChan(n);
            Console.WriteLine("Day so tu n ve 1 :");
            InNguoc(n);
            Console.ReadLine();
        }

        static void InSoChan(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }                               
            }
            Console.WriteLine();
            Console.WriteLine("so luong so chan : " + count);
        }

        static void InDaySo(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        

        static void InSoLe(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");         
            }
            Console.WriteLine();
        }

        static void InNguoc(int n)
        {
            for (int i = n; i >0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
    }
}
