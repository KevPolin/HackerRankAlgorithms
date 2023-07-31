//HackerRank: BirthdayCakeCandles

//You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age.
//They will only be able to blow out the tallest of the candles. Count how many candles are tallest.
//Example: Camdles [ 4 4 1 3]

//The maximum height candles are 4 units high. There are 2 of them, so return 2.

class BirthdayCakeCandles
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, BirthdayCakeCandles, with parameters: 4 4 1 3");

        List<int> ints = new List<int> { 4, 4, 1, 3 };

        BirthdayCakeCandlesCalculation(ints);

        Console.WriteLine("Finished running project");
    }

    public static void BirthdayCakeCandlesCalculation(List<int> candles)
    {
        var maxValue = candles[0];
        var maxValueOccurence = 1;

        for (int i = 1; i < candles.Count; i++)
        {
            if (candles[i] == maxValue)
            {
                maxValueOccurence++;
                continue;
            }
            if (candles[i] > maxValue)
            {
                maxValue = candles[i];
                maxValueOccurence = 1;
            }
        }
        Console.WriteLine(maxValueOccurence);
    }
}