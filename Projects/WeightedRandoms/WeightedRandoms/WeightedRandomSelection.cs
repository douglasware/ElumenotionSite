using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// The WeightedRandomSelection class provides a method for selecting an item from a list based on a weighted random selection algorithm.
/// The weights are calculated based on a normal distribution with the peak at a specified percentage position in the range and with a specified height for the center that adjusts the shape of the curve.
/// The width of the normal distribution can also be adjusted using a specified scaling factor.
/// </summary>
public class WeightedRandomSelection
{
    /// <summary>
    /// A static random number generator initialized with the current time in milliseconds.
    /// </summary>
    static Random random = new Random(DateTime.Now.Millisecond);

    /// <summary>
    /// Selects an item from a list based on a weighted random selection algorithm using a normal distribution.
    /// </summary>
    /// <typeparam name="T">The type of the items in the list.</typeparam>
    /// <param name="items">The list of items to select from.</param>
    /// <param name="centerPercentage">The position of the peak of the normal distribution as a percentage of the range. Must be between 0 and 1.</param>
    /// <param name="centerHeight">The height of the center of the normal distribution. Must be between 0 and 0.95.</param>
    /// <param name="scaleFactor">The scaling factor adjusts the standard deviation of the normal distribution. Values less than 1 increase the value making items further from the center more probable.
    /// Values greater than 1 make items less likely to be selected the farther they are from the center.
    /// Use this parameter to adjust the selectable width of the normal distribution.
    /// </param>
    /// <remarks>As the behavior of this method is based on a random number generator and lists of arbitrary length, the results will vary from run to run.
    /// For a uniform and fast selection of an item from a list, use Random directly. But if you need to effect the curve based on ligic and
    /// need a 'flat' distribution of items, centerPercentage = 0.5, centerHeight = 0, and scaleFactor = 0.1 will work well enough most of the time.
    /// You can adjust the centerPercentage and scaleFactor to create 'sliding' lists. For example, if you have a list of opponents ordered by difficulty,
    /// and the character is inexperienced, you might want to select an opponent from the first half of the list. You can do this by setting the centerPercentage
    /// to zero and the scaleFactor to 5. This will cause the curve to be skewed heavily to the left and the items in the first half of the list will be more likely to be selected.
    /// Perhaps more importantly, opponents that would easily defeat the character will practically never be selected.
    /// </remarks
    /// <returns>An item from the list selected based on its weight.</returns>
    /// <exception cref="System.ArgumentNullException">Thrown when the items parameter is null.</exception>
    /// <exception cref="System.ArgumentException">Thrown when the items parameter is an empty list.</exception>
    /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the centerPercentage, centerHeight, or scaleFactor parameters are outside their valid range.</exception>
    public static T SelectItem<T>(List<T> items, double centerPercentage, double centerHeight, double scaleFactor)
    {
        // Validate the inputs
        if (items == null)
        {
            throw new ArgumentNullException(nameof(items));
        }
        if (items.Count == 0)
        {
            throw new ArgumentException("The list of items must not be empty.", nameof(items));
        }
        if (centerPercentage < 0 || centerPercentage > 1)
        {
            throw new ArgumentOutOfRangeException(nameof(centerPercentage), centerPercentage, "The center percentage must be between 0 and 1.");
        }
        if (centerHeight < 0 || centerHeight > 0.95)
        {
            throw new ArgumentOutOfRangeException(nameof(centerHeight), centerHeight, "The center height must be between 0 and 0.95.");
        }
        if (scaleFactor <= 0 || scaleFactor > 10)
        {
            throw new ArgumentOutOfRangeException(nameof(scaleFactor), scaleFactor, "The scale factor must be between 0 and 10.");
        }

        // Create a list of weights based on a normal distribution
        List<double> weights = new List<double>();

        // Calculate the mean for the normal distribution
        double mean = centerPercentage * (items.Count - 1);

        // Calculate the standard deviation for the normal distribution based on the center height and scaling factor
        double stdDev = (1 - centerHeight) * items.Count / scaleFactor;

        // Create a list of weights based on the normal distribution
        for (int i = 0; i < items.Count; i++)
        {
            double x = (i - mean) / stdDev;
            double weight = Math.Exp(-0.5 * x * x) / (stdDev * Math.Sqrt(2 * Math.PI));
            weights.Add(weight);
        }

        // Calculate the total weight
        double totalWeight = weights.Sum();

        // Generate a random number between 0 and the total weight
        double randomNumber = random.NextDouble() * totalWeight;

        // Select an item based on its weight
        for (int i = 0; i < items.Count; i++)
        {
            randomNumber -= weights[i];
            if (randomNumber <= 0)
            {
                return items[i];
            }
        }

        // If we get here, there was an error selecting an item
        throw new InvalidOperationException("Could not select an item from the list.");
    }
}
