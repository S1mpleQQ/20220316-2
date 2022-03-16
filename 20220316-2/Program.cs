using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char op;
            Console.Write("Number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator(+,-,*,/):");
            op = Convert.ToChar(Console.ReadLine());
            
            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}=", a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}=", a + b);
                    break;
                case '*':
                    Console.WriteLine("{0}=", a + b);
                    break;
                case '/':
                    Console.WriteLine("{0}=", a + b);
                    break;
                default:
                    Console.WriteLine("你不是機器人無法執行");

                    break;
            }
            Console.ReadLine();
        }
    }
}
