//HackerRank: Compare The Triplets

//The rating for Alice's challenge is the triplet a = (a[0], a[1], a[2]), and the rating for Bob's challenge is the triplet b = (b[0], b[1], b[2]).
//The task is to find their comparison points by comparing a[0] with b[0], a[1] with b[1], and a[2] with b[2].

class CompareTheTriplets
{
    static void Main()
    {
        List<int> arr1 = new List<int> { 2, 3, 5 };
        List<int> arr2 = new List<int> { 1, 5, 7 };
        List<int> result;

        Console.WriteLine("Running project, CompareTheTriplets, with parameters: 2, 3, 5 and 1, 5, 7");

        result = compareTriplets(arr1, arr2);

        Console.WriteLine("Results of comparing triplets: " + result[0] + " " + result[1]);
        Console.WriteLine("Finished running project, CompareTheTriplets");
    }

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int> { 0, 0 };

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                result[0] = result[0] + 1;
            }

            if (a[i] < b[i])
            {
                result[1] = result[1] + 1;
            }
        }
        return result;
    }

    // first pass
    //public static List<int> compareTriplets(List<int> a, List<int> b)
    //{
    //    {
    //        List<int> result = new List<int> { 0, 0 };

    //        if (a[0] > b[0])
    //        {
    //            result[0] = result[0] + 1;
    //        }

    //        if (a[0] < b[0])
    //        {
    //            result[1] = result[1] + 1;
    //        }

    //        if (a[1] > b[1])
    //        {
    //            result[0] = result[0] + 1;
    //        }

    //        if (a[1] < b[1])
    //        {
    //            result[1] = result[1] + 1;
    //        }

    //        if (a[2] > b[2])
    //        {
    //            result[0] = result[0] + 1;
    //        }

    //        if (a[2] < b[2])
    //        {
    //            result[1] = result[1] + 1;
    //        }
    //        return result;
    //    }
}