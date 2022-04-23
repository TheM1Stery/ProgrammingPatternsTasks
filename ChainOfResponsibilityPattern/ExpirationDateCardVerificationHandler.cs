namespace ChainOfResponsibilityPattern;

public class ExpirationDateCardVerificationHandler : BaseCardVerificationHandler
{
    public override CardVerificationResponse Handle(CreditCard card)
    {
        var value = card.ExpirationDate > DateTime.Now;
        // if (NextHandler == null)
        // {
        //     return value;
        // }
        // return value && NextHandler.Handle(card);
        if (NextHandler == null)
            return value ? CardVerificationResponse.Success : CardVerificationResponse.DateError;
        return value ? CardVerificationResponse.DateError : NextHandler.Handle(card);
    }
}