using System.Text;

namespace ReverseWords
{
  internal class Program
  {
    private static void Main()
    {
      // Get Input
      Console.WriteLine("Please enter an input: ");
      string? input = Console.ReadLine();

      if (input is not null)
      {
        string[] words = input.Split(" ");

        // Reverse each word in input and print result
        StringBuilder stringBuilder = new();
        foreach (var item in words)
        {
          string reverseWord = ReverseWord(item);
          stringBuilder.Append(reverseWord);
          stringBuilder.Append(' ');
        }
        Console.WriteLine(stringBuilder.ToString());
      }
      else Console.WriteLine("Given input is wrong!");
    }

    private static string ReverseWord(string word)
    {
      // Create String Builder for efficient append operation in string
      StringBuilder stringBuilder = new();

      // Reverse String
      if (word is not null)
      {
        char[] chars = word.ToCharArray();

        for (int i = word.Length - 1; i >= 0; i--)
          stringBuilder.Append(chars[i]);

        return stringBuilder.ToString();
      }
      else return "";
    }
  }
}