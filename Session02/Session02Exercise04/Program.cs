using System;

namespace Session02Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);


            if (integer >= 18)
            {
                Console.WriteLine("The number you entered is greater than or equal to 18.");
            }
            else if (integer >= 10 && integer <18)
            {
                Console.WriteLine("The number you entered is between 10 and 17.");
            }
            else if (integer >= 7 && integer <10)
            {
                Console.WriteLine("The number you entered is between 7 and 9.");
            }
            else if (integer >= 2 && integer <7)
            {
                Console.WriteLine("The number you enetered is between 2 and 6.");
            }
            else
            {
                Console.WriteLine("The number you entered is less than 2.");
            }


            Console.WriteLine("Ange temperatur i grader C:");
            var temp = Console.ReadLine();
            var tempInt = Convert.ToInt32(temp);
            string waterLabel;


            if (tempInt >= 27)
            {
                waterLabel = "Går att bada";
            }
            else {
                waterLabel = "Fel temperatur.";
            }

            Console.WriteLine(waterLabel);
            //ALternativ
            string waterLabelAlt = integer >= 27 ? "Går att bada" : "Går inte att bada";
            Console.WriteLine(waterLabelAlt);


            switch (integer)
            {
                case 1: waterLabel = "Går inte att bada alls."; break;
                case -3: waterLabel = "Det är 3 minusgrader."; break;
                default: /* Vad som händer ifall inget annat träffar*/ break;
            }

            
        }
    }
}
