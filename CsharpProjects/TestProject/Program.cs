/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] modifiedMessage = originalMessage.ToCharArray();
Array.Reverse(modifiedMessage);

int letterCount = 0;
foreach (char i in modifiedMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string finalMessage = new String(modifiedMessage);
Console.WriteLine(finalMessage);

Console.WriteLine($"'o' appears {letterCount} times.");