//HackerRank: DivisibleSumPairs

//Given an array of integers and a positive integer k, determine the number of (i, j) pairs
//where i<j and ar[i] +ar[j] is divisible by k.

//Example
//ar = [1, 2, 3, 4, 5, 6]
//k=5

//Three pairs meet the criteria: [1,4], [2,3] and [4, 6].

class DivisibleSumPairs
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, DivisibleSumPairs, with parameters: TBD ");

        List<int> ar = new List<int> { 1, 2, 3, 4, 5, 6 };
        int n = 6;
        int k = 5;

        Solution(n, k, ar);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static void Solution(int n, int k, List<int> ar)
    {
        {
            var divisiblePairCount = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        divisiblePairCount++;
                }
            }

            Console.WriteLine("Results: {0}", divisiblePairCount);
        }

    }
}
