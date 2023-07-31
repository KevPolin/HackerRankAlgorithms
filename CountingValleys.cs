//HackerRank: 22. CountingValleys

//An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly STEPS steps, 
//for every step it was noted if it was an uphill, U, or a downhill, D step. 
//Hikes always start and end at sea level, and each step up or down represents a 1 unit change in altitude. We define the following terms:

//A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
//A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
//Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

//Example: STEPS = 8, PATH = DDUUUUDD

//The hiker first enters a valley 2 units deep. Then they climb out and up onto a mountain 2 units high. 
//Finally, the hiker returns to sea level and ends the hike.

class CountingValleys
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, CountingValleys, with parameters: TBD ");

        //List<int> myList = new List<int> { 3, 10, 2, 9 };
        int steps = 16;
        string path = "UDDDUDUUUDDDUDUU";

        int result = Solution(steps, path);
        Console.WriteLine("Results: {0}", result);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int Solution(int steps, string path)
    {
        int seaLevel = 0;
        int valleyCount = 0;
        var isValleyActive = false;
        char[] arr;
        arr = path.ToCharArray(0, steps);
        for (int i = 0; i < steps; i++)
        {
            if (arr[i] == 'U')
            {
                seaLevel++;
            }
            else
            {
                seaLevel--;
            }
            if (!isValleyActive && seaLevel < 0)
            {
                isValleyActive = true;
            }

            if (isValleyActive && seaLevel == 0)
            {
                valleyCount++;
                isValleyActive = false;
            }
        }
        return valleyCount;
    }
}
