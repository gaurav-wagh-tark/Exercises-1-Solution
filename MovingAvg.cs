namespace Exercises_1_Solution
{
    internal class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 0; i < data.Length - (k - 1); i++)
            {
                double avg = 0.0;
                for (int j = i; j < k + i; j++) avg += data[j];

                avg /= k;
                if (max < avg) max = avg;
                if (min > avg) min = avg;
            }
            return max - min;
        }
    }
}
