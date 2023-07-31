//HackerRank: 22. DrawingBook
//A teacher asks the class to open their books to a page number. 
//A student can either start turning pages from the front of the book or from the back of the book. 
//They always turn pages one at a time. When they open the book, page 1 is always on the right side:

//When they flip page 1, they see pages 2 and 3. Each page except the last page will always be printed on both sides. 
//The last page may only be printed on the front, given the length of the book. 
//If the book is  pages long, and a student wants to turn to page p, what is the minimum number of pages to turn? 
//They can start at the beginning or the end of the book.

//Given n and p, find and print the minimum number of pages that must be turned in order to arrive at page p.

//Example: n=5, p=3

//Using the diagram above, if the student wants to get to page 3, they open the book to page 1, flip 1 page and they are on the correct page. 
//If they open the book to the last page, page 5, they turn 1 page and are at the correct page. Return 1.

class DrawingBook
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running project, DrawingBook, with parameters: TBD ");

        //List<int> bill = new List<int> { 3, 10, 2, 9 };
        int numberOfPages = 5;
        int pageNumber = 3;

        int result = Solution(numberOfPages, pageNumber);
        Console.WriteLine("Results: {0}", result);

        Console.WriteLine("Finished running project");
    }

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int Solution(int numberOfPages, int pageNumber)
    {
        var minimumPagesToTurn = 0;

        if (pageNumber == 1 || pageNumber == numberOfPages)
            return minimumPagesToTurn;

        if (numberOfPages % 2 != 0 && pageNumber == numberOfPages - 1)
            return minimumPagesToTurn;


        if (numberOfPages % 2 == 0)
        {
            //even number of total pages e.g. 10
            if (pageNumber <= numberOfPages / 2)
            {
                //start from front
                minimumPagesToTurn = pageNumber / 2;
            }
            else
            {
                //start from end
                double d = ((double)(numberOfPages - pageNumber)) / 2;
                minimumPagesToTurn = (int)Math.Ceiling(d);
            }
        }
        else
        {
            //total number of pages are odd

            //special handling for exactly middle number when total number of pages are like 3,7,11,15...and so on

            if (pageNumber == (numberOfPages / 2) + 1 && numberOfPages % 4 == 3)
            {
                //this requires special handling as this median will be close to the end instead
                minimumPagesToTurn = (numberOfPages - pageNumber) / 2;
            }
            else
            {
                if (pageNumber <= ((numberOfPages / 2) + 1))
                {
                    //start from front
                    minimumPagesToTurn = pageNumber / 2;
                }
                else
                {
                    //start from end
                    minimumPagesToTurn = (numberOfPages - pageNumber) / 2;
                }
            }

        }
        return minimumPagesToTurn;

        //Console.WriteLine("Results: {0}", result);

    }
}