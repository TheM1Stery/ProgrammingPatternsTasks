namespace ChainOfResponsibilityPattern;

public record CreditCard(string? Number, string? Name, string? Surname, DateTime? ExpirationDate, int PinCode)
{
    public int Money { get; set; }
};