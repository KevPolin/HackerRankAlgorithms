//HackerRank: MiniMaxSum

//Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.
//
//Example: arr [1 3 5 7 9]
//
//The minimum sum is 16 and the maximum sum is 24. The function prints: 16 24

class MiniMaxSum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, Staircase, with parameters: 1 3 5 7 9");

        List<int> ints = new List<int> { 1, 3, 5, 7, 9 };

        MiniMaxSumCalc(ints);

        Console.WriteLine("Finished running project");
    }

    public static void MiniMaxSumCalc(List<int> arr)
    {
        var sumOfAllNumbers = 0L;
        var minimum = long.MaxValue;
        var maximum = 0L;

        for (int i = 0; i < 5; i++)
        {
            sumOfAllNumbers += arr[i];
            if (arr[i] < minimum)
                minimum = arr[i];

            if (arr[i] > maximum)
                maximum = arr[i];

        }
        Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }
}