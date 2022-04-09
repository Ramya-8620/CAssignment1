using System;

namespace AvgMarks
{
     class Avg
    {
        
        
            static void Main()
            {
            int[] Avgmarks = new int[5]; int i;
            Console.WriteLine("Enter avg marks of 5 students: ");
            Avgmarks[0] = 50;
            Avgmarks[1] = 20;
            Avgmarks[2] = 10;
            Avgmarks[3] = 70;
            Avgmarks[4] = 55;
            int Maxmarks = Avgmarks[0];
            for( i=0; i<5;  i++)
            {
                if( Avgmarks[i] > Maxmarks )
                {
                    Maxmarks = Avgmarks[i];
                }
            }
            Console.WriteLine("Maximum marks= {0}", Maxmarks);              

            Console.ReadKey();
            }
        
    }
}
