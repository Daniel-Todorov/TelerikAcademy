using System;

/// <summary>
/// Contains a method that prints the max, min and avarage value of a set in values by given range
/// </summary>
class Statistics
{
    /// <summary>
    /// Prints the min, max and avarage values in a set of values by given range
    /// </summary>
    /// <param name="values">Set of values</param>
    /// <param name="checkRange">Number of values to be included in the statistics</param>
    public static void PrintStatistics(double[] values, int checkRange)
    {
        double maxValue = Double.MinValue;
        for (int i = 0; i < checkRange; i++)
        {
            if (values[i] > maxValue)
            {
                maxValue = values[i];
            }
        }
        PrintMax(maxValue);

        double minValue = Double.MaxValue;
        for (int i = 0; i < checkRange; i++)
        {
            if (values[i] < minValue)
            {
                minValue = values[i];
            }
        }
        PrintMin(minValue);

        double totalSum = 0.0;
        for (int i = 0; i < checkRange; i++)
        {
            totalSum += values[i];
        }
        PrintAvarage(totalSum / checkRange);
    }
}