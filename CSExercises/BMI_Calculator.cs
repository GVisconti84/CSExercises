using System;

namespace CSExercises
{
    class BMICalculator
    {
        public static void LocalMain(string[] args)
        {
            double bmi;
            Console.WriteLine("Insert weight in kg:\n");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert height in meters:\n");
            double height = Convert.ToDouble(Console.ReadLine());

            bmi = (weight) / (Math.Pow(height, 2));

            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine("BMI VALUE");
            Console.WriteLine("Underweight: less than {0}", 18.5);
            Console.WriteLine("Normal:      between {0} and {1}", 18.5, 24.9);
            Console.WriteLine("Overweight:  between {0} and {1}", 25, 29.9);
            Console.WriteLine("Obese:       {0} or greater", 30);
        }
        
    }
}
