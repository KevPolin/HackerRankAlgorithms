//HackerRank: MigratoryBirds

//Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. 
//If more than 1 type has been spotted that maximum amount, return the smallest of their ids.

//Example
//ar = [1, 1, 2, 2, 3]
//There are two each of types 1 and 2, and one sighting of type 3. Pick the lower of the two types seen twice: type 1.

class MigratoryBirds
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, MigratoryBirds, with parameters: TBD ");

        List<int> arr = new List<int> { 1, 1, 2, 2, 3 };

        Solution(arr);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void Solution(List<int> ar)
    {
        
            var birdTypeCounts = new int[5];

            for (int i = 0; i < ar.Count; i++)
                birdTypeCounts[ar[i] - 1]++;

            var maxBirdTypeCount = birdTypeCounts[0];
            var maxBirdType = 1;

            for (int i = 1; i < 5; i++)
            {
                if (birdTypeCounts[i] > maxBirdTypeCount)
                {
                    maxBirdTypeCount = birdTypeCounts[i];
                    maxBirdType = i + 1;
                }

                if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                    maxBirdType = i + 1;
            }
            Console.WriteLine("Results: {0}", maxBirdType);
        

    }
}
