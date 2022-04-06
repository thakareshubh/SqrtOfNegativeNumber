using System;

namespace SqrtOfNegativeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            Sqrt();
            
        }
        /// <summary>
        /// SQRTs this instance.
        /// </summary>
        static void Sqrt()
        {
            //initialize variabale
            double c=Convert.ToDouble(Console.ReadLine());
            double t = c;
            double epsilon = 1E-15;
            double temp = t * epsilon;
            double temp1=Math.Abs(t-c/t);
            while(temp1>temp)
            {
                t = ((c / t) + t) / 2;
            }

            Console.WriteLine(t);     
        }

    }
   
}
