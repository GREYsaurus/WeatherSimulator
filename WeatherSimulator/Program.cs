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

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }

            return min;
        }
        
        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }

            return max;
        }

        static string CommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
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
            
            
            Console.WriteLine($"Average temperature is : {averageTemp}");
            Console.WriteLine($"The maximum temperature was: {MaxTemperature(temperature)}");
            Console.WriteLine($"The minimum temperature was: {MinTemperature(temperature)}");
            Console.WriteLine($"The most common condition was: {CommonCondition(conditions)}");
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
