namespace ChainOfResponsibilityPattern;

public interface ICreditСardValidator
{
    public CardVerificationResponse Validate(CreditCard card);
}