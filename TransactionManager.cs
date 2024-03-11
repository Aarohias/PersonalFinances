using System;
using System.Collections.Generic;
using System.Linq;

public class TransactionManager
{
    private List<Transaction> transactions = new List<Transaction>();
    private int nextId = 1;

    public void AddTransaction(string type, decimal amount, string description)
    {
        var transaction = new Transaction(nextId++, type, amount, description, DateTime.Now);
        transactions.Add(transaction);
    }

    public void ListTransactions()
    {
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"ID: {transaction.Id}, Type: {transaction.Type}, Amount: {transaction.Amount}, Description: {transaction.Description}, Date: {transaction.Date}");
        }
    }

    public void DeleteTransaction(int id)
    {
        var transaction = transactions.FirstOrDefault(t => t.Id == id);
        if (transaction != null)
        {
            transactions.Remove(transaction);
            Console.WriteLine("Transaction deleted successfully.");
        }
        else
        {
            Console.WriteLine("Transaction not found.");
        }
    }
}
