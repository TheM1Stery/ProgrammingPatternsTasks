namespace ChainOfResponsibilityPattern;

public interface IMoneyWithdrawalHandler
{
    IMoneyWithdrawalHandler SetNext(IMoneyWithdrawalHandler handler);

    bool Handle(CreditCard card, int money);
}