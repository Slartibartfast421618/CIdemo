using CIdemo1;

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new CalculatorImplementation();
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. Square Root");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformAddition(calculator);
                    break;
                case "2":
                    PerformSubtraction(calculator);
                    break;
                case "3":
                    PerformMultiplication(calculator);
                    break;
                case "4":
                    PerformDivision(calculator);
                    break;
                case "5":
                    PerformPower(calculator);
                    break;
                case "6":
                    PerformSquareRoot(calculator);
                    break;
                case "7":
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the calculator. Press any key to exit...");
        Console.ReadKey();
    }

    static void PerformAddition(ICalculator calculator)
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {calculator.Add(a, b)}");
    }

    static void PerformSubtraction(ICalculator calculator)
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {calculator.Subtract(a, b)}");
    }

    static void PerformMultiplication(ICalculator calculator)
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {calculator.Multiply(a, b)}");
    }

    static void PerformDivision(ICalculator calculator)
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine($"Result: {calculator.Divide(a, b)}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void PerformPower(ICalculator calculator)
    {
        Console.Write("Enter base number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {calculator.Power(a, b)}");
    }

    static void PerformSquareRoot(ICalculator calculator)
    {
        Console.Write("Enter number: ");
        double a = double.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine($"Result: {calculator.SquareRoot(a)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
