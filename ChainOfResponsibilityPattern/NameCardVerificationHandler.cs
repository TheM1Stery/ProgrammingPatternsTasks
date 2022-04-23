namespace ChainOfResponsibilityPattern;

public class NameCardVerificationHandler : BaseCardVerificationHandler
{
    public override CardVerificationResponse Handle(CreditCard card)
    {
        var value = card.Name != null && card.Name.Any(x => !char.IsLetter(x));
        // if (NextHandler == null)
        // {
        //     return !value;
        // }
        // return !value && NextHandler.Handle(card);
        if (NextHandler == null)
            return !value ? CardVerificationResponse.Success : CardVerificationResponse.NameError;
        
        return value ? CardVerificationResponse.NameError: NextHandler.Handle(card);
    }
}