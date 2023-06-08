Console.WriteLine(" Wellcome to simple caculater");
Console.WriteLine();
BankApp account = new BankApp();
bool states = false;
while (!states)
{
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice (1-3):");
    Console.WriteLine();
    string choice = Console.ReadLine();
    Console.WriteLine();
    switch (choice)
    {
        case "1":
            Console.Write("Enter the deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(depositAmount);
            break;
        case "2":
            Console.Write("Enter the withdrawal amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
            break;
        case "3":
            states = true;
            break;
        default:
            Console.WriteLine("Error: Invalid operator!");
            break;
    }
}
class BankApp
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}, Current balance: {balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}, Current balance: {balance}");

        }
        else
        {
            Console.WriteLine($"Can not withdraw froة your account because your balance:{balance}, but you need {amount}");
            ;
        }
    }
}

