using System.Collections.Generic;

public class _06___InflightEntertainment
{
    public static bool TwoMoviesExist(int flightLength, int[] movies)
    {
        // Complements
        var movieLengthsSet = new HashSet<int>();

        // Iterate, check if complement exist, populate complement
        for (int i = 0; i < movies.Length; i++)
        {
            if (movies[i] >= flightLength)
                continue;

            int complement = flightLength - movies[i];
            if (movieLengthsSet.Contains(complement))
                return true;

            movieLengthsSet.Add(movies[i]);
        }

        return false;
    }
}
