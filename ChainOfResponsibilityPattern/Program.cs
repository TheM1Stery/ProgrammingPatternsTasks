using ChainOfResponsibilityPattern;

var card = new CreditCard()
{
    Name = "Seymur",
    Surname = "Bagirov",
    ExpirationDate = DateTime.Now + TimeSpan.FromDays(10),
    Number = "123"
};

var validator = new CreditCardValidator();

switch (validator.Validate(card))
{
    case CardVerificationResponse.Success:
        Console.WriteLine("Success");
        break;
    case CardVerificationResponse.NameError:
        Console.WriteLine("Error in the name");
        break;
    case CardVerificationResponse.NumberError:
        Console.WriteLine("Error in the number");
        break;
    case CardVerificationResponse.SurnameError:
        Console.WriteLine("Error in the surname");
        break;
    case CardVerificationResponse.DateError:
        Console.WriteLine("Your card is outdated");
        break;
    default:
        throw new ArgumentException("couldn't process card");
}