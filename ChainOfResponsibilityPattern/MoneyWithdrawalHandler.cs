namespace ChainOfResponsibilityPattern;

public class MoneyWithdrawalHandler : IMoneyWithdrawalHandler
{
    private IMoneyWithdrawalHandler? _handler;
    public IMoneyWithdrawalHandler SetNext(IMoneyWithdrawalHandler handler)
    {
        _handler = handler;
        return _handler;
    }

    public bool Handle(CreditCard card, int money)
    {
        var value = (card.Money - money) >= 0;
        if (_handler == null)
            return value;
        return value && _handler.Handle(card, money);
    }
}