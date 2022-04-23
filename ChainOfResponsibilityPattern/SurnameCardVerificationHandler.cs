namespace ChainOfResponsibilityPattern;

public class SurnameCardVerificationHandler : BaseCardVerificationHandler
{
    public override CardVerificationResponse Handle(CreditCard card)
    {
        var value = card.Surname != null && card.Surname.Any(x => !char.IsLetter(x));
        // if (NextHandler == null)
        // {
        //     return !value;
        // }
        // return !value && NextHandler.Handle(card);
        if (NextHandler == null)
            return !value ? CardVerificationResponse.Success : CardVerificationResponse.SurnameError;
        return value ? CardVerificationResponse.SurnameError : NextHandler.Handle(card);
    }
}