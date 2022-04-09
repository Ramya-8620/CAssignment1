using System;

namespace SwapInteger
{
    public class Swap
    {
        public void swapnumber(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
        }

        static void Main()
            
        {
            int Num1, Num2;
            Console.WriteLine("Enter the two numbers:");
            Num1= Convert.ToInt32(Console.ReadLine());
            Num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values before swapping= {0},{1}", Num1, Num2);
            Swap obj=new Swap();
            obj.swapnumber(ref Num1, ref Num2);
            Console.WriteLine("Values after swapping= {0},{1}", Num1,Num2);


            Console.ReadKey();
        }
    }
}
