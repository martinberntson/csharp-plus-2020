using System;

namespace Session02Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello scrubs");
            Console.WriteLine("Please enter a value:");

            var integerValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Integer's value is: " + integerValue);

            string stringValue = "of Steel";

            Console.WriteLine("The walls are made " + stringValue);
            if (integerValue > 90)
            {
                Console.WriteLine(integerValue + " is over 90.");
            }
            else if (integerValue == 90){
                Console.WriteLine(integerValue + " is equal to 90.");
            }
            else
            {
                Console.WriteLine(integerValue + " is under 90.");
            }//enter text here
        }

    }
}
