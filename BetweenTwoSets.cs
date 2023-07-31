//HackerRank: BetweenTwoSets

//There will be two arrays of integers. Determine all integers that satisfy the following two conditions:

//The elements of the first array are all factors of the integer being considered
//The integer being considered is a factor of all elements of the second array
//These numbers are referred to as being between the two arrays. Determine how many such numbers exist.

//Example
//a=[2,6]
//b =[24, 36]

//There are two numbers between the arrays: 6 and 12.
//6%2=0, 6%6=0, 24%6=0, 36%6=0 for the first value.
//12%2=0, 12%6=0 and 24%12=0, 36$12=0 for the second value.
//Return 2

class BetweenTwoSets
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, BetweenTwoSets, with parameters: TBD ");

        List<int> a = new List<int> { 2,6 };
        List<int> b = new List<int> { 24,36  };

        Solution(a,b);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static void Solution(List<int> a, List<int> b)
    {
        var totalXs = 0;
        var maximumA = a.Max();
        var minimumB = b.Min();
        var counter = 1;
        var multipleOfMaxA = maximumA;

        while (multipleOfMaxA <= minimumB)
        {
            var factorOfAll = true;

            foreach (var item in a)
            {
                if (multipleOfMaxA % item != 0)
                {
                    factorOfAll = false;
                    break;
                }
            }

            if (factorOfAll)
            {
                foreach (var item in b)
                {
                    if (item % multipleOfMaxA != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }
            }

            if (factorOfAll)
                totalXs++;

            counter++;
            multipleOfMaxA = maximumA * counter;
        }
        Console.WriteLine(totalXs);
    }
}