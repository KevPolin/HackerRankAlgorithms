//HackerRank: 21. SalesByMatch

//There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, 
//determine how many pairs of socks with matching colors there are.

//Example
//n=7
//ar=[1,2,1,2,1,3,2]

//There is one pair of color 1 and one of color 2. There are three odd socks left, one of each color. The number of pairs is 2.

using System.Collections;

class SalesByMatch
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, SalesByMatch, with parameters: TBD ");

        List<int> socks = new List<int> { 1, 2, 1, 2, 1, 3, 2 };
        int numberOfSocks = 7;

        Solution(numberOfSocks, socks);

        Console.WriteLine("Finished running project");
    }

    /*
 * Complete the 'sockMerchant' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER_ARRAY ar
 */

    public static void Solution(int n, List<int> socks)
    {
        var pairsFound = 0;
        //var sockColorHash = new Dictionary<int, int>();
        var sockColorHash = new Hashtable();

        foreach (var sock in socks)
        {
            if (sockColorHash.ContainsKey(sock))
            {
                pairsFound++;
                sockColorHash.Remove(sock);
            }
            else
                sockColorHash.Add(sock, 1);
        }
        //return pairsFound;

        Console.WriteLine("Results: {0}", pairsFound);

    }
}
