using System;

namespace Session02Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var additionResult = 1 + 2;
            var incrementResult = additionResult++;

            Console.WriteLine("Addition Result: " + additionResult + " and Increment Result: " + incrementResult);

            var trueValue = true;
            var falseValue = false;
            var andResult = trueValue & falseValue;
            var orResult = trueValue | falseValue;
            var xorResult = trueValue ^ falseValue;

            Console.WriteLine("andResult is " + andResult + " while orResult is " + orResult + " and xorResult is " + xorResult);

            var moduloResult = 3 % 2;
            Console.WriteLine("ModuloResult is " + moduloResult);

            int highInteger = 1000;
            var divisionResult = highInteger / 3;
            Console.WriteLine("divisionResult is " + divisionResult);

            int higherInteger = 10000;
            var doubleDivisionResult = highInteger / 3.0;
            Console.WriteLine("doubleDivisionResult is " + doubleDivisionResult);

            int forcedIntDivisionResult = (int)(highInteger / 3.0);
            Console.WriteLine("forcedIntDivisionResult is equal to " + forcedIntDivisionResult);

            var conversionResult = Convert.ToInt32(doubleDivisionResult);
            Console.WriteLine("conversionResult is " + conversionResult);

            var midpointDivisionResult = 1.0 / 2.0;
            Console.WriteLine("midPointDivisionResult is " + midpointDivisionResult);
            Console.WriteLine("castToInt " + ((int)(midpointDivisionResult)).ToString());
            Console.WriteLine("Math.Ceiling " + Math.Ceiling(midpointDivisionResult));
            Console.WriteLine("Math.Floor" + Math.Floor(midpointDivisionResult));
            Console.WriteLine("Math.Round" + Math.Round(midpointDivisionResult, 3));

            Console.WriteLine("additionResult is currently: " + additionResult);
            additionResult += 2;
            Console.WriteLine("additionResult is currently: " + additionResult);
            //Also, these work
            additionResult -= 2;
            Console.WriteLine("additionResult is currently: " + additionResult);
            additionResult *= 2;
            Console.WriteLine("additionResult is currently: " + additionResult);
            additionResult /= 2;
            Console.WriteLine("additionResult is currently: " + additionResult);

            var greaterResult = 5 > 3;
            Console.WriteLine("Is five really greater than three? Of course it's " + greaterResult);

            var lessThanResult = 5 < 3;
            Console.WriteLine("Is five less than three? You can bet that it is " + lessThanResult);

            //And there's two more
            var greaterOrEqual = 3 >= 3;
            var lessOrEqual = 5 <= 5;
            Console.WriteLine("Is three greater or equal to three? It's " + greaterOrEqual + " And of course is five less than or equal to five? " + lessOrEqual);

            var andOperationResult = true && false;
            var orOperationResult = false || false;

            Console.WriteLine("andOperationResult " + andOperationResult);
            Console.WriteLine("orOperationResult" + orOperationResult);

        }
    }
}
