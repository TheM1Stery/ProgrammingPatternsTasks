namespace ChainOfResponsibilityPattern;

public interface ICreditCardPinHandler
{
    ICreditCardPinHandler SetNext(ICreditCardPinHandler handler);

    bool Handle(CreditCard card, int pinCode);
}