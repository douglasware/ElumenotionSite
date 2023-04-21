using System;
using System.Collections.Generic;

public class WeightedRandomSelection
{
    /// <summary>
    /// Selects an item from the given list based on the customizable parameters.
    /// </summary>
    /// <typeparam name="T">The type of items in the list.</typeparam>
    /// <param name="items">A list of items to be processed.</param>
    /// <param name="centerPercentage">A center percentage for the peak of the bell curve between 0 and 1.</param>
    /// <param name="centerHeight">A center height for the center of the bell curve between 0 and 0.95.</param>
    /// <param name="scalingFactor">A scaling factor for adjusting the standard deviation between 0 and 10.</param>
    /// <returns>A selected item from the list.</returns>
    /// <exception cref="ArgumentException">Thrown when input parameters are invalid.</exception>
    public static T SelectItem<T>(List<T> items, double centerPercentage, double centerHeight, double scalingFactor)
    {
        ValidateInput(centerPercentage, centerHeight, scalingFactor);

        int itemCount = items.Count;
        int centerIndex = (int)Math.Floor(itemCount * centerPercentage);
        double[] weights = CalculateWeights(itemCount, centerIndex, centerHeight, scalingFactor);

        return SelectWeightedItem(items, weights);
    }

    private static void ValidateInput(double centerPercentage, double centerHeight, double scalingFactor)
    {
        if (centerPercentage < 0 || centerPercentage > 1)
        {
            throw new ArgumentException("Center percentage must be between 0 and 1.");
        }

        if (centerHeight < 0 || centerHeight > 0.95)
        {
            throw new ArgumentException("Center height must be between 0 and 0.95.");
        }

        if (scalingFactor < 0 || scalingFactor > 10)
        {
            throw new ArgumentException("Scaling factor must be between 0 and 10.");
        }
    }

    private static double[] CalculateWeights(int itemCount, int centerIndex, double centerHeight, double scalingFactor)
    {
        double[] weights = new double[itemCount];
        double stdDev = itemCount / scalingFactor;

        for (int i = 0; i < itemCount; i++)
        {
            double x = i - centerIndex;
            double exponent = -(x * x) / (2 * stdDev * stdDev);
            weights[i] = centerHeight * Math.Exp(exponent);
        }

        return weights;
    }

    private static T SelectWeightedItem<T>(List<T> items, double[] weights)
    {
        double totalWeight = 0;
        foreach (double weight in weights)
        {
            totalWeight += weight;
        }

        double randomValue = new Random().NextDouble() * totalWeight;
        double accumulatedWeight = 0;
        int selectedIndex = 0;

        for (int i = 0; i < weights.Length; i++)
        {
            accumulatedWeight += weights[i];
            if (randomValue <= accumulatedWeight)
            {
                selectedIndex = i;
                break;
            }
        }

        return items[selectedIndex];
    }
}
