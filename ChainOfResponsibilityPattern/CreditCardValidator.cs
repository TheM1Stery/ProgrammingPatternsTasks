namespace ChainOfResponsibilityPattern;

public class CreditCardValidator : ICreditСardValidator
{
    private readonly NumberCardVerificationHandler _numberHandler = new();
    private readonly NameCardVerificationHandler _nameHandler = new();
    private readonly SurnameCardVerificationHandler _surnameHandler = new();
    private readonly ExpirationDateCardVerificationHandler _dateHandler = new();


    public CreditCardValidator()
    {
        _numberHandler.SetNext(_nameHandler).SetNext(_surnameHandler).SetNext(_dateHandler);
    }
    
    public CardVerificationResponse Validate(CreditCard card)
    {
        return _numberHandler.Handle(card);
    }
}