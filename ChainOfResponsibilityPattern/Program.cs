using ChainOfResponsibilityPattern;

var card = new CreditCard("123", "Seymur", "Bagirov", DateTime.Now + TimeSpan.FromDays(10), 1337)
{
    Money = 100
};
var validator = new CreditCardValidator();
switch (validator.Validate(card))
{
    case CardVerificationResponse.Success:
        Console.WriteLine("Success");
        break;
    case CardVerificationResponse.NameError:
        Console.WriteLine("Error in the name");
        return;
    case CardVerificationResponse.NumberError:
        Console.WriteLine("Error in the number");
        return;
    case CardVerificationResponse.SurnameError:
        Console.WriteLine("Error in the surname");
        return;
    case CardVerificationResponse.DateError:
        Console.WriteLine("Your card is outdated");
        return;
    default:
        throw new ArgumentException("couldn't process card");
}
var pin = 1337;
var handler = new CreditCardPinHandler();
Console.WriteLine("Entering pin..");
Thread.Sleep(100);
if (!handler.Handle(card, pin))
{
    Console.WriteLine("Wrong pin! Terminating the program");
    return;
}
Console.WriteLine("Pin entered correctly!");
var moneyHandler = new MoneyWithdrawalHandler();
var money = 99;
if (!moneyHandler.Handle(card, money))
{
    Console.WriteLine("Cannot withdraw this amount of money");
    return;
}
card.Money -= money;
Console.WriteLine("Money withdrawn successfully");