using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1184035
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Nilai N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= 1 || N <= 10) 
            {
                for (int i = N; i > 0; i--)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i);
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah {0}, mati satu tinggallah induknya", i, i -1 );
                    }
                }
            }
            else
            {
                Console.WriteLine("Nilai tidak boleh dibawah 0 atau diatas 10");
            }
        }
    }
}
