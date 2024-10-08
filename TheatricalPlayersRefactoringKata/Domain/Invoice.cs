using System.Collections.Generic;
namespace TheatricalPlayersRefactoringKata.Domain;

public class Invoice
{
    public string Customer { get; }
    public List<Performance> Performances { get; }

    public Invoice(string customer, List<Performance> performances)
    {
        Customer = customer;
        Performances = performances;
    }
}