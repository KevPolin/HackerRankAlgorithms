//HackerRank: Diagonal Difference

//In this challenge, you are required to calculate and print the sum of the elements in an array,
//keeping in mind that some of those integers may be quite large.

class AVeryBigSum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, Diagonal Difference, with parameters: 11,2,4 / 4,5,6 / 10,8,-12");

        //setup 2-dimentional list
        List<List<int>> arr = new List<List<int>>();
        //11 2 4
        //4 5 6
        //10 8 - 12
        List<int> Data1 = new List<int>();
        List<int> Data2 = new List<int>();
        List<int> Data3 = new List<int>();
        Data1.Add(11);
        Data1.Add(2);
        Data1.Add(4);
        arr.Add(Data1);
        Data2.Add(4);
        Data2.Add(5);
        Data2.Add(6);
        arr.Add(Data2);
        Data3.Add(10);
        Data3.Add(8);
        Data3.Add(-12);
        arr.Add(Data3);

        int result = diagonalDifference(arr);

        Console.WriteLine("Result is: {0}", result);
        Console.WriteLine("Finished running project");
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int firstDiagonal = 0;
        int secondDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            firstDiagonal = firstDiagonal + arr[i][i];
            secondDiagonal = secondDiagonal + arr[i][(arr.Count - 1) - i];
        }

        return Math.Abs(firstDiagonal - secondDiagonal);

    }
}