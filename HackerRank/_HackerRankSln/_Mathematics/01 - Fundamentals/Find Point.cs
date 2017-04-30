using System;

// https://www.hackerrank.com/challenges/find-point

public static class Find_Point
{
    // Given two points P and Q, output the symmetric point of point P about Q

    // Point Symmetry is when every part has a matching part:
    // Same distance from the central point, but in the opposite direction.

    public static void FindPoint()
    {
        int T = Convert.ToInt32(Console.ReadLine());

        while (T-- != 0)
        {
            string[] tempArray = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(tempArray, int.Parse);
            int Px = ar[0];
            int Py = ar[1];
            int Qx = ar[2];
            int Qy = ar[3];

            int distanceX = Qx - Px;
            int distanceY = Qy - Py;
            int Rx = Qx + distanceX;
            int Ry = Qy + distanceY;

            Console.WriteLine(Rx + " " + Ry);
        }
    }
}