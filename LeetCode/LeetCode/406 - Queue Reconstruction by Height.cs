using System;
using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/queue-reconstruction-by-height/
public partial class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        // Order first by height, then people in front
        var sortedPeople = people.OrderByDescending(h => h[0]).ThenBy(p => p[1]);
        var result = new List<int[]>();
        foreach (var person in sortedPeople)
            result.Insert(person[1], person);

        // Order of insertion:
        // [[7,0]]
        // [[7,0], [7,1]]
        // [[7,0], [6,1], [7,1]]
        // [[5,0], [7,0], [6,1], [7,1]]
        // [[5,0], [7,0], [5,2], [6,1], [7,1]]
        // [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]

        return result.ToArray();
    }

    public int[][] ReconstructQueue_Alt(int[][] people)
    {

        // Custom sort the array by height, then by k value
        Array.Sort(people, (x, y) =>
        {
            // Note x and y are of type int[]

            // If the heights are different, return descending height order y - x
            if (x[0] != y[0])
            {
                return y[0] - x[0];
            }

            // If heights are the same, return ascending k order x - y
            return x[1] - y[1];
        });

        // So in our example: [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
        // Sorted order will be: [[7,0], [7,1], [6,1], [5,0], [5,2], [4,4]]

        // From the tallest person to the shortest person, insert them by their k value into the array
        // This works because at a given height, we know all elements in the current array are taller
        // So just insert them at index k so that it satisfies the requirement that there are k people in front that have equal or greater height
        var result = new List<int[]>();
        foreach (var person in people)
        {
            // Note we don't have the check the bounds of the index to insert (person[1]), because we have already sorted by height
            // So it is impossible for the tallest person to have a k != 0, unless there is also a person with the same height, which is sorted
            // after the person with k = 0
            result.Insert(person[1], person);
        }

        // Order of insertion:
        // [[7,0]]
        // [[7,0], [7,1]]
        // [[7,0], [6,1], [7,1]]
        // [[5,0], [7,0], [6,1], [7,1]]
        // [[5,0], [7,0], [5,2], [6,1], [7,1]]
        // [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]

        return result.ToArray();
    }
}
