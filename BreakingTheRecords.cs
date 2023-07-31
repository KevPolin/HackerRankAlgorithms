//HackerRank: BreakingTheRecords

//Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. 
//She tabulates the number of times she breaks her season record for most points and least points in a game. 
//Points scored in the first game establish her record for the season, and she begins counting from there.

//Sample Input: 10 5 20 20 4 5 2 25 1
//Sample Output: 2 4

class PlusMinus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, BreakingTheRecords, with parameters: TBD ");

        List<int> arr = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

        Solution(arr);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'BreakingTheRecords' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void Solution(List<int> scores)
    {
        int highestScore = scores[0];
        int lowestScore = scores[0];
        int highestScoreCount = 0;
        int lowestScoreCount = 0;
        int n = scores.Count;

        for (int i = 0; i < n; i++)
        {
            if (highestScore < scores[i])
            {
                highestScore = scores[i];
                highestScoreCount++;
            }
            else if (lowestScore > scores[i])
            {
                lowestScore = scores[i];
                lowestScoreCount++;
            }
        }
        Console.WriteLine(highestScoreCount + " " + lowestScoreCount);
    }
}

