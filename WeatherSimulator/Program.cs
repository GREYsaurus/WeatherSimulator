namespace WeatherSimulator
{
    internal class Program
    {
        static double AverageTemperature(int[] temperatures)
        {
            double sum = 0;
            foreach (int temp in temperatures)
            {
                sum += temp;
            }
            return sum / temperatures.Length;
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Cloudy", "Rainy", "Snowy", "Windy", "Stormy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40); // Random temperature between -10 and 40 degrees
                weatherConditions[i] = conditions[random.Next(conditions.Length)]; // Random weather condition
            }

            double averageTemp = AverageTemperature(temperature);
            
            Console.WriteLine($"Average temperature is : {averageTemp});
            Console.ReadKey();
        }
    }
}
