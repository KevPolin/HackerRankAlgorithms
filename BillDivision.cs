//HackerRank: 20. BillDivision

//Two friends Anna and Brian, are deciding how to split the bill at a dinner. Each will only pay for the items they consume. 
//Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.

//If Brian calculates the bill correctly, Anna will pay (2+4)/ 2 = 3.
//If he includes the cost of bill[2], he will calculate (2+4+6)/ 2 = 6.
//In the second case, he should refund 3 to Anna.

class BillDivision
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, BillDivision, with parameters: TBD ");

        List<int> bill = new List<int> { 3,10,2,9 };
        int itemNotEaten = 1;
        int annasContribution = 12;

        Solution(bill, itemNotEaten, annasContribution);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k -- index of item Anna wont eat
     *  3. INTEGER b -- amount of money Anna contributed to the bill
     */

    public static void Solution(List<int> bill, int itemNotEaten, int annasContribution)
    {
        var sharedFoodItemsBill = 0;
        string result = null;

        for (int i = 0; i < bill.Count; i++)
        {
            if (i != itemNotEaten)
                sharedFoodItemsBill += bill[i];
        }

        var annasShare = sharedFoodItemsBill / 2;
        if (annasContribution == annasShare)
        { result = "Bon Appetit"; }
        else
        { result = (annasContribution - annasShare).ToString(); }

        Console.WriteLine("Results: {0}", result); 

    }
}
