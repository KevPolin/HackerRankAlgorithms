//HackerRank: AppleAndOrange

//The red region denotes the house, where  is the start point, and  is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
//Assume the trees are located on a single point, where the apple tree is at point , and the orange tree is at point .
//When a fruit falls from its tree, it lands  units of distance from its tree of origin along the -axis. 
//*A negative value of  means the fruit fell  units to the tree's left, and a positive value of  means it falls  units to the tree's right. *

//Given the value of  for  apples and  oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range )?

class AppleAndOrange
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, AppleAndOrange, with parameters: TBD ");

        List<int> apples = new List<int> { 3, 4, 7, 2 };
        List<int> oranges = new List<int> { 5, 4, 2, 1 };

        Solution(4,5,2,7,apples,oranges);

        Console.WriteLine("Finished running project");
    }

    public static void Solution(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {

        /*
 * Complete the 'countApplesAndOranges' function below.
 *
 * The function accepts following parameters:
 *  1. INTEGER s
 *  2. INTEGER t
 *  3. INTEGER a
 *  4. INTEGER b
 *  5. INTEGER_ARRAY apples
 *  6. INTEGER_ARRAY oranges
 */

        var applesCount = 0;
        var orangeCount = 0;

        foreach (var element in apples)
        {
            var result = a + element;
            if (result >= s && result <= t)
            {
                applesCount++;
            }
        }

        foreach (var element in oranges)
        {
            var result = b + element;
            if (result <= t && result >= s)
            {
                orangeCount++;
            }
        }

        Console.WriteLine(applesCount + "\n" + orangeCount);

    }
}
