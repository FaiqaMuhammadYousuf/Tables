using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number Of Table");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Given Number is : " + num);
            Console.Write("\n");


            Console.WriteLine("Enter The Limit Of The Table");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Given Limit is till : " + limit);
            Console.Write("\n");

            for (int i = 1; i <= limit ; i++)
            {
                Console.WriteLine(num + "X" + i + "=" + num * i);
            }


        }
    }
}
