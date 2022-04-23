namespace ChainOfResponsibilityPattern;

public abstract class BaseCardVerificationHandler : ICardVerificationHandler
{
    protected ICardVerificationHandler? NextHandler;

    public ICardVerificationHandler SetNext(ICardVerificationHandler handler)
    {
        NextHandler = handler;
        return NextHandler;
    }

    public abstract CardVerificationResponse Handle(CreditCard card);
}