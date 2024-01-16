// January-13-2024 Ammar Tayyab
using System;

class Test
{
        static void Main()
        {int lowNum;
                do
        { 
          Console.WriteLine("Enter the lower of two numbers: ");
          lowNum = Convert.ToInt32(Console.ReadLine());
        } while (lowNum<0);
            int highNum;
        do
        {Console.WriteLine("Enter the higher of two numbers: ");
         highNum = Convert.ToInt32(Console.ReadLine());
        }while (lowNum>=highNum);
            Console.WriteLine($"You entered the numbers {highNum} and {lowNum}");
            int numDiff = highNum-lowNum;
            Console.WriteLine ($"The difference between these numbers is {numDiff}");
            int[] numberArray = new int[numDiff];
            for (int i = 1; i < numberArray.Length; i++)
            {
            numberArray[i] = lowNum + i;
            }
        using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
                foreach (int num in numberArray)
            {
                writer.WriteLine(num);
            }
        }
        }
}