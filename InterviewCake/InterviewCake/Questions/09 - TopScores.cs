public class _09___TopScores
{
    public static int[] GetOrderedScores(int[] scores, int highestPossibleScore)
    {
        // Assuming 0 is always the lowest possible score
        // (Elements initialized by default as zeroes in C#)
        int[] scoreCounts = new int[highestPossibleScore + 1];

        // Count appearences
        foreach (int score in scores)
        {
            scoreCounts[score]++;
        }

        // Overwrite scores array with proper sorted numbers
        int currentIndex = 0;
        for (int i = 0; i < scoreCounts.Length; i++)
        {
            // For the number of times the item occurs
            while (scoreCounts[i] > 0)
            {
                // Add it to the sorted array
                scores[currentIndex] = i;
                currentIndex++;
                scoreCounts[i]--;
            }
        }

        return scores;
    }
}
// O(n+k) time and O(k) extra space
// (Last nested loop runs once for each unique number in the array)