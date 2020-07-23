using System;

public class IsPalindrome
{
	public IsPalindrome(string[] word)
	{
        int min = 0;
        int max = word.Length - 1;
        while (true)
        {
            if (min > max)
            {

                true;
            }
            char first = word[min];
            char last = word[max];

            if (char.ToLower(first) != char.ToLower(last))
            {
                return false;
            }
            min++;
            max--;

          
        }
	}

    public static void main()
    {
        string[] words = { "kayak","appa","Civic","Hannah","radar","Level", "Rati"};

        foreach (string letter in words)
        {
            Console.WriteLine("{0}={1}", letter, IsPalindrome(letter));
        }
    }
}
