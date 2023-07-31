//HackerRank: A Very Big Sum

//In this challenge, you are required to calculate and print the sum of the elements in an array,
//keeping in mind that some of those integers may be quite large.

class AVeryBigSum
{
    public static void Main(string[] args)
    {
        long a = 1000000;
        long b = 990;
        long c = 1000000;
        long d = 20000000;

        Console.WriteLine("Running project, A Very Big Sum, with parameters: {0}, {1}, {2}, {3} ", a, b, c, d);

        List<long> arr1 = new List<long> { a, b, c, d };

        long result = aVeryBigSum(arr1);

        Console.WriteLine("Result is: {0}", result);
        Console.WriteLine("Finished running project");
    }

    public static long aVeryBigSum(List<long> ar)
    {
        long result = 0;

        for (int i = 0; i < ar.Count; i++)
        {
            result = result + ar[i];

        }
        return result;
    }
}