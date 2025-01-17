// See https://aka.ms/new-console-template for more information
using System;

namespace BasicsOfC
{
    class Program //Task 1
    {
        static int differenceBetween = 0;
        static int differenceBetween2 = 0;
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter Low Number");

            string inputLow = Console.ReadLine();

            int.TryParse(inputLow, out int lowNumber);

            Console.WriteLine("Enter High Number");
            string inputHigh = Console.ReadLine();

            int.TryParse(inputHigh, out int highNumber);

            differenceBetween = highNumber - lowNumber;
            Console.WriteLine("The difference between the two is: " + differenceBetween);
            //End of Task 1

            //Task 2
            Console.WriteLine("Enter Low Number");
            string inputLow2 = "3";
            inputLow2 = Console.ReadLine();
            int.TryParse(inputLow2, out int lowNumber2);
            while (lowNumber2 < 0)
            {
                Console.WriteLine("Enter a positive low number");
                Console.WriteLine("Enter Low Number");
                inputLow2 = Console.ReadLine();
                int.TryParse(inputLow2, out lowNumber2);
            }
            Console.WriteLine("Enter High Number");
            string inputHigh2 = "3";
            inputHigh2 = Console.ReadLine();
            int.TryParse(inputHigh2, out int highNumber2);
            while (highNumber2 < lowNumber2)
            {
                Console.WriteLine("Enter a positive high number bigger than the low number");
                Console.WriteLine("Enter high Number");
                inputHigh2 = Console.ReadLine();
                int.TryParse(inputHigh2, out highNumber2);
            }
            differenceBetween = highNumber2 - lowNumber2;
            Console.WriteLine("The difference between the two is: " + differenceBetween);
            //End of Task 2

            //Task 3
            Console.WriteLine("Enter Low Number");

            string inputLow3 = Console.ReadLine();

            int.TryParse(inputLow3, out int lowNumber3);

            Console.WriteLine("Enter High Number");
            string inputHigh3 = Console.ReadLine();

            int.TryParse(inputHigh3, out int highNumber3);

            int differenceBetween2 = highNumber3 - lowNumber3;
            string[] numbers = new string[differenceBetween2 - 1];

            for (int i = 0; i < differenceBetween2 - 1; i++)
            {
                int addNumber = lowNumber3 + i + 1;
                string writeNumber = addNumber.ToString();
                numbers[i] = writeNumber;
            }

            string path = @"E:\\SAIT semester 2\\Object Oriented 2\\Demos\\Basics of C# Assignment\\Basics of C# Assignment\\";
            Directory.CreateDirectory(path);

            string fileName = "arrayNumbers.txt";
            string filePath = @"E:\\SAIT semester 2\\Object Oriented 2\\Demos\\Basics of C# Assignment\\Basics of C# Assignment\\arrayNumbers.txt";

            Array.Reverse(numbers);
            File.WriteAllLines(filePath, numbers);
            //End of Task 3
        }
    }
}

