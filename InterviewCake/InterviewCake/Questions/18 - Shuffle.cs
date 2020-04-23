using System;

// Fisher-Yates shuffle (aka Knuth shuffle)
class _18___Shuffle
{
    private static Random _rand = new Random();

    private static int GetRandom(int floor, int ceiling)
    {
        return _rand.Next(floor, ceiling + 1);
    }

    public static void Shuffle(int[] array)
    {
        // If it's 1 or 0 items, just return
        if (array.Length <= 1)
            return;

        // Walk through from beginning to end
        for (int targetIndex = 0; targetIndex < array.Length - 1; targetIndex++)
        {
            // Choose a random not-yet-placed item to place there
            // (could also be the item currently in that spot).
            // Must be an item AFTER the current item, because the stuff
            // before has all already been placed
            int randomChoiceIndex = GetRandom(targetIndex, array.Length - 1);

            // Place our random choice in the spot by swapping
            if (randomChoiceIndex != targetIndex)
            {
                int valueAtIndexWeChoseFor = array[targetIndex];
                array[targetIndex] = array[randomChoiceIndex];
                array[randomChoiceIndex] = valueAtIndexWeChoseFor;
            }
        }
    }
}
