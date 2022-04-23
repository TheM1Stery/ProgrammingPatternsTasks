namespace ChainOfResponsibilityPattern;

public class NumberCardVerificationHandler : BaseCardVerificationHandler
{
    public override CardVerificationResponse Handle(CreditCard card)
    {
        var value = card.Number != null && card.Number.Any(x => !char.IsDigit(x));
        // if (NextHandler == null)
        // {
        //     return !value;
        // }
        // return !value && NextHandler.Handle(card);
        if (NextHandler == null)
        {
            return !value ? CardVerificationResponse.Success : CardVerificationResponse.NumberError;
        }
        
        return value ? CardVerificationResponse.NumberError : NextHandler.Handle(card);
    }
}