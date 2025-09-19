/*
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
*/

/*
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    return (int) (usd * 23500);
}

double VndToUsd(int vnd)
{
    return vnd / 23500.0;
}
*/

/*
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(' ');
    for (int i = 0; i < words.Length; ++i)
    {
        result += ReverseWord(words[i]) + ' ';
    }
    return result.Trim();
}
*/

/*
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
*/

/*
int target = 80;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions:");
    for (int i = 0; i < result.GetLength(0); ++i)
    {
        if (result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                ++count;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }

    /*
    if (count == 0)
    {
        return new int[0, 0];
    }
    return result;
    
return (count == 0) ? new int[0, 0] : result;
}
*/

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}

bool ShouldPlay()
{
    string? inputMessage;
    string answer = "";

    bool validText = false;
    bool play = false;
    while (!validText)
    {
        inputMessage = Console.ReadLine();

        if (inputMessage != null)
        {
            answer = inputMessage.ToLower();
        }

        answer = answer.Trim();
        answer = answer.Remove(1);
        if (answer == "y")
        {
            play = true;
            validText = true;
        }
        else if (answer == "n")
        {
            play = false;
            validText = true;
        }
        else
        {
            Console.WriteLine("Wrong input. (Y/N)");
        }
    }

    return play;
}