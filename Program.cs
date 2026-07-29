using System;

class Program
{
    static void Main()
    {
        bool continueCalculator = true;
        Console.Title = "C# Console Calculator";

        while (continueCalculator)
        {
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("      C# CONSOLE CALCULATOR");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Square Root");
            Console.WriteLine("7. Power (x²)");
            Console.WriteLine("8. Exit");
            Console.WriteLine();

            Console.Write("Choose an option (1-8): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("\n❌ Invalid choice!");
                Console.ReadKey();
                continue;
            }

            if (choice == 8)
            {
                Console.WriteLine("\nThank you for using the calculator!");
                break;
            }

            double num1 = 0, num2 = 0, result = 0;

            // Square Root
            if (choice == 6)
            {
                while (true)
                {
                    Console.Write("\nEnter Number: ");

                    if (double.TryParse(Console.ReadLine(), out num1))
                        break;

                    Console.WriteLine("❌ Invalid number!");
                }

                if (num1 < 0)
                {
                    Console.WriteLine("\n❌ Cannot calculate square root of a negative number.");
                }
                else
                {
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"\n√{num1} = {result}");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                continue;
            }

            // First Number
            while (true)
            {
                Console.Write("\nEnter First Number: ");

                if (double.TryParse(Console.ReadLine(), out num1))
                    break;

                Console.WriteLine("❌ Invalid number!");
            }

            // Second Number
            while (true)
            {
                Console.Write("Enter Second Number: ");

                if (double.TryParse(Console.ReadLine(), out num2))
                    break;

                Console.WriteLine("❌ Invalid number!");
            }

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("\n❌ Cannot divide by zero.");
                        Console.ReadKey();
                        continue;
                    }
                    result = num1 / num2;
                    break;

                case 5:
                    result = (num1 * num2) / 100;
                    break;

                case 7:
                    result = Math.Pow(num1, 2);
                    break;

                default:
                    Console.WriteLine("\n❌ Invalid option.");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine($"Answer = {result}");
            Console.WriteLine("====================================");

            Console.WriteLine();
            Console.Write("Do another calculation? (Y/N): ");

            string answer = Console.ReadLine() ?? "";

            if (answer.ToUpper() != "Y")
            {
                continueCalculator = false;
            }
        }

        Console.WriteLine("\nGoodbye!");
    }
}