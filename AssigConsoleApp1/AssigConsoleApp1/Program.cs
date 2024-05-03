// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//

// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;


int choice;
string anotherCalculation;
do
{

    // Choose The Type Of Calculator
    Console.WriteLine("Welcome to the Multifunction Calculator!..");
    Console.WriteLine("Please choose the type of calculator:");
    Console.WriteLine("1. Normal Calculator");
    Console.WriteLine("2. Scientific Calculator");


    Console.Write("Enter your choice (1/2): ");
    choice = Int32.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            PerformNormalCalculation();
            break;
        case 2:
            PerformScientificCalculation();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;


    }

    // Perform Another Calculation? Y/N //
    Console.WriteLine("Do you want to perform another calculation ? (Y / N) : ");

    anotherCalculation = Console.ReadLine().Trim().ToUpper();

}
while (anotherCalculation == "Y");
Console.WriteLine("Thank you for using the Calculator App!");

// Perform Normal Calculation //
static void PerformNormalCalculation()
{
    Console.WriteLine("Enter the first number: ");
    int num1 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number: ");
    int num2 = Int32.Parse(Console.ReadLine());

    // Normal Calculator Operators //
    Console.WriteLine("Choose the operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.Write("Enter your choice (1/2/3/4): ");

    int operationChoice;
    while (!int.TryParse(Console.ReadLine(), out operationChoice) || operationChoice < 1 || operationChoice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
        Console.Write("Enter your choice (1/2/3/4): ");
    }

    double result = 0;
    switch (operationChoice)
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
                Console.WriteLine("Error: Division by zero!");
                return;
            }
            result = num1 / num2;
            break;

        default:
            Console.WriteLine("Invalid numbers.. ");
            break;
    }

    Console.WriteLine($"Result: {result}");
}

// Perform Scientific Calculation //
static void PerformScientificCalculation()
{
    Console.WriteLine("Enter the number: ");
    int num = Int32.Parse(Console.ReadLine());

    // Scientific Calculator Operators //
    Console.WriteLine("Choose the operation:");
    Console.WriteLine("1. Exponentiation");
    Console.WriteLine("2. Square root");
    Console.WriteLine("3. Logarithm (base 10)");
    Console.WriteLine("4. Sine");
    Console.WriteLine("5. Cosine");
    Console.WriteLine("6. Tangent");
    Console.Write("Enter your choice (1/2/3/4/5/6): ");

    int operationChoice;
    while (!int.TryParse(Console.ReadLine(), out operationChoice) || operationChoice < 1 || operationChoice > 6)
    {
        Console.WriteLine("Invalid number. Please enter a number between 1 and 6.");
        Console.Write("Enter your choice (1/2/3/4/5/6): ");
    }

    double result = 0;
    switch (operationChoice)
    {
        case 1:
            Console.WriteLine("Enter the exponent: ");
            double exponent = GetUserInputNumber();
            result = Math.Pow(num, exponent);
            break;
        case 2:
            if (num < 0)
            {
                Console.WriteLine("Error: Square root of a negative number!");
                return;
            }
            result = Math.Sqrt(num);
            break;
        case 3:
            if (num <= 0)
            {
                Console.WriteLine("Error: Logarithm of a non-positive number!");
                return;
            }
            result = Math.Log10(num);
            break;
        case 4:
            result = Math.Sin(num);
            break;
        case 5:
            result = Math.Cos(num);
            break;
        case 6:
            result = Math.Tan(num);
            break;
        default:
            Console.WriteLine("Invalid values.. ");
            break;
    }

    Console.WriteLine($"Result: {result}");
}

static double GetUserInputNumber()
{
    double number;
    while (!double.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("Invalid input. Please enter a valid number.");
        Console.Write("Enter the number: ");
    }
    return number;
}
