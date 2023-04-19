namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create directory to store CSV files
            string csvDir = @"..\..\..\csv_files";
            Directory.CreateDirectory(csvDir);

            // Define input values
            List<int> items = Enumerable.Range(1, 100).ToList();
            double[] centerPercentages = { 0, 0.5, 1 };
            double[] centerHeights = { 0, 0.5, 0.95 };
            double[] scaleFactors = { 0.1, 1, 10 };

            // Create CSV files for each combination of input values
            foreach (double centerPercentage in centerPercentages)
            {
                foreach (double centerHeight in centerHeights)
                {
                    foreach (double scaleFactor in scaleFactors)
                    {
                        // Define CSV file path
                        string csvFileName = $"center{centerPercentage}_height{centerHeight}_scale{scaleFactor}.csv";
                        string csvFilePath = Path.Combine(csvDir, csvFileName);

                        // Generate data and write to CSV file
                        List<Tuple<int, double>> data = GenerateData(items, centerPercentage, centerHeight, scaleFactor);
                        WriteToCsv(data, csvFilePath);
                    }
                }
            }
        }

        static List<Tuple<int, double>> GenerateData(List<int> items, double centerPercentage, double centerHeight, double scaleFactor)
        {
            List<Tuple<int, double>> data = new List<Tuple<int, double>>();

            // Create a list of weights
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

            // Calculate the frequency of each item
            for (int i = 0; i < items.Count; i++)
            {
                double frequency = weights[i] / totalWeight;
                data.Add(new Tuple<int, double>(items[i], frequency));
            }

            // Sort the data by item value
            data = data.OrderBy(x => x.Item1).ToList();

            return data;
        }

        static void WriteToCsv(List<Tuple<int, double>> data, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Item,Frequency");

                foreach (Tuple<int, double> tuple in data)
                {
                    sw.WriteLine($"{tuple.Item1},{tuple.Item2}");
                }
            }
        }
    }
}
