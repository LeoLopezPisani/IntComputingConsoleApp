using System;
using System.Collections.Generic;

namespace IntComputingConsoleApp
{
    class Program
    {
        static void Main()
        {
            //List<int> intList = new List<int>();
            Console.WriteLine("Type the amount of numbers you would like to use:");
            var input = Console.ReadLine();

            if(!int.TryParse(input, out int intInput) || Convert.ToInt32(input) <= 0) 
            {
                Console.WriteLine($"{input} is not a valid number.");
            }
            else
            {
                int[] arr = new int[intInput];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Type an integer:");
                    string numbers = Console.ReadLine();
                    if(!int.TryParse(numbers, out var num))
                    {
                        Console.WriteLine($"{numbers} is not an integer");
                    }
                    else
                    {
                        arr[i] = num;
                    }
                }
                Console.WriteLine("Type max for highest number, min for lowest number, avg for average or fizzbuzz for fizzbuzzing:");
                string operation = Console.ReadLine();
                var calc = new Computing();
                switch(operation)
                {
                    case "avg":
                        calc.ComputeAvg(arr);
                        break;
                    case "max":
                        calc.ComputeMax(arr);
                        break;
                    case "min":
                        calc.ComputeMin(arr);
                        break;
                    case "fizzbuzz":
                        Console.WriteLine("Type fizzbuzz threshold, it must be an integer:");
                        string strInput = Console.ReadLine();
                        if (!int.TryParse(strInput, out int x))
                        {
                            Console.WriteLine($" { strInput } is not a valid number");
                            break;
                        }
                        else
                        {
                            int threshold = Convert.ToInt32(strInput);
                            calc.ComputeFizzBuzz(threshold);
                            break;
                        }
                    default:
                        Console.WriteLine($"{ operation } no es una operación válida");
                        break;
                }

            }

                //for (int i = 0; i < intInput; i++)
                //{
                //    Console.WriteLine("Type an integer:");
                //    input = Console.ReadLine();
                //    if (!int.TryParse(input, out var x))
                //    {
                //        Console.WriteLine($"{input} is not an integer");
                //    }
                //    else
                //    {
                //        intList.Add(Convert.ToInt32(input));
                //}
                //AverageNumbers(intList);
        }
    }

    //    static double AverageNumbers(List<int> lista)
    //    {
    //        int sum = 0;
    //        foreach (int i in lista)
    //        {
    //            sum += i;
    //        }
    //        return sum / lista.Count;        }
    //}
}


//public class AverageFromArray
//{
//    public AverageFromArray(int[] intArr) 
//    {
//        int sum = 0;
//        for (int i = 0; i<intArr.Length; i++)
//        {
//            sum += intArr[i];
//        }
//    double avg = sum / intArr.Length;
//    Console.WriteLine($"Average is { avg }");
//    }
//}


public class Computing
{
    public Computing() {}

    public void ComputeAvg(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        double avg = sum / arr.Length;
        Console.WriteLine($"The average value is { avg }");
    }

    public void ComputeMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i]);
        }
        Console.WriteLine($"The minimum value is { min }.");
    }

    public void ComputeMax(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            max = Math.Max(max, arr[i]);
        }
        Console.WriteLine($"The maximum value is { max }.");
    }

    public void ComputeFizzBuzz(int threshold)
    {
        for (int i = 1; i <= threshold; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if ( i % 3 == 0 )
            {
                Console.WriteLine("fizz");
            }
            else if ( i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}