using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void factorial()
        {

            Console.WriteLine("enter the integer 1 to 10");
            int usernum = Convert.ToInt32(Console.ReadLine());
            for (int i = usernum - 1; i >= 1; i--)
            {
                usernum = usernum * i;


            }
            Console.WriteLine(usernum);

        }
        static void Main(string[] args)
        {
            factorial();
               
        }
    }

}