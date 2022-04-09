using System;


namespace AreaCircumference
{
    public class Calculate
    {
        public void cal(double radius, double circumferance)
        {
            radius = 2 * Math.PI * radius;
            circumferance = Math.PI * radius * radius;
        }
        static void Main()
        {
            Console.WriteLine("Enter the values: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumferance = Convert.ToDouble(Console.ReadLine());
            Calculate calc = new Calculate(); 
             calc.cal(radius, circumferance);
            Console.WriteLine("Radius={0}\n Circumference={1}", radius, circumferance);
           
        }
    }
}
