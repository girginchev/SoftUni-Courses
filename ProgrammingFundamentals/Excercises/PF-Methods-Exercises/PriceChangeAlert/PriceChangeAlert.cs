namespace PriceChangeAlert
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numOfLines = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine()) * 100;
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double difference = GetDifference(lastPrice, currentPrice);

                bool isSignificantDifference = IsDirfferenceSignificant(difference, threshold);

                string message = GetMessageForChange(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        public static string GetMessageForChange(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string message = string.Empty;
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
            }
            return message;
        }
        public static bool IsDirfferenceSignificant(double threshold, double difference)
        {
            if (Math.Abs(threshold) >= difference)
            {
                return true;
            }
            return false;
        }

        public static double GetDifference(double lastPrice, double currentPrice)
        {
            double difference = ((currentPrice - lastPrice) / lastPrice) * 100;
            return difference;
        }
    }
}
