namespace Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    namespace WeightedRandomSelectionTests
    {
        [TestClass]
        public class WeightedRandomSelectionTests
        {
            [TestMethod]
            public void SelectItem_ThrowsException_WhenItemsIsNull()
            {
                // Arrange
                List<int>? items = null;
                double centerPercentage = 0.5;
                double centerHeight = 0.5;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentNullException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenItemsIsEmpty()
            {
                // Arrange
                List<int> items = new List<int>();
                double centerPercentage = 0.5;
                double centerHeight = 0.5;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenCenterPercentageIsLessThanZero()
            {
                // Arrange
                List<int> items = new List<int> { 1, 2, 3 };
                double centerPercentage = -0.1;
                double centerHeight = 0.5;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenCenterPercentageIsGreaterThanOne()
            {
                // Arrange
                List<int> items = new List<int> { 1, 2, 3 };
                double centerPercentage = 1.1;
                double centerHeight = 0.5;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenCenterHeightIsLessThanZero()
            {
                // Arrange
                List<int> items = new List<int> { 1, 2, 3 };
                double centerPercentage = 0.5;
                double centerHeight = -0.1;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenCenterHeightIsGreaterThanOne()
            {
                // Arrange
                List<int> items = new List<int> { 1, 2, 3 };
                double centerPercentage = 0.5;
                double centerHeight = 1.1;
                double scaleFactor = 6;

                // Act and Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ThrowsException_WhenScaleFactorIsLessThanOrEqualToZero()
            {
                // Arrange
                List<int> items = new List<int> { 1, 2, 3 };
                double centerPercentage = 0.5;
                double centerHeight = 0.5;
                double scaleFactor = -0.1;

                // Act and Assert
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor));
            }

            [TestMethod]
            public void SelectItem_ReturnsUniformDistribution_WhenCurveIsFlat()
            {
                // Arrange
                List<int> items = Enumerable.Range(1, 100).ToList();
                double centerPercentage = 0.5;
                double centerHeight = 0;
                double scaleFactor = 0.1;
                int numTrials = 1000000;
                Dictionary<int, int> counts = new Dictionary<int, int>();

                // Act
                for (int i = 0; i < numTrials; i++)
                {
                    int selectedItem = WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor);
                    if (!counts.ContainsKey(selectedItem))
                    {
                        counts[selectedItem] = 0;
                    }
                    counts[selectedItem]++;
                }
                // Assert
                double expectedCount = (double)numTrials / items.Count;
                double tolerance = 0.04 * expectedCount;
                foreach (var count in counts)
                {
                    Assert.IsTrue(Math.Abs(count.Value - expectedCount) <= tolerance);
                }
            }

            [TestMethod]
            public void SelectItem_CenterProbabilityIncreases_WhenCenterHeightIncreases()
            {
                // Arrange
                List<int> items = Enumerable.Range(1, 100).ToList();
                double centerPercentage = 0.95;
                double scaleFactor = 0.1;
                int numTrials = 10000;
                int centerIndex = (int)(centerPercentage * (items.Count - 1));
                int centerItem = items[centerIndex];
                Dictionary<double, int> counts = new Dictionary<double, int>();

                // Act
                for (double centerHeight = 0; centerHeight <= 0.95; centerHeight += 0.01)
                {
                    int count = 0;
                    for (int i = 0; i < numTrials; i++)
                    {
                        int selectedItem = WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor);
                        if (selectedItem == centerItem)
                        {
                            count++;
                        }
                    }
                    counts[centerHeight] = count;
                }

                // Assert
                double prevCount = 0;
                double tolerance = numTrials * 0.01;
                foreach (double centerHeight in counts.Keys.OrderBy(x => x))
                {
                    double count = counts[centerHeight];
                    Assert.IsTrue(count >= prevCount - tolerance);
                    prevCount = count;
                }
            }

            [TestMethod]
            public void SelectItem_ResultsWindowShrinks_WhenScaleFactorIncreases()
            {
                // Arrange
                List<int> items = Enumerable.Range(1, 1000).ToList();
                double centerPercentage = 0.95;
                double centerHeight = 0.5;
                int numTrials = 10000;
                int centerIndex = (int)(centerPercentage * (items.Count - 1));
                int centerItem = items[centerIndex];
                int previousCount = items.Count;
                Dictionary<double, int> counts = new Dictionary<double, int>();

                // Act
                for (double scaleFactor = 0.5; scaleFactor <= 10; scaleFactor += 0.5)
                {
                    // Act
                    for (int i = 0; i < numTrials; i++)
                    {
                        int selectedItem = WeightedRandomSelection.SelectItem(items, centerPercentage, centerHeight, scaleFactor);
                        if (!counts.ContainsKey(selectedItem))
                        {
                            counts[selectedItem] = 0;
                        }
                        counts[selectedItem]++;
                    }
                    // Assert
                    Assert.IsTrue(counts.Count <= previousCount);
                    previousCount = counts.Count;
                    counts = new Dictionary<double, int>();
                }
            }
        }
    }
}
