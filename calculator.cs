using System;

namespace Calculator
{
     class Program
    {
        static void Main()
        {
            int num1, num2;
            char op;

            Console.WriteLine("Enter the operator(+,-,*,/):");
            op=Console.ReadLine()[0];

            Console.WriteLine("Enter the two numbers:");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            num2 = Convert.ToInt32(Console.ReadLine()); 
            
            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", num1, num2, (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}",num1,num2,(num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", num1, num2, (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Divide by zero situation");
                    else
                    Console.WriteLine("{0}", num1, num2, (num1 / num2));
                    break;
                    default:
                    Console.WriteLine("{0} is invalid operator", op);
                    break;

            }

            Console.ReadKey();
        }


    }
}
