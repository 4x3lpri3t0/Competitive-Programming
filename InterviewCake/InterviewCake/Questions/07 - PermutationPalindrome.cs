using System.Collections.Generic;

public class _07___PermutationPalindrome
{
    // This version also uses linear time and linear space, BUT...
    // It just needs one pass, and it requires same or less space
    // (When we find same character we remove it from the set)
    public static bool HasPalindromePermutation_2(string theString)
    {
        // Track characters we've seen an odd number of times
        var unpairedCharacters = new HashSet<char>();

        foreach (char c in theString)
        {
            if (unpairedCharacters.Contains(c))
            {
                unpairedCharacters.Remove(c);
            }
            else
            {
                unpairedCharacters.Add(c);
            }
        }

        // The string has a palindrome permutation if it
        // has one or zero characters without a pair
        return unpairedCharacters.Count <= 1;
    }

    public static bool HasPalindromePermutation(string input)
    {
        // Iterate/Populate hash table with char->frequency
        var charFrequency = new Dictionary<char, int>();
        foreach (char character in input)
        {
            if (!charFrequency.ContainsKey(character))
            {
                charFrequency.Add(character, 0);
            }

            charFrequency[character]++;
        }

        // For every char, frequency should be even
        // If odd, allow only one (use aux bool)
        bool alreadyFoundOdd = false;
        foreach (var keyValuePair in charFrequency)
        {
            if (keyValuePair.Value % 2 == 0)
                continue; // Even

            if (alreadyFoundOdd)
                return false;

            // We allow this odd occurrence
            alreadyFoundOdd = true;
        }

        return true;
    }

    /*
     * We could say our space cost is O(n) as well,
     * since the set of unique characters is less than or equal to n.
     * But we can also look at it this way:
     * There are only so many different characters. How many?
     * The ASCII character set has just 128 different characters,
     * while Unicode has 110,000 (supporting several languages and symbols).
     * We might want to treat our number of possible characters in our character
     * hash set as another variable kkk and say our space complexity is O(k).
     * Or we might want to just treat it as a constant, and say our space complexity
     * is O(1). 
     */
}
