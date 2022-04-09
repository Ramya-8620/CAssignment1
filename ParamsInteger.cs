using System;


namespace ParamsofIntegers
{
    
    public  class ParamInt
    {
        static void Main(string[] args)
        {
            int sum = sumofinteger(4, 5, 76, 98, 23, 6);
            Console.WriteLine("Result={0}",sum);
            Console.ReadKey();
        }
     static int sumofinteger(params int[] val)
        {
            int sum = 0;
            foreach(int i in val)
            {
                sum += i;
            }
            return sum;
        }
    }
}
