Console.WriteLine("Enter an integer value between 5 and 10");
bool validNumber = false;
string? readNumber;
int resultNumber = 0;

do
{
    readNumber = Console.ReadLine();

    if (readNumber == null) continue;

    validNumber = int.TryParse(readNumber, out resultNumber);

    if (!validNumber)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    else if (resultNumber < 5 || resultNumber > 10)
    {
        Console.WriteLine($"You entered {resultNumber}. Please enter a number between 5 and 10.");
        validNumber = false;
    }
} while (!validNumber);

Console.WriteLine($"Your input value ({resultNumber}) has been accepted.");