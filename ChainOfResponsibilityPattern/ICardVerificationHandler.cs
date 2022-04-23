namespace ChainOfResponsibilityPattern;

public interface ICardVerificationHandler
{
    ICardVerificationHandler SetNext(ICardVerificationHandler handler);
    CardVerificationResponse Handle(CreditCard card);
}