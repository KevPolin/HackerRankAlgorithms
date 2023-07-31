//HackerRank: 23. ElectronicsShop

//A person wants to determine the most expensive computer keyboard and USB drive that can be purchased with a give budget.
//Given price lists for keyboards and USB drives and a budget, find the cost to buy them. If it is not possible to buy both items, return -1.

//Example
//b = 60, keyboards =[40, 50, 60], drives =[5, 8, 12]
//The person can buy a 40 keyboard + 12 USB drive = 52, or a 50 keyboard + 8 USB drive = 58.
//Choose the latter as the more expensive option and return 58.

//int keyboards[n]: the keyboard prices
//int drives[m]: the drive prices
//int b: the budget

using System.Diagnostics;

class ElectronicsShop
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, ElectronicsShop, with parameters: TBD ");

        //List<int> myList = new List<int> { 3, 10, 2, 9 };
        int steps = 5;
        string path = "Test";

        int moneySpent = Solution(keyboards, drives, b);
        Console.WriteLine("Results: {0}", moneySpent);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the getMoneySpent function below.
     */
    static int Solution(int[] keyboards, int[] drives, int b)
    {
        var sortedKeyboardPrices = from keyboard in keyboards
                                   orderby keyboard descending
                                   select keyboard;
        var sortedDrivePrices = from drive in drives
                                orderby drive ascending
                                select drive;
        //default if not able to purchase anything
        var maxMoneySpendable = -1;

        foreach (var keyboard in sortedKeyboardPrices)
        {
            foreach (var drive in sortedDrivePrices)
            {
                if (keyboard + drive <= totalMoneyAvailable)
                {
                    if (keyboard + drive > maxMoneySpendable)
                        maxMoneySpendable = keyboard + drive;
                }
                else
                    break;
            }
        }
        return maxMoneySpendable;

    }
}
