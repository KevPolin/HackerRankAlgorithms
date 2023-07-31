// HackerRank: NumberLineJumps

//You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction 
//(i.e, toward positive infinity).

//The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
//The second kangaroo starts at location x2 and moves at a rate of v2 meters per jump.
//You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return YES, otherwise return NO.

//Example: x1 = 2, v1 = 1, x2 = 1, v2 =2

//After one jump, they are both at , (, ), so the answer is YES.

class NumberLineJumps
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, NumberLineJumps, with parameters: TBD ");

        Solution(2, 1, 1, 2);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static void Solution(int x1, int v1, int x2, int v2)
    {
        var sameLocationPossible = "";
        if (x1 < x2 && v1 < v2)
            sameLocationPossible = "NO";

        else if (x2 < x1 && v2 < v1)
            sameLocationPossible = "NO";

        else if (x2 < x1)
        {
            //v2 > v1
            var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        else
        {
            //v1 > v2
            var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                sameLocationPossible = "YES";
            else
                sameLocationPossible = "NO";
        }
        Console.WriteLine(sameLocationPossible);

    }
}
