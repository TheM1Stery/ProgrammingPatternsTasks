namespace ChainOfResponsibilityPattern;



public class CreditCardPinHandler : ICreditCardPinHandler
{
    private ICreditCardPinHandler? _next;
    
    
    public ICreditCardPinHandler SetNext(ICreditCardPinHandler handler)
    {
        _next = handler;
        return _next;
    }

    public bool Handle(CreditCard card, int pinCode)
    {
        var value = card.PinCode == pinCode;
        if (_next == null)
            return value;
        return value && _next.Handle(card, pinCode);
    }
}