	using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Exercise03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ange ett antal siffror, separerade med kommatecken.");
			var input = Console.ReadLine();
			var inputArray = input.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
			double[] numberArray = new double[inputArray.Length];

			for (int i = 0; i < inputArray.Length; i++)
			{
				try
				{
					numberArray[i] = Convert.ToDouble(inputArray[i]);

					Debug.Assert(i < inputArray.Length - 1);
				}
				catch (Exception)
				{
					numberArray[i] = 0;
				}
				finally //kommer köras även om try/catch har gjort en break. Körs alltid.
				{

				}


				foreach (var number in numberArray)
				{
					Console.WriteLine("Värde: " + number.ToString());
				}
				int exceptionStatus = GetExceptionStatus();
			}
		}
		static int GetExceptionStatus()
		{

			int exceptionResult;

			try
			{
				throw new Exception("FEL");
				exceptionResult = 1;
				return exceptionResult;
			}
			catch (Exception ex)
			{
				exceptionResult = ex.HResult;
				return exceptionResult;
			}
			finally
			{
				exceptionResult = int.MaxValue;

			}

			static double getDoubleValue(string input);
			{
				try
				{
					var result = int.Parse(input);

					return result;
				}
				catch (FormatException ex) when (ex.Message.Contains("Input string"))
				{
					return input.MinValue;
				}
				catch (Exception ex)
				{
					return 0;
				}
			}
		}
	}
}

