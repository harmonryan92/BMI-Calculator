using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class BMI
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmi;

            Console.WriteLine("Enter your weight in pounds: ");            

            while(!double.TryParse(Console.ReadLine(), out weight) || weight < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

            Console.WriteLine("Enter your height in inches: ");

            while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                Console.WriteLine("Not valid. Must be a positive rational number.");
            }

            bmi = (weight * 703) / (height * height);

            Console.WriteLine("\nYour BMI is: {0:F}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("According to the DHHS, you are underweight.");
            }
            else if (bmi <= 24.9)
            {
                Console.WriteLine("According to the DHHS, you are normal weight.");
            }
            else if (bmi <= 29.9)
            {
                Console.WriteLine("According to the DHHS, you are overweight.");
            }
            else
            {
                Console.WriteLine("According to the DHHS, you are obese.");
            }
        }
    }
}
