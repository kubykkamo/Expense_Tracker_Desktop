
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Transactions;

namespace Expense_Tracker_Desktop;

public class Account
{
    
    public List<Transaction> Transactions{ get; set; }
    public List<Category> Categories { get; set; }
    private const string filePath = "account_data.json";

    public List<Category> GetAllCategories()
    {
        return Categories;
    }

    public List<Transaction> GetAllTransactions() 
    {

        return Transactions;
    }
    public void AddTransaction(string desc, decimal amount, bool isIncome, Category category) 
    {
        
        var transaction = new Transaction(desc, amount, isIncome, category);
        Transactions.Add(transaction);
    }
    public string Name { get; set; }
    public decimal TotalIncome => Transactions
        .Where(t => t.IsIncome == true)
        .Sum(t => t.Amount);
    public decimal TotalOutcome => Transactions
        .Where(t => t.IsIncome == false)
        .Sum(t => t.Amount);
    public decimal Balance => TotalIncome - TotalOutcome;



    public Account(List<Transaction> transactions, List<Category> categories)
    {
        Transactions = transactions;
        Categories = categories;
        foreach (var t in transactions)
        {

            t.Category = Categories.FirstOrDefault(c => c.Name == t.CategoryName);
        }



    }

    public List<Transaction> GetSortedTransactions(SortType sortType) 
    {
        return sortType switch
        {
            SortType.ByDateDesc => Transactions.OrderByDescending(t => t.Date).ToList(),
            SortType.ByDateAsc => Transactions.OrderBy(t => t.Date).ToList(),
            SortType.ByNameDesc => Transactions.OrderByDescending(t => t.Description).ToList(),
            SortType.ByNameAsc => Transactions.OrderBy(t => t.Description).ToList(),
            SortType.ByAmountDesc => Transactions.OrderByDescending(t => t.Amount).ToList(),
            SortType.ByAmountAsc => Transactions.OrderBy(t => t.Amount).ToList(),
            _=> Transactions.ToList()
        };

    }

    public List<Transaction> DateOrderedTransactions() 
    { 
        return Transactions
            .OrderByDescending(t => t.Date)
            .ToList();
    }
    public List<Transaction> SortByIncome()
    {
        var transactions = Transactions
            .GroupBy(t => t.IsIncome)
            .SelectMany(g => g.OrderByDescending(t => t.Date))
            .ToList();
        return transactions;
    }

    public List <Transaction> GetFilteredTransactions(Category category)
    {
        return Transactions
            .Where(t => t.Category == category)
            .OrderByDescending(t => t.Date)
            .ToList();
    }
}