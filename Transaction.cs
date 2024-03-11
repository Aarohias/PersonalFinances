public class Transaction
{
    public int Id { get; set; }
    public string Type { get; set; } // "Income" or "Expense"
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public Transaction(int id, string type, decimal amount, string description, DateTime date)
    {
        Id = id;
        Type = type;
        Amount = amount;
        Description = description;
        Date = date;
    }
}
