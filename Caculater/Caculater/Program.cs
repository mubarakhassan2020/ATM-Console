Console.WriteLine(" Wellcome to simple caculater");
Console.WriteLine();
bool state = false;
while (!state)
{
    
    Console.WriteLine("1. Do operation");
    Console.WriteLine("2. Exit");
    Console.Write("Enter your choice (1-2):");
    Console.WriteLine();
    string choice = Console.ReadLine();

    Console.WriteLine();
    switch (choice)
    {
        case "1":
            Assign1();

            break;
        case "2":
            ;
            state = true;
            Console.WriteLine(" Good Bye , See you later ");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
static void Assign1()
{
        double num1, num2, result;
        Char operation;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operator (+, -, *, /): ");
        if (!char.TryParse(Console.ReadLine(), out operation))
        {
            Console.WriteLine("Error: Invalid input for the operator!");
            return;
        }
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator!");
                break;
        }
 }