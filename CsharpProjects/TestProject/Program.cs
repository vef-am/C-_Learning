// Add looping logic to your code using the do-while and while statements in C#
// Unit 5
// Exercise - Complete a challenge activity to differentiate between do and while iteration statements


/* Code project 1 - write code that validates integer input

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
*/


/* Exercise - Complete a challenge activity to differentiate between do and while iteration statements

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

bool validRole = false;
string? readRole;

do
{
    readRole = Console.ReadLine();

    if (readRole == null) continue;

    readRole = readRole.Trim();
    string checkRole = readRole.ToLower();
    if (checkRole == "administrator" || checkRole == "manager" || checkRole == "user") validRole = true;
    else Console.WriteLine($"The role name that you entered, \"{readRole}\" is not valid. Enter your role name (Administrator, Manager, or User)");
} while (!validRole);

Console.WriteLine($"Your input value ({readRole}) has been accepted.");
*/


// Code project 3 - Write code that processes the contents of a string array

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf('.');
    string next = myString;
    do
    {
        string result = next.Remove(periodLocation);
        Console.WriteLine(result);
        next = next.Substring(periodLocation + 2);
        periodLocation = next.IndexOf('.');
    } while (periodLocation != -1);
}