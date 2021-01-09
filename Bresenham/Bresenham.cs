using System;
using System.Collections.Generic;

public class Bresenham
{
    public static IEnumerable<ValueTuple<int, int>> New(ValueTuple<int, int> p0, ValueTuple<int, int> p1)
    {
        return New(p0.Item1, p0.Item2, p1.Item1, p1.Item2); // Just unwrap the tuples and call the method that takes separate params.
    }

    public static IEnumerable<ValueTuple<int, int>> New(int x0, int y0, int x1, int y1)
    {
        // Calculate differences (deltas) between the two points.
        int deltaX = Math.Abs(x1 - x0);
        int deltaY = -Math.Abs(y1 - y0);

        // Calculate slopes.
        int slopeX = x0 < x1 ? 1 : -1;
        int slopeY = y0 < y1 ? 1 : -1;

        // Variable for accumulating error.
        int error = deltaX + deltaY;

        // Loop where we calculate and return the points for the line.
        while (true)
        {
            yield return (x0, y0); // Return the point for the iteration to for example plot in a bitmap.
            if (x0 == x1 && y0 == y1) yield break; // Break if we are out of the loop

            int error_2 = error * 2; // Make a temporary variable for comparing.

            // If we have accumulated enough error increment x by its slope value.
            if (error_2 >= deltaY)
            {
                error += deltaY;
                x0 += slopeX;
            }

            // Likewise for y.
            if(error_2 <= deltaX)
            {
                error += deltaX;
                y0 += slopeY;
            }
        }
    }
}