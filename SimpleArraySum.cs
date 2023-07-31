//HackerRank: Simple Array Sum

//Given an array of integers, find the sum of its elements.

class SimpleArraySum
{
    public static void Main(string[] args)
    {
        int a = 100;
        int b = 99;
        int c = 1;
        int d = 2;

        Console.WriteLine("Running project, Simple Array Sum, with parameters: {0}, {1}, {2}, {3} ", a, b, c, d);

        List<int> arr1 = new List<int> { a, b, c, d };

        int result = simpleArraySum(arr1);

        Console.WriteLine("Result is: {0}", result);
        Console.WriteLine("Finished running project, Simple Array Sum");
    }

    public static int simpleArraySum(List<int> ar)
    {
        int result = 0;

        for (int i = 0; i < ar.Count; i++)
        {
            result = result + ar[i];
        }
        return result;
    }

}