using System;

class Program
{
    static void Main(string[] args)
    {
        var manager = new TransactionManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add Transaction");
            Console.WriteLine("2. List Transactions");
            Console.WriteLine("3. Delete Transaction");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTransactionUI(manager);
                    break;
                case "2":
                    manager.ListTransactions();
                    break;
                case "3":
                    DeleteTransactionUI(manager);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    static void AddTransactionUI(TransactionManager manager)
    {
        Console.Write("Enter type (Income/Expense): ");
        var type = Console.ReadLine();

        Console.Write("Enter amount: ");
        var amount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter description: ");
        var description = Console.ReadLine();

        manager.AddTransaction(type, amount, description);
        Console.WriteLine("Transaction added successfully.");
    }

    static void DeleteTransactionUI(TransactionManager manager)
    {
        Console.Write("Enter transaction ID to delete: ");
        var id = Convert.ToInt32(Console.ReadLine());

        manager.DeleteTransaction(id);
    }
}
